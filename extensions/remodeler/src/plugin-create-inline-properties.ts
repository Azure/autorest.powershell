/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { Schema, codemodel, JsonType, processCodeModel, XML, Property, VirtualProperty, VirtualParameter } from '@microsoft.azure/autorest.codemodel-v3';
import { length, values, getPascalIdentifier, removeSequentialDuplicates } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { CommandOperation } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/command-operation';


export async function createInlinedPropertiesPlugin(service: Host) {
  return processCodeModel(createVirtuals, service);
}

const threshold = 24;

function createVirtualProperties(schema: Schema, stack = new Array<string>()) {
  // did we already inline this objecct
  if (schema.details.default.inline === 'yes') {
    return true;
  }

  if (schema.details.default.inline === 'no') {
    return false;
  }

  // this is bad. This would happen when we have a circular reference in the tree.
  if (schema.details.default.inline === 'inprogress') {
    console.error(`Note: model  ${schema.details.default.name} has a circular reference, and we're skipping inlining.\n  ${stack.join(' => ')}`);
    // mark it as 'not-inlining'
    schema.details.default.inline = 'no';
    return false;
  }

  // ok, set to in progress now.
  schema.details.default.inline = 'inprogress';

  // virutual property set.
  let virtualProperties = schema.details.default.virtualProperties = {
    owned: new Array<VirtualProperty>(),
    inherited: new Array<VirtualProperty>(),
    inlined: new Array<VirtualProperty>(),
  };

  // First we should run thru the properties in parent classes and create inliners for each property they have.
  for (const parentSchema of values(schema.allOf)) {
    // make sure that the parent is done.
    createVirtualProperties(parentSchema, [...stack, `${schema.details.default.name}`]);

    const parentProperties = parentSchema.details.default.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: [],
    };

    // now we go thru the parent's virutal properties and create our own copies 
    for (const virtualProperty of [...parentProperties.inherited, ...parentProperties.inlined, ...parentProperties.owned]) {
      // we are just copying over theirs to ours.
      virtualProperties.inherited.push({
        name: virtualProperty.name,
        property: virtualProperty.property,
        private: virtualProperty.private,
        nameComponents: virtualProperty.nameComponents,
        accessViaProperty: virtualProperty,
        accessViaMember: virtualProperty.name,
        accessViaSchema: parentSchema
      });
    }
  }

  let [objectProperties, nonObjectProperties] = values(schema.properties).linq.bifurcate(each => each.schema.type === JsonType.Object);

  // run thru the properties in this class.
  for (const property of objectProperties) {
    const name = property.details.default.name;

    // for each object member, make sure that it's inlined it's children that it can.
    createVirtualProperties(property.schema, [...stack, `${schema.details.default.name}::${name}`]);

    // this happens if there is a circular reference.
    // this means that this class should not attempt any inlining of that property at all .
    const canInline = property.schema.details.default.inline === 'yes';

    // the target has properties that we can inline
    const childCount = length(property.schema.details.default.virtualProperties);
    if (canInline && property.schema.required && (childCount < threshold || name === 'properties')) {
      // if the child property is low enough (or it's 'properties'), let's create virtual properties for each one.
      const virtualChildProperties = property.schema.details.default.virtualProperties || {
        owned: [],
        inherited: [],
        inlined: [],
      };

      // create a private property for the inlined ones to use.
      const privateProperty = {
        name: getPascalIdentifier(name),
        propertySchema: schema,
        property,
        nameComponents: [getPascalIdentifier(name)],
        private: true
      };
      virtualProperties.owned.push(privateProperty);


      for (const inlinedProperty of [...virtualChildProperties.inherited, ...virtualChildProperties.inlined, ...virtualChildProperties.owned]) {
        // child properties are be inlined without prefixing the name with the property name
        // unless there is a collision, in which case, we have to resolve 

        // (scan back from the far right)
        // deeper child properties should be inlined with their parent's name 
        // ie, this.[properties].owner.name should be this.ownerName 
        const proposedName = getPascalIdentifier(inlinedProperty.name);
        virtualProperties.inlined.push({
          name: proposedName,
          property: inlinedProperty.property,
          private: inlinedProperty.private,
          nameComponents: [...removeSequentialDuplicates([name, ...inlinedProperty.nameComponents])],
          accessViaProperty: privateProperty,
          accessViaMember: inlinedProperty.name,
          accessViaSchema: schema
        });
      }
    } else {
      // otherwise, we're not below the threshold, and we should treat this as a non-inlined property
      nonObjectProperties.push(property);
    }
  }

  // resolve name collisions.

  let depth = -2;
  let tryAgain = false;

  const allProps = [...virtualProperties.owned, ...virtualProperties.inherited, ...virtualProperties.inlined];
  // tslint:disable-next-line: no-constant-condition
  do {
    tryAgain = false;
    const inlined = new Map<string, number>();
    for (const each of allProps) {
      // track number of instances of a given name.
      inlined.set(each.name, (inlined.get(each.name) || 0) + 1);
    }

    for (const each of virtualProperties.inlined) {
      const ct = inlined.get(each.name);
      if (ct && ct > 1) {
        const newname = getPascalIdentifier(each.nameComponents.slice(depth, each.nameComponents.length).join(' '));
        if (newname !== each.name) {
          each.name = newname;
          tryAgain = true;
        }
      }
    }
    depth--;
  } while (tryAgain);


  for (const property of nonObjectProperties) {
    const name = getPascalIdentifier(<string>property.details.default.name);
    // this is not something that has properties,
    // so we don't need to do any inlining
    // however, we can add it to our list of virtual properties
    // so that our consumers can get it.
    virtualProperties.owned.push({
      name,
      property,
      nameComponents: [name],
    });
  }

  schema.details.default.inline = 'yes';
  return true;
}

