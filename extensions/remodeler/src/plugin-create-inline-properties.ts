/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { Schema, codemodel, JsonType, processCodeModel, XML, Property, VirtualProperty } from '@microsoft.azure/autorest.codemodel-v3';
import { length, values } from '@microsoft.azure/codegen';

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
  let virtualProperties = schema.details.default.virtualProperties = new Array<VirtualProperty>();

  let [objectProperties, nonObjectProperties] = values(schema.properties).linq.bifurcate(each => each.schema.type === JsonType.Object);


  // run thru the properties in this class.
  for (const property of objectProperties) {
    const name = property.details.default.name;

    // for each object member, make sure that it's inlined it's children that it can.
    inlineSchema(property.schema);

    if (schema.details.default.inline === 'no') {
      // this happens if there is a circular reference.
      // this means that this class should not attempt any inlining of properties.
      // all properties should be exposed as primitive properties only.
      nonObjectProperties = values(schema.properties).linq.toArray();

      // and we should clear out any properties that we inlined up to now
      virtualProperties = schema.details.default.virtualProperties = new Array<VirtualProperty>();

      // and stop working on inlining here.
      break;
    }

    // the target has properties that we can inline
    const childCount = length(property.schema.details.default.virtualProperties);
    if (childCount < threshold || name === 'properties') {
      // if the child property is low enough (or it's 'properties'), let's create virtual properties for each one.
      for (const childProperty of values(property.schema.details.default.virtualProperties)) {

        virtualProperties.push({
          name: `${name} ${childProperty.name}`,
          kind: 'inlined-property',
          containerType: property.schema,
          property: childProperty.property,
          nameComponents: [name, ...childProperty.nameComponents],
        });
      }
    } else {
      // otherwise, we're not below the threshold, and we should treat this as a non-inlined property
      nonObjectProperties.push(property);
    }
  }

  for (const property of nonObjectProperties) {
    const name = property.details.default.name;

    // this is not something that has properties,
    // so we don't need to do any inlining
    // however, we can add it to our list of virtual properties
    // so that our consumers can get it.
    virtualProperties.push({
      name,
      kind: 'my-property',
      containerType: schema,
      property,
      nameComponents: [name],
    });
  }

  // now we should run thru the properties in parent classes and create inliners for each property they have.
  for (const parentSchema of values(schema.allOf)) {

    // make sure that the parent is done.
    inlineSchema(parentSchema);

    // now we go thru the parent's virutal properties and create our own copies 
    for (const virtualProperty of values(parentSchema.details.default.virtualProperties)) {
      // we are just copying over theirs to ours.
      virtualProperties.push({
        name: virtualProperty.name,
        kind: 'parent-property',
        containerType: virtualProperty.containerType,
        property: virtualProperty.property,
        nameComponents: virtualProperty.nameComponents,
      });
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

  for (const schema of values(model.schemas)) {
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
