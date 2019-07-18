/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { Schema, codemodel, JsonType, processCodeModel, VirtualProperty, VirtualParameter, resolveParameterNames, ModelState, getAllProperties, getAllPublicVirtualProperties } from '@microsoft.azure/autorest.codemodel-v3';
import { length, values, getPascalIdentifier, removeSequentialDuplicates, pascalCase, fixLeadingNumber, deconstruct, selectName, EnglishPluralizationService } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { CommandOperation } from '@microsoft.azure/autorest.codemodel-v3/dist/code-model/command-operation';
type State = ModelState<codemodel.Model>;


function getPluralizationService(): EnglishPluralizationService {
  const result = new EnglishPluralizationService();
  result.addWord('Database', 'Databases');
  result.addWord('database', 'databases');
  return result;
}

export function singularize(word: string): string {
  return getPluralizationService().singularize(word);
}

export async function createInlinedPropertiesPlugin(service: Host) {
  return processCodeModel(createVirtuals, service, 'create-virtual-properties');
}

function getNameOptions(typeName: string, components: Array<string>) {
  const result = new Set<string>();

  // add a variant for each incrementally inclusive parent naming scheme.
  for (let i = 0; i < components.length; i++) {
    const subset = pascalCase([...removeSequentialDuplicates(components.slice(-1 * i, components.length))]);
    result.add(subset);
  }

  // add a second-to-last-ditch option as <typename>.<name>
  result.add(pascalCase([...removeSequentialDuplicates([...fixLeadingNumber(deconstruct(typeName)), ...deconstruct(components.last)])]));
  return [...result.values()];
}



function createVirtualProperties(schema: Schema, stack = new Array<string>(), threshold = 30) {
  // did we already inline this objecct
  if (schema.details.default.inline === 'yes') {
    return true;
  }

  if (schema.details.default.inline === 'no') {
    return false;
  }

  // this is bad. This would happen when we have a circular reference in the tree.
  if (schema.details.default.inline === 'inprogress') {
    console.error(`Note: model ${schema.details.default.name} has a circular reference, and we're skipping inlining.\n  ${stack.join(' => ')}`);
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
    createVirtualProperties(parentSchema, [...stack, `${schema.details.default.name}`], threshold);

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
        nameOptions: virtualProperty.nameOptions,
        accessViaProperty: virtualProperty,
        accessViaMember: virtualProperty,
        accessViaSchema: parentSchema,
        originalContainingSchema: virtualProperty.originalContainingSchema,
        description: virtualProperty.description,
        alias: [],
        required: virtualProperty.required,
      });
    }
  }

  let [objectProperties, nonObjectProperties] = values(schema.properties).linq.bifurcate(each =>
    each.schema.type === JsonType.Object &&       // is it an object 
    getAllProperties(each.schema).length > 0    // does it have properties (or inherit properties)
  );

  // run thru the properties in this class.
  for (const property of objectProperties) {
    const propertyName = property.details.default.name;

    // for each object member, make sure that it's inlined it's children that it can.
    createVirtualProperties(property.schema, [...stack, `${schema.details.default.name}::${propertyName}`], threshold);

    // this happens if there is a circular reference.
    // this means that this class should not attempt any inlining of that property at all .
    const canInline = property.schema.details.default.inline === 'yes';

    // the target has properties that we can inline
    const virtualChildProperties = property.schema.details.default.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: [],
    }

    const allNotRequired = values(getAllPublicVirtualProperties()).linq.all(each => !each.property.details.default.required);

    const childCount = length(virtualChildProperties.owned) + length(virtualChildProperties.inherited) + length(virtualChildProperties.inlined);
    if (canInline && (property.details.default.required || allNotRequired) && (childCount < threshold || propertyName === 'properties')) {


      // if the child property is low enough (or it's 'properties'), let's create virtual properties for each one.
      // create a private property for the inlined ones to use.
      const privateProperty = {
        name: getPascalIdentifier(propertyName),
        propertySchema: schema,
        property,
        nameComponents: [getPascalIdentifier(propertyName)],
        nameOptions: getNameOptions(schema.details.default.name, [propertyName]),
        private: true,
        description: property.description || '',
        originalContainingSchema: schema,
        alias: [],
        required: property.details.default.required,
      };
      virtualProperties.owned.push(privateProperty);

      for (const inlinedProperty of [...virtualChildProperties.inherited, ...virtualChildProperties.owned]) {
        // child properties are be inlined without prefixing the name with the property name
        // unless there is a collision, in which case, we have to resolve 

        // (scan back from the far right)
        // deeper child properties should be inlined with their parent's name 
        // ie, this.[properties].owner.name should be this.ownerName 

        const proposedName = getPascalIdentifier(`${propertyName === 'properties' ? '' : pascalCase(fixLeadingNumber(deconstruct(propertyName)).map(each => singularize(each)))} ${inlinedProperty.name}`);

        const components = [...removeSequentialDuplicates([propertyName, ...inlinedProperty.nameComponents])];
        virtualProperties.inlined.push({
          name: proposedName,
          property: inlinedProperty.property,
          private: inlinedProperty.private,
          nameComponents: components,
          nameOptions: getNameOptions(inlinedProperty.property.schema.details.default.name, components),
          accessViaProperty: privateProperty,
          accessViaMember: inlinedProperty,
          accessViaSchema: schema,
          originalContainingSchema: schema,
          description: inlinedProperty.description,
          alias: [],
          required: inlinedProperty.required && privateProperty.required,
        });
      }

      for (const inlinedProperty of [...virtualChildProperties.inlined]) {
        // child properties are be inlined without prefixing the name with the property name
        // unless there is a collision, in which case, we have to resolve 

        // (scan back from the far right)
        // deeper child properties should be inlined with their parent's name 
        // ie, this.[properties].owner.name should be this.ownerName 


        const proposedName = getPascalIdentifier(inlinedProperty.name);
        const components = [...removeSequentialDuplicates([propertyName, ...inlinedProperty.nameComponents])];
        virtualProperties.inlined.push({
          name: proposedName,
          property: inlinedProperty.property,
          private: inlinedProperty.private,
          nameComponents: components,
          nameOptions: getNameOptions(inlinedProperty.property.schema.details.default.name, components),
          accessViaProperty: privateProperty,
          accessViaMember: inlinedProperty,
          accessViaSchema: schema,
          originalContainingSchema: schema,
          description: inlinedProperty.description,
          alias: [],
          required: inlinedProperty.required && privateProperty.required
        });
      }
    } else {
      // otherwise, we're not below the threshold, and we should treat this as a non-inlined property
      nonObjectProperties.push(property);
    }
  }

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
      nameOptions: [name],
      description: property.description || '',
      originalContainingSchema: schema,
      alias: [],
      required: property.details.default.required
    });
  }

  // resolve name collisions.
  const allProps = [...virtualProperties.owned, ...virtualProperties.inherited, ...virtualProperties.inlined];
  const inlined = new Map<string, number>();

  for (const each of allProps) {
    // track number of instances of a given name.
    inlined.set(each.name, (inlined.get(each.name) || 0) + 1);
  }

  const usedNames = new Set(inlined.keys());
  for (const each of virtualProperties.inlined.sort((a, b) => a.nameOptions.length - b.nameOptions.length)) {
    const ct = inlined.get(each.name);
    if (ct && ct > 1) {
      each.name = selectName(each.nameOptions, usedNames);
    }
  }
  schema.details.default.inline = 'yes';
  return true;
}

