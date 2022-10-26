/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codeModelSchema, CodeModel, ObjectSchema, ConstantSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, ImplementationLocation, OperationGroup, Request, SchemaContext } from '@azure-tools/codemodel';
import { getPascalIdentifier, removeSequentialDuplicates, pascalCase, fixLeadingNumber, deconstruct, selectName, EnglishPluralizationService, serialize } from '@azure-tools/codegen';
import { length, values, } from '@azure-tools/linq';
import { Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { CommandOperation } from '../utils/command-operation';
import { PwshModel } from '../utils/PwshModel';
import { ModelState } from '../utils/model-state';
import { VirtualParameter } from '../utils/command-operation';
import { VirtualProperty, getAllProperties, getAllPublicVirtualProperties } from '../utils/schema';
import { resolveParameterNames } from '../utils/resolve-conflicts';

function getPluralizationService(): EnglishPluralizationService {
  const result = new EnglishPluralizationService();
  result.addWord('Database', 'Databases');
  result.addWord('database', 'databases');
  result.addWord('Premise', 'Premises');
  result.addWord('premise', 'premises');
  return result;
}

type State = ModelState<PwshModel>;

export function singularize(word: string): string {
  return getPluralizationService().singularize(word);
}

function getNameOptions(typeName: string, components: Array<string>) {
  const result = new Set<string>();

  // add a variant for each incrementally inclusive parent naming scheme.
  for (let i = 0; i < length(components); i++) {
    const subset = pascalCase([...removeSequentialDuplicates(components.slice(-1 * i, length(components)))]);
    result.add(subset);
  }

  // add a second-to-last-ditch option as <typename>.<name>
  result.add(pascalCase([...removeSequentialDuplicates([...fixLeadingNumber(deconstruct(typeName)), ...deconstruct(components.last)])]));
  return [...result.values()];
}


function createVirtualProperties(schema: ObjectSchema, stack: Array<string>, threshold: number, conflicts: Array<string>) {
  // Some properties should be removed are wrongly kept as null and need to clean them
  if (schema.properties) {
    schema.properties = schema.properties.filter(each => each);
  }
  // dolauli
  //    owned: all properties(obj & nonobj) in the schema,
  //  inherited: Properties from parents,
  //    inlined: for obj properties, flatten them to children,
  // did we already inline this object
  if (schema.language.default.inline === 'yes') {
    return true;
  }

  if (schema.language.default.inline === 'no') {
    return false;
  }

  // this is bad. This would happen when we have a circular reference in the tree.
  // dolauli curious in which case this will happen, got it to use no-inline to skip inline and avoid circular reference
  if (schema.language.default.inline === 'inprogress') {
    let text = (`Note: during processing of '${schema.language.default.name}' a circular reference has been discovered.`);
    text += '\n  In order to proceed, you must add a directive to indicate which model you want to not inline.\n';
    text += '\ndirective:';
    text += '\n- no-inline:  # choose ONE of these models to disable inlining';
    for (const each of stack) {
      text += (`\n  - ${each} `);
    }
    text += '\n';
    conflicts.push(text);
    /*     `directive:
         - no-inline: 
           - MyModel
           - YourModel
           - HerModel
        ` */

    // `, and we're skipping inlining.\n  ${stack.join(' => ')}`);
    // mark it as 'not-inlining'
    schema.language.default.inline = 'no';
    return false;
  }

  // ok, set to in progress now.
  schema.language.default.inline = 'inprogress';

  // virutual property set.
  const virtualProperties = schema.language.default.virtualProperties = {
    owned: new Array<VirtualProperty>(),
    inherited: new Array<VirtualProperty>(),
    inlined: new Array<VirtualProperty>(),
  };

  // First we should run thru the properties in parent classes and create inliners for each property they have.
  // dolauli handle properties in parents
  for (const parentSchema of values(schema.parents?.immediate)) {
    // make sure that the parent is done.

    // Guess parent should always be an object.
    if (!isObjectSchema(parentSchema))
      continue;

    createVirtualProperties(parentSchema, [...stack, `${schema.language.default.name}`], threshold, conflicts);

    const parentProperties = parentSchema.language.default.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: [],
    };

    // now we go thru the parent's virutal properties and create our own copies 
    for (const virtualProperty of [...parentProperties.inherited, ...parentProperties.inlined, ...parentProperties.owned]) {
      // make sure that we have a list of shared owners of this property.
      virtualProperty.sharedWith = virtualProperty.sharedWith || [virtualProperty];

      // we are just copying over theirs to ours.
      const inheritedProperty = {
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
        readOnly: virtualProperty.readOnly,
        required: virtualProperty.required,
        sharedWith: virtualProperty.sharedWith,
      };
      // add it to the list of virtual properties that share this property.
      virtualProperty.sharedWith.push(inheritedProperty);

      // add it to this class.
      virtualProperties.inherited.push(inheritedProperty);
    }
  }

  // dolauli figure out object properties and non object properties in this class 
  const [objectProperties, nonObjectProperties] = values(schema.properties).bifurcate(each =>
    !schema.language.default['skip-inline'] && // if this schema is marked skip-inline, none can be inlined, treat them all as straight properties.
    !each.schema.language.default['skip-inline'] && // if the property schema is marked skip-inline, then it should not be processed either.
    each.schema.type === SchemaType.Object &&       // is it an object 
    getAllProperties(each.schema).length > 0    // does it have properties (or inherit properties)
  );

  // run thru the properties in this class.
  // dolauli handle properties in this class
  for (const property of objectProperties) {
    const propertyName = property.language.default.name;

    // for each object member, make sure that it's inlined it's children that it can.
    createVirtualProperties(<ObjectSchema>property.schema, [...stack, `${schema.language.default.name}`], threshold, conflicts);

    // this happens if there is a circular reference.
    // this means that this class should not attempt any inlining of that property at all .
    // dolauli pay attention to the condition check
    const isDict = property.schema.type === SchemaType.Dictionary || (<ObjectSchema>property.schema).parents?.immediate?.find((s) => s.type === SchemaType.Dictionary);
    const canInline =
      (!property.schema.language.default['skip-inline']) &&
      (!<ObjectSchema>property.schema.language.default.byReference) &&
      (!isDict) &&
      (<ObjectSchema>property.schema).language.default.inline === 'yes';

    // the target has properties that we can inline
    const virtualChildProperties = property.schema.language.default.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: [],
    };

    const allNotRequired = values(getAllPublicVirtualProperties()).all(each => !each.property.language.default.required);

    const childCount = length(virtualChildProperties.owned) + length(virtualChildProperties.inherited) + length(virtualChildProperties.inlined);
    if (canInline && (property.language.default.required || allNotRequired) && (childCount < threshold || propertyName === 'properties')) {


      // if the child property is low enough (or it's 'properties'), let's create virtual properties for each one.
      // create a private property for the inlined ones to use.
      const privateProperty = {
        name: getPascalIdentifier(propertyName),
        propertySchema: schema,
        property,
        nameComponents: [getPascalIdentifier(propertyName)],
        nameOptions: getNameOptions(schema.language.default.name, [propertyName]),
        private: true,
        description: property.summary || '',
        originalContainingSchema: schema,
        alias: [],
        required: property.required || property.language.default.required,
      };
      virtualProperties.owned.push(privateProperty);

      for (const inlinedProperty of [...virtualChildProperties.inherited, ...virtualChildProperties.owned]) {
        // child properties are be inlined without prefixing the name with the property name
        // unless there is a collision, in which case, we have to resolve 

        // (scan back from the far right)
        // deeper child properties should be inlined with their parent's name 
        // ie, this.[properties].owner.name should be this.ownerName 

        const proposedName = getPascalIdentifier(`${propertyName === 'properties' || /*objectProperties.length === 1*/ propertyName === 'error' ? '' : pascalCase(fixLeadingNumber(deconstruct(propertyName)).map(each => singularize(each)))} ${inlinedProperty.name}`);

        const components = [...removeSequentialDuplicates([propertyName, ...inlinedProperty.nameComponents])];
        virtualProperties.inlined.push({
          name: proposedName,
          property: inlinedProperty.property,
          private: inlinedProperty.private,
          nameComponents: components,
          nameOptions: getNameOptions(inlinedProperty.property.schema.language.default.name, components),
          accessViaProperty: privateProperty,
          accessViaMember: inlinedProperty,
          accessViaSchema: schema,
          originalContainingSchema: schema,
          description: inlinedProperty.description,
          alias: [],
          readOnly: inlinedProperty.readOnly || property.readOnly,
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
          nameOptions: getNameOptions(inlinedProperty.property.schema.language.default.name, components),
          accessViaProperty: privateProperty,
          accessViaMember: inlinedProperty,
          accessViaSchema: schema,
          originalContainingSchema: schema,
          description: inlinedProperty.description,
          alias: [],
          readOnly: inlinedProperty.readOnly || property.readOnly,
          required: inlinedProperty.required && privateProperty.required
        });
      }
    } else {
      // otherwise, we're not below the threshold, and we should treat this as a non-inlined property
      nonObjectProperties.push(property);
    }
  }

  for (const property of nonObjectProperties) {
    const name = getPascalIdentifier(<string>property.language.default.name);
    // this is not something that has properties,
    // so we don't need to do any inlining
    // however, we can add it to our list of virtual properties
    // so that our consumers can get it.
    virtualProperties.owned.push({
      name,
      property,
      nameComponents: [name],
      nameOptions: [name],
      description: property.summary || '',
      originalContainingSchema: schema,
      alias: [],
      readOnly: property.readOnly,
      required: property.required || property.language.default.required
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
  for (const each of virtualProperties.inlined.sort((a, b) => length(a.nameOptions) - length(b.nameOptions))) {
    const ct = inlined.get(each.name);
    if (ct && ct > 1) {
      // console.error(`Fixing collision on name ${each.name} #${ct} `);
      each.name = selectName(each.nameOptions, usedNames);
    }
  }
  schema.language.default.inline = 'yes';
  return true;
}

function createVirtualParameters(operation: CommandOperation) {
  // dolauli expand body parameter
  // for virtual parameters, there are two keys, operation and body
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
    // dolauli fromhost and apiversion are not exposed, this if block looks useless
    if (parameter.details.default.fromHost || parameter.details.default.apiversion) {
      // handled in the generator right now. Not exposed to the user directly.
      continue;
    }

    if (dropBodyParameter && parameter.details.default.isBodyParameter) {
      // the client will make a hidden body parameter for this, and we're expected to fill it.
      const vps = parameter.schema.language.default.virtualProperties;
      if (vps) {
        for (const virtualProperty of [...vps.inherited, ...vps.owned, ...vps.inlined]) {
          // dolauli add virtual parameter for virtual property
          if (virtualProperty.private || virtualProperty.readOnly || virtualProperty.property.readOnly || virtualProperty.property.language.default.constantValue !== undefined || virtualProperty.property.language.default.HeaderProperty === 'Header') {
            // private or readonly properties aren't needed as parameters. 
            continue;
          }
          virtualParameters.body.push({
            name: virtualProperty.name,
            description: virtualProperty.property.language.default.description,
            nameOptions: virtualProperty.nameOptions,
            required: virtualProperty.required,
            schema: virtualProperty.property.schema,
            origin: virtualProperty,
            alias: []
          });
        }
      }
    } else {
      // dolauli if not drop body or not body parameter add it to operation 
      virtualParameters.operation.push({
        name: parameter.details.default.name,
        nameOptions: [parameter.details.default.name],
        description: parameter.details.default.description,
        required: parameter.details.default.isBodyParameter ? true : parameter.required,
        schema: parameter.schema,
        origin: parameter,
        alias: []
      });
    }
  }

  resolveParameterNames([], virtualParameters);

  // dolauli see operation.details.default.virtualParameters
  operation.details.default.virtualParameters = virtualParameters;
}


async function createVirtuals(state: State): Promise<PwshModel> {
  /* 
    A model class should provide inlined properties for anything in a property called properties
    
    Classes that have $THRESHOLD number of properties should be inlined.
 
    Individual models can change the $THRESHOLD for generate
  */
  const threshold = await state.getValue('inlining-threshold', 24);
  const conflicts = new Array<string>();

  for (const schema of values(state.model.schemas.objects)) {
    // did we already inline this objecct
    if (schema.language.default.inlined) {
      continue;
    }
    // we have an object, let's process it.

    createVirtualProperties(schema, new Array<string>(), threshold, conflicts);

  }
  if (length(conflicts) > 0) {
    // dolauli need to figure out how inline-properties is used in README.md
    state.error('You have one or more circular references in your model, you must add configuration entries to specify which models won\'t be inlined.', ['inline-properties']);
    for (const each of conflicts) {
      state.error(each, ['circular reference']);
    }
    throw new Error('Circular references exists, must mark models as `no-inline`');
  }
  //dolauli update operations under commands
  for (const operation of values(state.model.commands.operations)) {
    createVirtualParameters(operation);
  }

  return state.model;
}


export async function createInlinedPropertiesPlugin(service: Host) {
  //const session = await startSession<PwshModel>(service, {}, codeModelSchema);
  //const result = tweakModelV2(session);
  const state = await new ModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-create-virtual-properties-v2.yaml', serialize(await createVirtuals(state)), undefined, 'code-model-v4');
  //return processCodeModel(createVirtuals, service, 'create-virtual-properties-v2');
}
