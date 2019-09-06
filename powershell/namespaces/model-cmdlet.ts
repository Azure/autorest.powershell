/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { JsonType } from '@azure-tools/codemodel-v3';
import { ImportStatic, Namespace } from '@azure-tools/codegen-csharp';
import { Schema, ClientRuntime } from '../llcsharp/exports';
import { State } from '../state';
import { ModelCmdlet } from '../model-cmdlet';

export class ModelCmdletNamespace extends Namespace {
  inputModels = new Array<Schema>();
  public get outputFolder(): string {
    return this.state.project.modelCmdletFolder;
  }

  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<ModelCmdletNamespace>) {
    super('ModelCmdlets', parent);
    this.apply(objectInitializer);
    this.add(ImportStatic(ClientRuntime.Extensions));
  }

  public createModelCmdlets() {
    // generate the model cmdlets unless they dont want them.
    if (!this.state.project.skipModelCmdlets) {
      for (const { key: index, value: schema } of items(this.state.model.schemas)) {
        if (schema.type !== JsonType.Object) {
          continue;
        }
        let found = false;

        // check if a cmdlet uses this as a parameter
        for (const sch of values(this.inputModels)) {
          if (sch === schema) {
            found = true;
            break;
          }
        }

        if (found) {
          this.addClass(new ModelCmdlet(this, <Schema>schema, this.state.path('schemas', index)));
        }
      }
    }
  }

  public addInputSchema(schema: Schema) {
    if (schema.type === JsonType.Object) {
      if (this.inputModels.indexOf(schema) === -1) {
        this.inputModels.push(schema);
        for (const p of values(schema.properties)) {
          if (!p.details.csharp.readOnly && !p.details.csharp.HeaderProperty && !p.schema.additionalProperties) {
            this.addInputSchema(p.schema);
          }
        }
      }
    }
  }
}