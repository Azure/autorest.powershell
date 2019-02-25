/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items } from '@microsoft.azure/codegen';
import { ImportDirective, Namespace } from '@microsoft.azure/codegen-csharp';
import { Schema, ClientRuntime } from '@microsoft.azure/autorest.csharp-v2';
import { State } from '../state';
import { CmdletClass } from '../cmdlet-class';

export class CmdletNamespace extends Namespace {
  inputModels = new Array<Schema>();
  public get outputFolder(): string {
    return this.state.project.cmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<CmdletNamespace>) {
    super('Cmdlets', parent);
    this.apply(objectInitializer);
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));

    // generate cmdlet classes on top of the SDK
    for (const { key: id, value: operation } of items(state.model.commands.operations)) {
      this.addClass(new CmdletClass(this, operation, state.path('commands', 'operations', id)));

      /* if (operation.details.powershell.hasBody) {
        // make a copy that doesn't use the body parameter
        this.addClass(new CmdletClass(this, operation, state.path('commands', 'operations', id), true));
      } */

      for (const p of operation.parameters) {
        state.project.modelCmdlets.addInputSchema(<Schema>p.schema);
      }
    }
  }
}