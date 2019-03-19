/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { JsonType, VirtualProperty } from '@microsoft.azure/autorest.codemodel-v3';
import { escapeString, items, length, pascalCase, values } from '@microsoft.azure/codegen';

import { Binary, Schema } from '@microsoft.azure/autorest.csharp-v2';
import { Access, Attribute, Class, ImplementedProperty, InitializedField, LiteralExpression, MemberVariable, Method, Modifier, Namespace, Statements, StringExpression, System, valueOf, Variable, ExpressionOrLiteral, } from '@microsoft.azure/codegen-csharp';

import { ArgumentCompleterAttribute, CmdletAttribute, OutputTypeAttribute, ParameterAttribute, PSCmdlet, SwitchParameter, DescriptionAttribute, GeneratedAttribute } from './powershell-declarations';
import { State } from './state';

export interface WithState extends Class {
  state: State;
}

let nn = 0;

export class ModelCmdlet extends Class {
  public state: State;
  // protected processRecord: Method;

  constructor(namespace: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelCmdlet>) {
    const variantName = `${state.project.prefix}${state.project.getCmdletNoun(schema.details.csharp.name)}Object_${schema.details.csharp.apiname}`;
    const name = `New${variantName}`;
    super(namespace, name, PSCmdlet);
    this.state = state;
    this.description = `Cmdlet to create an in-memory instance of the <see cref="${schema.details.csharp.name}" /> object.`;
    this.apply(objectInitializer);
    addClassAttributes(this, schema, variantName);

    const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(schema, true, this.state);
    const prop = this.add(new InitializedField(`_${schema.details.csharp.name.uncapitalize()}`, td, `new ${schema.details.csharp.namespace}.${schema.details.csharp.name}()`, { access: Access.Private, description: `Backing field for <see cref="${schema.details.csharp.name}" />` }));

    const processRecord = this.add(new Method('ProcessRecord', undefined, { access: Access.Protected, override: Modifier.Override, description: `Performs execution of the command.` })).add(`WriteObject(${prop});`);

    const vps = schema.details.csharp.virtualProperties;
    if (vps) {
      // adds the parameters to the cmdlet and adds to the method to set the value from the parameter.
      for (const vProperty of [...vps.owned, ...vps.inherited, ...vps.inlined]) {
        if (!vProperty.property.schema.readOnly && !vProperty.private) {
          const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>vProperty.property.schema, vProperty.property.details.csharp.required, this.state);
          const cmdletParameter = new ImplementedProperty(vProperty.name, td, {
            getterStatements: new Statements(`return ${prop.value}.${vProperty.name};`),
            setterStatements: new Statements(`${prop.value}.${vProperty.name} = value;`)
          });
          const desc = (vProperty.property.details.csharp.description || 'HELP MESSAGE MISSING').replace(/[\r?\n]/gm, '');
          cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression(`Mandatory = ${vProperty.property.details.csharp.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "${escapeString(desc)}"`)] }));
          cmdletParameter.description = desc;

          if (td.schema.details.csharp.enum !== undefined) {
            cmdletParameter.add(new Attribute(ArgumentCompleterAttribute, { parameters: [`typeof(${td.declaration})`] }));
          }
          this.add(cmdletParameter);
        }
      }
    }
  }
}

function addClassAttributes($class: WithState, schema: Schema, variantName: string) {

  const td = $class.state.project.schemaDefinitionResolver.resolveTypeDeclaration(schema, true, $class.state);
  $class.add(new Attribute(CmdletAttribute, { parameters: [`System.Management.Automation.VerbsCommon.New`, new StringExpression(`${variantName}`)] }));
  $class.add(new Attribute(OutputTypeAttribute, { parameters: [`typeof(${td.declaration})`] }));
  $class.add(new Attribute(DescriptionAttribute, { parameters: [new StringExpression(`Cmdlet to create an in-memory instance of the ${schema.details.csharp.name} object.`)] }))
  $class.add(new Attribute(GeneratedAttribute));
}
