import { JsonType } from '#common/code-model/schema';
import { values, items, length } from '#common/dictionary';
import { indent, camelCase, pascalCase, escapeString } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Attribute } from '#csharp/code-dom/attribute';
import { Class } from '#csharp/code-dom/class';
import { LiteralExpression, StringExpression, valueOf } from '#csharp/code-dom/expression';
import { Field, InitializedField } from '#csharp/code-dom/field';
import { Method } from '#csharp/code-dom/method';
import { Namespace } from '#csharp/code-dom/namespace';
import { BackedProperty, ImplementedProperty, Property } from '#csharp/code-dom/property';
import { Return } from "#csharp/code-dom/statements/return";
import { Statements, OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable, MemberVariable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { CmdletClass, PSCmdlet } from '#powershell/cmdlet-class';
import { CmdletAttribute, OutputTypeAttribute, ParameterAttribute, SwitchParameter, verbEnum } from '#powershell/powershell-declarations';
import { State } from './state';

export interface WithState extends Class {
  state: State;
}

export class ModelCmdlet extends Class {
  public state: State;
  // protected processRecord: Method;

  constructor(namespace: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelCmdlet>) {
    const name = `New${schema.details.csharp.name}Object`;

    super(namespace, name, PSCmdlet);
    this.state = state;

    this.apply(objectInitializer);
    addClassAttributes(this, schema, name);

    const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(schema, true, this.state);
    const prop = this.add(new InitializedField(`_${schema.details.csharp.name.uncapitalize()}`, td, `new ${schema.details.csharp.namespace}.${schema.details.csharp.name}()`, { access: Access.Private }));

    const processRecord = this.add(new Method('ProcessRecord', undefined, { access: Access.Protected, override: Modifier.Override })).add(`WriteObject(${prop});`);
    // this.processRecord.add(`WriteObject(new ${schema.details.csharp.namespace}.${schema.details.csharp.name} {`);

    // adds the parameters to the cmdlet and adds to the method to set the value from the parameter.
    addPowershellParameters(this, schema, prop);

    // this.processRecord.add(`});`);
  }

}

function addClassAttributes($class: WithState, schema: Schema, name: string) {
  const td = $class.state.project.schemaDefinitionResolver.resolveTypeDeclaration(schema, true, $class.state);
  $class.add(new Attribute(CmdletAttribute, { parameters: [`System.Management.Automation.VerbsCommon.New`, new StringExpression(`${schema.details.csharp.name || ''}Object`)] }));
  $class.add(new Attribute(OutputTypeAttribute, { parameters: [`typeof(${td.declaration})`] }));
}

export function addPowershellParameters($class: WithState, schema: Schema, prop: Variable, ensureMemberIsCreated: Statements | undefined = undefined, expandName = false) {

  // next:
  // -- inline parameters from member property models.
  // polymorphic models?

  if (schema.details.csharp.isPolymorphic) {
    console.error(`\n\nPOLYMORPHIC TYPE! ${schema.details.csharp.name}`);
  }

  for (const a of values(schema.allOf)) {
    addPowershellParameters($class, a, prop);
  }

  // add a parameter for each property
  for (const { key: name, value: property } of items(schema.properties)) {

    const td = $class.state.project.schemaDefinitionResolver.resolveTypeDeclaration(property.schema, true, $class.state);

    if (property.schema.type === JsonType.Object) {
      // properties property get inlining without hassle
      const member = new MemberVariable(prop, property.details.csharp.name);

      if (name === 'properties') {
        // inline these properties instead.
        const ensure = new Statements(ensureMemberIsCreated);
        ensure.add(`${valueOf(member)} = ${valueOf(member)} ?? new ${property.schema.details.csharp.fullname}();`);

        addPowershellParameters($class, property.schema, member, ensure);
        continue;
      }

      if (!property.schema.additionalProperties) {

        if (length(property.schema.properties) <= $class.state.project.maxInlinedParameters) {
          // inline these properties instead.
          const ensure = new Statements(ensureMemberIsCreated);
          ensure.add(`${valueOf(member)} = ${valueOf(member)} ?? new ${property.schema.details.csharp.fullname}();`);

          addPowershellParameters($class, property.schema, member, ensure, true);
          continue;
        }
      }
    }

    // other properties 
    if (property.schema.type === JsonType.Object) {
      // console.error(`\n\nLARGE OBJECT NOT INLINED ${property.details.csharp.name}`);
    }

    if (!property.schema.readOnly) {
      // add a cmdlet parameter

      let cmdletParameter: ImplementedProperty;

      const pname = expandName ? pascalCase([schema.details.csharp.name, property.details.csharp.name]) : property.details.csharp.name;

      if (property.schema.type === JsonType.Boolean) {
        // use a switch instead
        cmdletParameter = $class.add(new ImplementedProperty(pname, SwitchParameter, {
          /* getterStatements: new Statements(function* () {
             if (ensureMemberIsCreated) {
               yield ensureMemberIsCreated;
 
             }
             yield Return(`new System.Management.Automation.SwitchParameter(true == ${prop}.${property.details.csharp.name});`);
           }), */
          setterStatements: new Statements(function* () {
            if (ensureMemberIsCreated) {
              yield ensureMemberIsCreated;
            }
            yield `${prop}.${property.details.csharp.name} = value.ToBool();`;
          }),
        }));
        // statements.add(indent(`${property.details.csharp.name} = this.MyInvocation.BoundParameters.ContainsKey("${property.details.csharp.name}") ? this.${property.details.csharp.name}.ToBool() : default(${td.declaration}),`));
      } else {

        let propname = pname;
        let n = 1;
        while ($class.properties.find(p => p.name === propname)) {
          // property exists with that name
          // let's hack this a smidgen
          propname = `${pname}${n++}`;
        }

        cmdletParameter = $class.add(new ImplementedProperty(propname, td, {
          setterStatements: new Statements(function* () {
            if (ensureMemberIsCreated) {
              yield ensureMemberIsCreated;
            }
            yield `${prop}.${property.details.csharp.name} = value;`;
          }),
        }));
        // statements.add(indent(`${property.details.csharp.name} = this.MyInvocation.BoundParameters.ContainsKey("${property.details.csharp.name}") ? this.${property.details.csharp.name} : default(${td.declaration}),`));
      }

      const desc = (property.details.csharp.description || 'HELP MESSAGE MISSING').replace(/[\r?\n]/gm, '');
      cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression(`Mandatory = ${property.details.default.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "${escapeString(desc)}"`)] }));
    }
  }

  // if 
}
