/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { Schema, codemodel, JsonType, processCodeModel, XML, Property, VirtualProperty } from '@microsoft.azure/autorest.codemodel-v3';
import { items, keys, length, values, Dictionary } from '@microsoft.azure/codegen';

import { Host } from '@microsoft.azure/autorest-extension-base';


export async function createInlinedPropertiesPlugin(service: Host) {
  return processCodeModel(inlineProperties, service);
}

const threshold = 4;

function inlineSchema(schema: Schema) {
  // did we already inline this objecct
  if (schema.details.default.inline === 'yes') {
    return true;
  }

  if (schema.details.default.inline === 'no') {
    return false;
  }

  // this is bad. This would happen when we have a circular reference in the tree.
  if (schema.details.default.inline === 'inprogress') {
    console.error(`Note: model  ${schema.details.default.name} has a circular reference, and we're skipping inlining.`);
    // mark it as 'not-inlining'
    schema.details.default.inline = 'no';
    return false;
  }
  // virutual property set.
  let virtualProperties = schema.details.default.virtualProperties = new Dictionary<VirtualProperty>()

  let [objs, others] = items(schema.properties).linq.bifurcate(each => each.value.schema.type === JsonType.Object);


  // run thru the properties in this class.
  for (const { key: name, value: property } of objs) {

    // for each object member, let's see if it can inline it's children.
    const success = inlineSchema(property.schema);

    if (schema.details.default.inline === 'no') {
      // this happens if there is a circular reference.
      // this means that this class should not attempt any inlining of properties.
      // all properties should be exposed as primitive properties only.
      others = items(schema.properties).linq.toArray();

      // and we should clear out any properties that we inlined up to now
      virtualProperties = schema.details.default.virtualProperties = new Dictionary<VirtualProperty>();

      // and stop working on inlining here.
      break;
    }

    // the target has properties that we can inline
    const childCount = length(property.schema.details.default.virtualProperties);
    if (childCount < threshold || name === 'properties') {
      // if the child property is low enough (or it's 'properties'), let's create virtual properties for each one.
      for (const childProperty of items(property.schema.details.default.virtualProperties)) {
        virtualProperties[`${name} ${childProperty.key}`] = {
          kind: 'child-property',
          container: property.schema,
          property: childProperty.value.property,
          propertyName: [name, ...childProperty.value.propertyName],
        }
      }
    } else {
      // otherwise, we're not below the threshold, and we should treat this as a non-inlined property
      others.push({ key: name, value: property });
    }
  }

  for (const { key: name, value: property } of others) {
    // this is not something that has properties,
    // so we don't need to do any inlining
    // however, we can add it to our list of virtual properties
    // so that our consumers can get it.
    virtualProperties[name] = {
      kind: 'my-property',
      container: schema,
      property,
      propertyName: [name],
    }
  }

  // now we should run thru the properties in parent classes and create inliners for each property they have.
  for (const parentSchema of values(schema.allOf)) {

    // make sure that the parent is done.
    inlineSchema(parentSchema);

    // now we go thru the parent's virutal properties and create our own copies 
    for (const { key: name, value: virtualProperty } of items(parentSchema.details.default.virtualProperties)) {
      // we are just copying over theirs to ours.
      virtualProperties[name] = {
        kind: 'parent-property',
        container: virtualProperty.container,
        property: virtualProperty.property,
        propertyName: virtualProperty.propertyName,
      }
    }
  }

  return true;
}

async function inlineProperties(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  /* 
    A model class should provide inlined properties for anything in a property called properties
    
    Classes that have $THRESHOLD number of properties should be inlined.
 
    Individual models can change the $THRESHOLD for generate
  */

  for (const { key: schemaName, value: schema } of items(model.schemas)) {
    if (schema.type === JsonType.Object) {

      // did we already inline this objecct
      if (schema.details.default.inlined) {
        continue;
      }
      // we have an object, let's process it.
      inlineSchema(schema);
    }
  }
  return model;
}
