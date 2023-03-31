/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import {
  Attribute,
  ImportDirective,
  Namespace,
  Property,
  System,
} from '@azure-tools/codegen-csharp';
import { Schema, ClientRuntime } from '../llcsharp/exports';
import { State } from '../internal/state';
import { CmdletClass } from './class';
import { DeepPartial } from '@azure-tools/codegen';
import {
  CommandOperation,
  VirtualParameter as CommandVirtualParameter,
} from '../utils/command-operation';
import { IParameter } from '../utils/components';
import {
  SchemaType,
  Parameter,
  Schema as SchemaModel,
  Operation,
} from '@azure-tools/codemodel';
import {
  CategoryAttribute,
  ParameterAttribute,
  ParameterCategory,
  ValidateNotNull,
} from '../internal/powershell-declarations';

export class CmdletNamespace extends Namespace {
  inputModels = new Array<Schema>();
  public get outputFolder(): string {
    return this.state.project.cmdletFolder;
  }

  constructor(
    parent: Namespace,
    private state: State,
    objectInitializer?: DeepPartial<CmdletNamespace>
  ) {
    super('Cmdlets', parent);
    this.apply(objectInitializer);
  }

  async init() {
    this.add(new ImportDirective(`static ${ClientRuntime.Extensions}`));
    this.add(new ImportDirective(`${ClientRuntime.Cmdlets}`));
    this.add(new ImportDirective('System'));

    const processedViaJsonOperation = new Set();

    // generate cmdlet classes on top of the SDK
    for (const { key: index, value: operation } of items(
      this.state.model.commands.operations
    )) {
      // skip ViaIdentity for set-* cmdlets.
      if (
        this.state.project.azure &&
        operation.details.csharp.verb === 'Set' &&
        operation.details.csharp.name.indexOf('ViaIdentity') > 0
      ) {
        continue;
      }
      this.addClass(
        await new CmdletClass(
          this,
          operation,
          this.state.path('commands', 'operations', index)
        ).init()
      );

      if (
        this.state.project.supportJsonInput &&
        hasValidBodyParameters(operation)
      ) {
        const operationCommandId = `${operation.verb}-${
          (<any>operation).subjectPrefix
        }${(<any>operation).subject}`;
        if (!processedViaJsonOperation.has(operationCommandId)) {
          const callGraph = {
            language: JSON.parse(
              JSON.stringify(operation.callGraph[0].language)
            ),
            parameters: operation.callGraph[0].parameters!.map((p) => {
              return { ...p };
            }),
            apiVersions: operation.callGraph[0].apiVersions,
            requests: operation.callGraph[0].requests,
            responses: operation.callGraph[0].responses,
            exceptions: operation.callGraph[0].exceptions,
            extensions: operation.callGraph[0].extensions,
          };
          if (callGraph.requests && callGraph.requests.length > 0) {
            callGraph.requests[0].parameters =
              callGraph.requests[0].parameters!.filter(
                (r) => r.protocol.http?.in !== 'body'
              );
            callGraph.requests[0].signatureParameters =
              callGraph.requests[0].signatureParameters!.filter(
                (r) => r.protocol.http?.in !== 'body'
              );
          }
          const jsonOperation = new CommandOperation('', {
            verb: operation.verb,
            noun: operation.noun,
            variant: operation.variant,
            parameters: [...operation.parameters],
            details: { ...operation.details },
            extensions: operation.extensions,
            deprecated: operation.deprecated,
            responses: operation.responses,
            callGraph: [callGraph],
          });
          (<any>jsonOperation).subject = (<any>operation).subject;
          (<any>jsonOperation).subjectPrefix = (<any>operation).subjectPrefix;
          this.addJsonStringOperation(jsonOperation, index);
          this.addJsonFilePathOperation(jsonOperation, index);
          processedViaJsonOperation.add(operationCommandId);
        }
      }
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

    const newClass = await new CmdletClass(
      this,
      operation,
      this.state.path('commands', 'operations', index)
    ).init();

    const property = new Property(name, System.String);
    property.add(
      new Attribute(ParameterAttribute, {
        parameters: ['Mandatory = true', `HelpMessage = "${description}"`],
      })
    );
    property.add(new Attribute(ValidateNotNull));
    property.add(
      new Attribute(CategoryAttribute, {
        parameters: [`${ParameterCategory}.Runtime`],
      })
    );

    property.set = 'if (!System.IO.File.Exists(value)) { throw new Exception("Cannot find File " + value); } this._jsonString = System.IO.File.ReadAllText(value);';
    newClass.addProperty(property);

    const jsonStringProperty = newClass.properties.find(
      (item) => item.name === 'JsonString'
    );
    jsonStringProperty!.attributes = [];

    this.addClass(newClass);
  }

  private async addJsonStringOperation(
    operation: CommandOperation,
    index: string
  ) {
    operation.details.csharp.name = `${operation.variant}ViaJsonString`;
    operation.details.csharp.hidden = false;
    operation.parameters = operation.parameters.filter(
      (item) => item.details.default.isBodyParameter !== true
    );
    operation.callGraph[0].language.csharp!.name = `${
      (<any>operation.callGraph[0]).language.csharp!.name
    }ViaJsonString`;
    const name = 'JsonString';
    const serializedName = 'jsonString';
    const description = `Json string supplied to the ${operation.variant} operation`;
    const language = {
      default: {
        name: name,
        description: description,
        serializedName: serializedName,
      },
      csharp: {
        name: name,
        description: description,
        serializedName: serializedName,
        byReference: false,
      },
    };
    const schema = new SchemaModel(name, description, SchemaType.String);
    schema.language = language;
    const httpParameter = {
      implementation: 'Method',
      language: language,
      schema: schema,
      required: true,
    };
    const parameter = new IParameter(name, schema, {
      description: description,
      required: false,
      details: {
        default: {
          description: description,
          name: name,
          isBodyParameter: false,
        },
        csharp: {
          description: description,
          name: name,
          isBodyParameter: false,
          httpParameter: httpParameter,
        },
      },
      schema: schema,
      allowEmptyValue: false,
      deprecated: false,
    });
    (<any>parameter).httpParameter = httpParameter;
    const classParameter = new Parameter(name, description, schema, {
      language: language,
      protocol: {
        http: {
          in: 'runtime',
        },
      },
    });
    operation.callGraph[0].parameters!.push(classParameter);
    operation.parameters.push(parameter);
    operation.details.csharp.virtualParameters!.operation =
      operation.details.csharp.virtualParameters!.operation.filter(
        (p) => (<any>p.origin).details.csharp.isBodyParameter !== true
      );
    const vparam: CommandVirtualParameter = {
      name: name,
      description: description,
      required: true,
      nameOptions: [],
      schema: schema,
      alias: [],
      origin: parameter,
    };
    operation.details.csharp.virtualParameters?.operation.push(vparam);
    const newClass = await new CmdletClass(
      this,
      operation,
      this.state.path('commands', 'operations', index)
    ).init();
    this.addClass(newClass);
  }
}

export function hasValidBodyParameters(operation: CommandOperation): boolean {
  if (
    operation.callGraph[0].requests &&
    operation.callGraph[0].requests.length > 0 &&
    operation.callGraph[0].requests[0].parameters &&
    operation.callGraph[0].requests[0].parameters.length > 0
  ) {
    const param = operation.callGraph[0].requests[0].parameters.find(
      (p) => !p.origin || p.origin.indexOf('modelerfour:synthesized') < 0
    );
    return !!param;
  }
  return false;
}
