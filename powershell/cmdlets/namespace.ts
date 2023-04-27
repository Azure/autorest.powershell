/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { clone, items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { Attribute, Field, ImportDirective, Namespace, Property, System } from '@azure-tools/codegen-csharp';
import { Schema, ClientRuntime } from '../llcsharp/exports';
import { State } from '../internal/state';
import { CmdletClass } from './class';
import { DeepPartial } from '@azure-tools/codegen';
import { CommandOperation, VirtualParameter as CommandVirtualParameter } from '../utils/command-operation';
import { IParameter } from '../utils/components';
import { SchemaType, Parameter, Schema as SchemaModel, Operation } from '@azure-tools/codemodel';
import { CategoryAttribute, ParameterAttribute, ParameterCategory, ValidateNotNull } from '../internal/powershell-declarations';
import { hasValidBodyParameters } from '../utils/http-operation';

export class CmdletNamespace extends Namespace {
  inputModels = new Array<Schema>();
  public get outputFolder(): string {
    return this.state.project.cmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: DeepPartial<CmdletNamespace>) {
    super('Cmdlets', parent);
    this.apply(objectInitializer);
  }

  async init() {
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));
    this.add(new ImportDirective(`${ClientRuntime.PowerShell}`));
    this.add(new ImportDirective(`${ClientRuntime.Cmdlets}`));
    this.add(new ImportDirective('System'));

    // generate cmdlet classes on top of the SDK
    for (const { key: index, value: operation } of items(this.state.model.commands.operations)) {
      // skip ViaIdentity for set-* cmdlets.
      if (this.state.project.azure && operation.details.csharp.verb === 'Set' && operation.details.csharp.name.indexOf('ViaIdentity') > 0) {
        continue;
      }
      const newClass = await new CmdletClass(this, operation, this.state.path('commands', 'operations', index)).init();

      if (operation.variant.includes('ViaJsonString')) {
        const name = 'JsonString';
        const description = `Json string supplied to the ${operation.variant} operation`;
        operation.details.csharp.name = `${operation.variant}Via${name}`;

        const property = new Property(name, System.String);
        property.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = true', `HelpMessage = "${description}"`] }));
        property.add(new Attribute(ValidateNotNull));
        property.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));
        property.set = 'this._jsonString = value;';
        property.get = 'return this._jsonString;';
        newClass.addProperty(property);
        const jsonStringField = new Field("_jsonString", System.String);
        newClass.add(jsonStringField);

        operation.callGraph[0] = clone(operation.callGraph[0]);
        operation.callGraph[0].language.csharp!.name = `${(<any>operation.callGraph[0]).language.csharp!.name}ViaJsonString`;
      }
      if (operation.variant.includes('ViaJsonFilePath')) {
        const name = 'JsonFilePath';
        const description = `Json string supplied to the ${operation.variant} operation`;
        operation.details.csharp.name = `${operation.variant}Via${name}`;

        const property = new Property(name, System.String);
        property.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = true', `HelpMessage = "${description}"`] }));
        property.add(new Attribute(ValidateNotNull));
        property.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));
        property.set = 'if (!System.IO.File.Exists(value)) { throw new Exception("Cannot find File " + value); } this._jsonString = System.IO.File.ReadAllText(value);';
        newClass.addProperty(property);
        const jsonStringField = new Field("_jsonString", System.String);
        newClass.add(jsonStringField);

        operation.callGraph[0] = clone(operation.callGraph[0]);
        operation.callGraph[0].language.csharp!.name = `${(<any>operation.callGraph[0]).language.csharp!.name}ViaJsonString`;
      }
      this.addClass(newClass);
    }
    return this;
  }

  private async addJsonFilePathOperation(
    operation: CommandOperation,
    index: string
  ) {
    const name = 'JsonFilePath';
    const description = `Json string supplied to the ${operation.variant} operation`;
    operation.details.csharp.name = `${operation.variant}ViaJsonFilePath`;

    const newClass = await new CmdletClass(this, operation, this.state.path('commands', 'operations', index)).init();

    const property = new Property(name, System.String);
    property.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = true', `HelpMessage = "${description}"`] }));
    property.add(new Attribute(ValidateNotNull));
    property.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    property.set = 'if (!System.IO.File.Exists(value)) { throw new Exception("Cannot find File " + value); } this._jsonString = System.IO.File.ReadAllText(value);';
    newClass.addProperty(property);

    const jsonStringProperty = newClass.properties.find((item) => item.name === 'JsonString');
    jsonStringProperty!.attributes = [];

    this.addClass(newClass);
  }
}
