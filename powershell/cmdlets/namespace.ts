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
import { CategoryAttribute, ParameterAttribute, ParameterCategory, ValidateNotNull } from '../internal/powershell-declarations';

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
      if (operation.variant.includes('ViaJsonString') || operation.variant.includes('ViaJsonFilePath')) {
        if (operation.details.default.virtualParameters) {
          operation.details.default.virtualParameters.body = [];
        }
        const callGraph = operation.callGraph[operation.callGraph.length - 1];
        if (callGraph.requests && callGraph.requests.length > 0) {
          callGraph.requests[0].parameters = callGraph.requests[0].parameters?.filter(element => element.protocol.http?.in !== 'body');
        }
        if (operation.details.csharp.virtualParameters) {
          operation.details.csharp.virtualParameters.body = [];
        }
        operation.parameters = operation.parameters.filter(element => element.required === true);
      }
      const newClass = await new CmdletClass(this, operation, this.state.path('commands', 'operations', index)).init();

      if (operation.variant.includes('ViaJsonString')) {
        const name = 'JsonString';
        operation.details.csharp.name = `${operation.variant}Via${name}`;

        operation.callGraph[operation.callGraph.length - 1] = clone(operation.callGraph[operation.callGraph.length - 1]);
        operation.callGraph[operation.callGraph.length - 1].language.csharp!.name = `${(<any>operation.callGraph[operation.callGraph.length - 1]).language.csharp!.name}ViaJsonString`;
      }
      if (operation.variant.includes('ViaJsonFilePath')) {
        const name = 'JsonFilePath';
        operation.details.csharp.name = `${operation.variant}Via${name}`;

        const jsonFilePath = newClass.properties.filter(p => p.name === 'JsonFilePath');
        if (jsonFilePath.length > 0) {
          jsonFilePath[0].set = 'if (!System.IO.File.Exists(value)) { throw new Exception("Cannot find File " + value); } this._jsonString = System.IO.File.ReadAllText(value); this._jsonFilePath = value;';
        }
        const jsonStringField = new Field('_jsonString', System.String);
        newClass.add(jsonStringField);

        operation.callGraph[operation.callGraph.length - 1] = clone(operation.callGraph[operation.callGraph.length - 1]);
        operation.callGraph[operation.callGraph.length - 1].language.csharp!.name = `${(<any>operation.callGraph[operation.callGraph.length - 1]).language.csharp!.name}ViaJsonString`;
      }
      this.addClass(newClass);
    }
    return this;
  }
}