function createVirtualParameters(operation: CommandOperation) {
  const virtualParameters = {
    operation: new Array<VirtualParameter>(),
    body: new Array<VirtualParameter>()
  };

  const dropBodyParameter = !!operation.details.default.dropBodyParameter;

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
        for (const virtualProperty of [...vps.inherited, ...vps.owned, ...vps.inlined]) {
          if (virtualProperty.private || virtualProperty.property.details.default.readOnly || virtualProperty.property.details.default.constantValue !== undefined || virtualProperty.property.details.default.HeaderProperty === 'Header') {
            // private or readonly properties aren't needed as parameters. 
            continue;
          }
          virtualParameters.body.push({
            name: virtualProperty.name,
            description: virtualProperty.property.details.default.description,
            nameOptions: virtualProperty.nameOptions,
            required: virtualProperty.required,
            schema: virtualProperty.property.schema,
            origin: virtualProperty,
            alias: []
          });
        }
      }
    } else {
      virtualParameters.operation.push({
        name: parameter.details.default.name,
        nameOptions: [parameter.details.default.name],
        description: parameter.details.default.description,
        // required: true, /* if it's present in the variant, it's required  */
        required: parameter.required, /* NEW: parameters pick up requiredness from the original operation. */
        schema: parameter.schema,
        origin: parameter,
        alias: []
      });
    }
  }

  resolveParameterNames([], virtualParameters);


  operation.details.default.virtualParameters = virtualParameters;
}

async function createVirtuals(state: State): Promise<codemodel.Model> {
  /* 
    A model class should provide inlined properties for anything in a property called properties
    
    Classes that have $THRESHOLD number of properties should be inlined.
 
    Individual models can change the $THRESHOLD for generate
  */

  const threshold = await state.getValue('inlining-threshold', 24);

  for (const schema of values(state.model.schemas)) {
    if (schema.type === JsonType.Object) {

      // did we already inline this objecct
      if (schema.details.default.inlined) {
        continue;
      }
      // we have an object, let's process it.
      createVirtualProperties(schema, undefined, threshold);
    }
  }

  for (const operation of values(state.model.commands.operations)) {
    createVirtualParameters(operation);
  }

  return state.model;
}