function createVirtualParameters(operation: CommandOperation) {
  const virtualParameters = {
    operation: new Array<VirtualParameter>(),
    body: new Array<VirtualParameter>()
  };

  const dropBodyParameter = operation.details.default.dropBodyParameter ? true : false

  // loop thru the parameters of the command operation, and if there is a body parameter, expand it if necessary.
  for (const parameter of values(operation.parameters)) {
    if (parameter.details.default.constantValue) {
      // this parameter has a constant value -- SKIP IT
      continue;
    }

    if (parameter.details.default.fromHost || parameter.details.default.apiversion) {
      // handled in the generator right now. Not exposed to the user directly.
      continue;
    }

    if (dropBodyParameter && parameter.details.default.isBodyParameter) {
      // the client will make a hidden body parameter for this, and we're expected to fill it.
      const vps = parameter.schema.details.default.virtualProperties;
      if (vps) {
        for (const property of [...vps.inherited, ...vps.owned, ...vps.inlined]) {
          if (property.private || property.property.schema.readOnly) {
            // private or readonly properties aren't needed as parameters.
            continue;
          }
          virtualParameters.body.push({
            name: property.name,
            description: property.property.details.default.description,
            required: property.property.details.default.required,
            schema: property.property.schema,
            origin: property,
          });
        }
      }
    } else {
      virtualParameters.operation.push({
        name: parameter.details.default.name,
        description: parameter.details.default.description,
        required: true, /* if it's present in the variant, it's required  */
        schema: parameter.schema,
        origin: parameter,
      });
    }
  }

  // after that, we need to make sure we avoid name collisions.
  const usedNames = new Set(virtualParameters.operation.map(each => each.name));
  const collision = new Array<VirtualParameter>();

  for (const each of virtualParameters.body) {
    if (usedNames.has(each.name)) {
      collision.push(each);
    }
  }

  for (const each of collision) {
    let depth = -2;
    let newname = each.name;

    const prop = <VirtualProperty>each.origin;
    do {
      newname = getPascalIdentifier(prop.nameComponents.slice(depth, prop.nameComponents.length).join(' '));
    }
    while (usedNames.has(newname) && ((depth * -1) < prop.nameComponents.length));

    while (usedNames.has(newname)) {
      // still bad? 
      newname = newname + "1";
    }
    each.name = newname;
  }


  operation.details.default.virtualParameters = virtualParameters;

}

async function createVirtuals(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
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
      createVirtualProperties(schema);
    }
  }

  for (const operation of values(model.commands.operations)) {
    createVirtualParameters(operation);
  }

  return model;
}
