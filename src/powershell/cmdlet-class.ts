import { CommandOperation } from '#common/code-model/command-operation';
import { MediaType } from '#common/code-model/http-operation';
import { getAllProperties } from '#common/code-model/schema';
import { Dictionary, items, values } from '#common/dictionary';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Attribute } from '#csharp/code-dom/attribute';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { IsDeclaration, LambdaExpression, LiteralExpression, StringExpression } from '#csharp/code-dom/expression';
import { Field, InitializedField } from '#csharp/code-dom/field';
import { LambdaMethod, Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Var } from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { BackedProperty, LambdaProperty, Property } from '#csharp/code-dom/property';
import { Catch } from '#csharp/code-dom/statements/catch';
import { Else, If } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { Statements } from '#csharp/code-dom/statements/statement';
import { Try } from '#csharp/code-dom/statements/try';
import { Using } from '#csharp/code-dom/statements/using';
import { Ternery } from '#csharp/code-dom/ternery';
import { LocalVariable, Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { CmdletParameter } from './cmdlet-parameter';
import { AsyncCommandRuntime, CmdletAttribute, ErrorCategory, ErrorRecord, OutputTypeAttribute, ParameterAttribute, ValidateNotNull, verbEnum, Events } from './powershell-declarations';
import { State } from './state';
import { EventListener } from '#csharp/lowlevel-generator/operation/method';
import { ForEachStatement } from '#csharp/code-dom/statements/for';

const PSCmdlet = new Class(new Namespace('System.Management.Automation'), 'PSCmdlet');

export class CmdletClass extends Class {
  private cancellationToken!: Property;
  private state: State;
  private eventListener: EventListener;

  constructor(namespace: Namespace, operation: CommandOperation, state: State, objectInitializer?: Partial<CmdletClass>) {
    const variantName = `${operation.noun}_${operation.details.powershell.name}`;
    const name = `${operation.verb}${variantName}`;
    super(namespace, name, PSCmdlet);
    this.apply(objectInitializer);
    this.interfaces.push(ClientRuntime.IEventListener);
    this.state = state;
    this.eventListener = new EventListener(new LiteralExpression('this'));
    // basic stuff
    this.addCommonStuff();

    this.add(new Method('BeginProcessing', dotnet.Void, {
      override: Modifier.Override,
      access: Access.Protected,
    }))

    // construct the class
    this.addClassAttributes(operation, variantName);
    this.addPowershellParameters(operation);

    // implement IEventListener
    this.implementIEventListener();

    // add constructors
    this.implementConstructors(operation);

    // json serialization
    this.implementSerialization(operation);

    // processRecord
    this.implementProcessRecord(operation);

    this.implementProcessRecordAsync(operation);
  }

  private addCommonStuff() {

    // pipeline property
    this.add(new LambdaProperty('Pipeline', ClientRuntime.HttpPipeline, new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Pipeline`)));

    // client API property (todo: fill this in correctly)
    const clientAPI = new dotnet.LibraryType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);
    this.add(new LambdaProperty('Client', clientAPI, new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.ClientAPI`)));

    // Cmdlet Parameters for pipeline manipulations.
    const prepend = this.add(new Property('HttpPipelinePrepend', ClientRuntime.SendAsyncStep, { attributes: [] }));
    prepend.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline"`] }));
    prepend.add(new Attribute(ValidateNotNull));

    const append = this.add(new Property('HttpPipelineAppend', ClientRuntime.SendAsyncStep, { attributes: [] }));
    append.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline"`] }));
    append.add(new Attribute(ValidateNotNull));
  }

  private implementProcessRecord(operation: CommandOperation) {
    const $this = this;

    this.add(new Method('ProcessRecord', undefined, { access: Access.Protected, override: Modifier.Override })).add(function* () {
      yield $this.eventListener.syncSignal(Events.CmdletProcessRecordStart);
      yield Try(function* () {
        yield `// work`;

        const normal = new Statements(function* () {
          const acr = new LocalVariable('asyncCommandRuntime', dotnet.Var, { initializer: AsyncCommandRuntime.newInstance(dotnet.This, $this.cancellationToken) });
          yield Using(acr.declarationExpression, function* () {
            yield `${acr}.Wait( ProcessRecordAsync(),${$this.cancellationToken});`;
          });
        });

        if (operation.asjob) {
          yield If(`true == MyInvocation?.BoundParameters?.ContainsKey("AsJob")`, function* () {
            yield `JobRepository.Add( new AsyncJob( this.Clone()) );`;
          });
          yield Else(normal);
        } else {
          yield normal;
        }

      });
      const exception = new Parameter('exception', dotnet.System.Exception);
      yield Catch(exception, function* () {
        yield $this.eventListener.syncSignal(Events.CmdletException);
        yield `// Write exception out to error channel.`;
        yield `WriteError( new ${ErrorRecord}(${exception.use},string.Empty, ${ErrorCategory('CloseError')}, null) );`;
      });
    });

  }

  private implementProcessRecordAsync(operation: CommandOperation) {
    const $this = this;
    this.add(new Method('ProcessRecordAsync', dotnet.System.Threading.Tasks.Task(), { access: Access.Protected, async: Modifier.Async })).add(function* () {
      // construct the call to the operation

      yield $this.eventListener.signal(Events.CmdletGetPipeline);
      const pipeline = new LocalVariable('pipeline', dotnet.Var, { initializer: $this.$<Property>('Pipeline').invokeMethod('Clone') });
      yield pipeline.declarationStatement;

      yield pipeline.invokeMethod('Prepend', $this.$<Property>('HttpPipelinePrepend'));
      yield pipeline.invokeMethod('Append', $this.$<Property>('HttpPipelineAppend'));

      yield `// get the client instance`;
      const apiCall = operation.callGraph[0];

      // find each parameter to the method, and find out where the value is going to come from.
      const operationParameters: Array<Variable> = values(apiCall.parameters).linq.select(p => {
        return values($this.properties).linq.where(each => each.metadata.parameterDefinition).linq.first(each => each.metadata.parameterDefinition === p);
      }).linq.selectNonNullable(each => each).linq.toArray();

      // is there a body parameter we should include?
      const requestBody = apiCall.requestBody;
      if (requestBody && requestBody.content['application/json'].schema) {
        // we have a body parameter.
        const bodyParameter = values($this.properties).linq.where(each => each.metadata.parameterDefinition).linq.first(each => each.metadata.parameterDefinition.schema === requestBody.content['application/json'].schema);
        if (bodyParameter) {
          operationParameters.push(bodyParameter);
        }
      }

      // how many inputs is the api expecting
      const inputParameters = operationParameters.length;

      // create the response handlers
      const responses = [...values(apiCall.responses_new).linq.selectMany(each => each)];

      const callbacks = responses.map(each => new LambdaExpression([new Parameter('response', Var)], function* () {
        if (each.details.csharp.isErrorResponse) {
          // this should write an error to the error channel.
          yield `// Error Response : ${each.responseCode} `;
          if (each.schema) {
            // the schema should be the error information.
            const props = getAllProperties(each.schema);
            const codeProp = values(props).linq.first(p => p.details.csharp.name === 'Code');
            const messageProp = values(props).linq.first(p => p.details.csharp.name === 'Message');
            if (codeProp && messageProp) {
              yield `var code = (await response.Result).${codeProp.details.csharp.name};`;
              yield `var message = (await response.Result).${messageProp.details.csharp.name};`;
              yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"[{code}] : {message}"), code, System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.join(',')}}));`;
              return;
            } else {
              // what do we do with the response object?
              yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"The service encountered an unexpected result: {response.responseMessage.StatusCode}"), response.responseMessage.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.join(',')}}));`;
              return;
            }
          } else {
            // all we know is that this was an error, and we can't proceed.
            yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"The service encountered an unexpected result: {response.responseMessage.StatusCode}"), response.responseMessage.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.join(',')}}));`;
            return;
          }
        }

        yield `// ${each.details.csharp.name} - response for ${each.responseCode} / ${each.mimeTypes.join('/')}`;
        if (each.schema) {
          // we expect to get back some data from this call.
          const schema = each.schema;
          yield `// (await response.Result) // should be ${CmdletClass.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, $this.state).declaration}`;

          const props = getAllProperties(schema);
          if (props.length === 1) {
            // let's unroll this and write out the single property
            yield `WriteObject((await response.Result).${props[0].details.csharp.name});`;
            return;
          }

          // more than one property, let's just return the result object
          yield `WriteObject(await response.Result);`;
          return;
        }

        // no return type. Let's just return ... true?
        yield `WriteObject(true);`;
      }, { async: Modifier.Async }));

      // string all the api call parameters together.
      // const p = (bodyParameter) ? [...operationParameters, bodyParameter, ...callbacks, dotnet.This, pipeline] : [...operationParameters, ...callbacks, dotnet.This, pipeline];

      // make the call.
      yield $this.eventListener.signal(Events.CmdletBeforeAPICall);
      yield `await this.${$this.$<Property>('Client').invokeMethod(apiCall.details.csharp.name, ...[...operationParameters, ...callbacks, dotnet.This, pipeline]).implementation}`;
      yield $this.eventListener.signal(Events.CmdletAfterAPICall);
    });
  }

  private static schemaDefinitionResolver = new SchemaDefinitionResolver();

  private implementSerialization(operation: CommandOperation) {
    const $this = this;
    // set up the declaration for the toJson method.
    const container = new Parameter('container', ClientRuntime.JsonObject);
    const mode = new Parameter('serializationMode', ClientRuntime.JsonMode);

    const toJsonMethod = this.add(new Method('ToJson', ClientRuntime.JsonNode, {
      parameters: [container, mode],
    }));
    toJsonMethod.add(function* () {
      yield `// serialization method`;
      yield `var result = ${container.use} ?? new ${ClientRuntime.JsonObject.declaration}();`;

      for (const parameter of values(operation.parameters)) {
        const td = CmdletClass.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, parameter.required, $this.state);
        if (!(parameter.details.default.constantValue)) {
          yield td.jsonSerializationImplementation(container.use, parameter.details.powershell.name, parameter.details.powershell.name);
        }
      }

      // yield `bool returnNow = false;`;
      // yield `${$this.btj.name}(ref result, ref returnNow);`;

      //      yield If({ value: `returnNow` }, `return result;`);

      // yield `${$this.atj.name}(ref result);`;
      yield `return result;`;
    });

    // create the FromJson method
    const node = new Parameter('node', ClientRuntime.JsonNode);
    const fromJson = this.addMethod(new Method('FromJson', this, { parameters: [node], static: Modifier.Static }));
    fromJson.add(function* () {
      const json = IsDeclaration(node, ClientRuntime.JsonObject, 'json');
      yield Return(Ternery(json.check, $this.newInstance(json), dotnet.Null));
    });

    // from/to json-string
    const strJson = new Parameter('jsonText', dotnet.String);
    this.add(new LambdaMethod('FromJsonString', this, new LiteralExpression(`string.IsNullOrEmpty(${strJson.value}) ? null : ${fromJson.invoke(new LiteralExpression(`Carbon.Json.JsonObject.Parse(${strJson.value})`)).value}`), { parameters: [strJson], static: Modifier.Static }));

    // clone
    const clone = this.add(new Method('Clone', this));
    clone.add(function* () {
      const i = new LocalVariable('clone', Var, {
        initializer: fromJson.invoke(new LiteralExpression(`this.${toJsonMethod.invoke(dotnet.Null, ClientRuntime.JsonMode.IncludeAll).value}`))
      });
      yield i.declarationStatement;
      yield `${i.value}.HttpPipelinePrepend = this.HttpPipelinePrepend;`;
      yield `${i.value}.HttpPipelineAppend = this.HttpPipelineAppend;`;
      // yield `i.Pipeline = this.Pipeline`; //todo: pass thru these
      // yield `i.Client = this.Client`;

      yield Return(i);
    });
  }

  private implementConstructors(operation: CommandOperation) {
    const $this = this;
    // default constructor
    this.add(new Constructor(this));

    // deserialization constructor
    const deserializerConstructor = this.add(new Constructor(this, { parameters: [new Parameter('json', ClientRuntime.JsonObject)], access: Access.Internal }));
    deserializerConstructor.add(function* () {
      yield `// deserialize the contents`;
      for (const parameter of values(operation.parameters)) {
        const td = CmdletClass.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, parameter.required, $this.state);
        const bp = <BackedProperty>$this.$<Property>(parameter.details.powershell.name);
        if (!(parameter.details.default.constantValue)) {
          // dont' serialize if it's a constant or host parameter. 
          yield td.jsonDeserializationImplementationOnProperty('json', bp.backingName, parameter.details.powershell.name);
        }

      }
    });
  }

  private implementIEventListener() {
    const $this = this;
    const _cts = this.add(new InitializedField('_cancellationTokenSource', dotnet.System.Threading.CancellationTokenSource, new LiteralExpression(`new ${dotnet.System.Threading.CancellationTokenSource.declaration}()`), { access: Access.Private }));
    this.cancellationToken = this.add(new LambdaProperty('Token', dotnet.System.Threading.CancellationToken, new LiteralExpression(`${_cts.value}.Token`)));
    this.add(new LambdaProperty('Cancel', dotnet.System.Action(), new LiteralExpression(`${_cts.value}.Cancel`)));

    const id = new Parameter('id', dotnet.String);
    const token = new Parameter('token', dotnet.System.Threading.CancellationToken);
    const messageData = new Parameter('messageData', dotnet.System.Func(ClientRuntime.EventData));
    this.add(new Method('Signal', dotnet.System.Threading.Tasks.Task(), { async: Modifier.Async, parameters: [id, token, messageData] })).add(function* () {
      yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value});`;
      yield If(`${token.value}.IsCancellationRequested`, `return;`);

      // any handling of the signal on our side...
    });
  }

  private addPowershellParameters(operation: CommandOperation) {
    for (const parameter of values(operation.parameters)) {
      // these are the parameters that this command expects
      // create a single

      const td = CmdletClass.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, parameter.required, this.state);

      if (parameter.details.default.constantValue) {
        // this parameter has a constant value
        // don't give it a parameter attribute
        const cmdletParameter = this.add(new LambdaProperty(parameter.details.powershell.name, td, new StringExpression(parameter.details.default.constantValue), {
          metadata: {
            parameterDefinition: parameter
          },
        }));
      } else if (parameter.details.default.fromHost) {
        // the parameter is expected to be gotten from the host.
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter.details.default.originalParam
          },
        }));
        this.$<Method>("BeginProcessing").add(cmdletParameter.assignPrivate(new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.GetParameterValue("this-module-name", this.MyInvocation.BoundParameters, "${parameter.name}") as string`)));
        // in the BeginProcessing, we should tell it to go get the value for this property from the common module

      } else {
        // regular cmdlet parameter
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter
          }
        }));
        cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression('Mandatory = true'), new LiteralExpression(`HelpMessage = "${parameter.details.powershell.description || 'HELP MESSAGE MISSING'}"`)] }));
      }

    }
  }

  private addClassAttributes(operation: CommandOperation, variantName: string) {

    this.add(new Attribute(CmdletAttribute, { parameters: [verbEnum(operation.category, operation.verb), new StringExpression(variantName)] }));

    const rt = new Dictionary<boolean>();
    for (const op of values(operation.callGraph)) {

      /* testing
      for (const schema of
        values(operation.callGraph).linq
          .selectMany(httpOperation => items(httpOperation.responses)).linq
          .where(each => each.key !== 'default').linq
          .select(each => each.value).linq
          .selectMany(response => values(response.content)).linq
          .distinct(mediaType => mediaType.schema).linq
          .selectNonNullable(mediaType => mediaType.schema)) {
        console.error(`it is ${schema.details.csharp.name}`);
      }
      */

      for (const item of items(op.responses).linq.where(each => each.key !== 'default')) {

        for (const schema of values(item.value.content).linq.selectNonNullable(each => each.schema)) {
          const props = getAllProperties(schema);

          // does the target type just wrap a single output?
          const td = props.length !== 1 ?
            CmdletClass.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, this.state) :
            CmdletClass.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>props[0].schema, true, this.state);

          if (td) {
            if (!rt[td.declaration]) {
              rt[td.declaration] = true;
              this.add(new Attribute(OutputTypeAttribute, { parameters: [{ value: `typeof(${td.declaration})` }] }));
            }
          }
        }
      }
    }
  }
}
