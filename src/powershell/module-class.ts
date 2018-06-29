import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { LiteralExpression, StringExpression } from '#csharp/code-dom/expression';
import { Field } from '#csharp/code-dom/field';
import { Alias, Import } from '#csharp/code-dom/import';
import { LambdaMethod, Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { BackedProperty, ImplementedProperty, LambdaProperty, LazyProperty, Property } from '#csharp/code-dom/property';
import { If } from '#csharp/code-dom/statements/if'
import { Return } from '#csharp/code-dom/statements/return';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { State } from '#powershell/state';

export class ModuleClass extends Class {

  constructor(namespace: Namespace, private state: State, objectInitializer?: Partial<ModuleClass>) {
    super(namespace, 'Module');
    this.apply(objectInitializer);
    this.partial = true;

    // static instance property
    this.add(new LazyProperty('Instance', this, new LiteralExpression(`new ${this.declaration}()`), {
      instanceAccess: this.declaration,
      static: Modifier.Static,
    }));

    const isAzure = this.state.project.azure;

    // get the name of the client API class
    const TaskOfHttpResponseMessage = dotnet.System.Threading.Tasks.Task(dotnet.System.Net.Http.HttpResponseMessage);
    const BoundParameterDictionary = dotnet.System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object);

    const clientAPI = new dotnet.LibraryType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);

    const clientProperty = this.add(new Property('ClientAPI', clientAPI));

    // lets the common code call the signal again (recursive! careful!)
    const signalDelegateI = dotnet.System.Func(
      dotnet.String,
      dotnet.System.Threading.CancellationToken,
      dotnet.System.Func(dotnet.System.EventArgs),
      /* returns */ dotnet.System.Threading.Tasks.Task());

    const signalDelegate = dotnet.System.Func(
      dotnet.String,
      dotnet.System.Threading.CancellationToken,
      dotnet.System.Func(dotnet.System.EventArgs),
      signalDelegateI,
      /* returns */ dotnet.System.Threading.Tasks.Task());

    const IEventListenerExpanded = [
      dotnet.System.Threading.CancellationToken, /* token */
      dotnet.System.Action(),                    /* Cancel() */
      signalDelegateI,
    ];

    const nextStep = dotnet.System.Func(
      dotnet.System.Net.Http.HttpRequestMessage,
      ...IEventListenerExpanded,
      /* returns */ TaskOfHttpResponseMessage);

    const signalDelegateIAlias = namespace.add(new Alias('SignalDelegateI', signalDelegateI));
    const signalDelegateAlias = namespace.add(new Alias('SignalDelegate', signalDelegate));

    const getParameterDelegate = namespace.add(new Alias('GetParameterDelegate', dotnet.System.Func(
      dotnet.String,
      dotnet.String,
      BoundParameterDictionary,
      dotnet.String,
      /* returns */ dotnet.Object)));

    const sendAsyncStep = namespace.add(new Alias('SendAsyncStepDelegate',
      dotnet.System.Func(
        dotnet.System.Net.Http.HttpRequestMessage,
        ...IEventListenerExpanded,
        nextStep,                                  /* Next( ...) */
        /* returns */ TaskOfHttpResponseMessage)));


    const boundParams = new Parameter('boundParameters', dotnet.System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object));
    const pipelineField = this.add(new Field('_pipeline', ClientRuntime.HttpPipeline, { access: Access.Private }));

    const createPipeline = this.add(new Method('CreatePipeline', ClientRuntime.HttpPipeline, {
      parameters: [boundParams]
    }));

    const init = this.add(new Method('Init', dotnet.Void));

    if (isAzure) {
      const pipelineChangeDelegate = namespace.add(new Alias('PipelineChangeDelegate', dotnet.System.Action(sendAsyncStep.fullDefinition)));
      const nextDelegate = namespace.add(new Alias('NextDelegate', nextStep));

      const moduleLoadPipelineAction = namespace.add(new Alias('ModuleLoadPipelineDelegate', dotnet.System.Action(dotnet.String, dotnet.String, pipelineChangeDelegate.fullDefinition, pipelineChangeDelegate.fullDefinition)));
      const newRequestPipelineAction = namespace.add(new Alias('NewRequestPipelineDelegate', dotnet.System.Action(dotnet.System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object), pipelineChangeDelegate.fullDefinition, pipelineChangeDelegate.fullDefinition)));

      const OnModuleLoad = this.add(new Property('OnModuleLoad', moduleLoadPipelineAction));
      const OnNewRequest = this.add(new Property('OnNewRequest', newRequestPipelineAction));

      const moduleIdentity = this.add(new LambdaProperty('Name', dotnet.String, new StringExpression(state.project.moduleName)));
      const moduleResourceId = this.add(new LambdaProperty('ResourceId', dotnet.String, new StringExpression(state.project.moduleName)));

      init.add(function* () {
        yield `${OnModuleLoad.value}?.Invoke( ${moduleResourceId.value}, ${moduleIdentity.value} ,(step)=> { ${pipelineField.value}.Prepend(step); } , (step)=> { ${pipelineField.value}.Append(step); } );`;;
      });

      const GetParameterValue = this.add(new Property('GetParameterValue', getParameterDelegate));
      const pBoundParameters = new Parameter('boundParameters', BoundParameterDictionary);
      const pKey = new Parameter('parameterName', dotnet.String);
      const GetParameter = this.add(new LambdaMethod('GetParameter', dotnet.Object, new LiteralExpression(`${GetParameterValue.value}?.Invoke( ${moduleResourceId.value}, ${moduleIdentity.value}, ${pBoundParameters.value}, ${pKey.value} )`), { parameters: [pBoundParameters, pKey] }));

      const EventListener = this.add(new Property('EventListener', signalDelegateAlias));

      const pId = new Parameter('id', dotnet.String);
      const pToken = new Parameter('token', dotnet.System.Threading.CancellationToken);
      const pGetEvent = new Parameter('getEventData', dotnet.System.Func(dotnet.System.EventArgs));
      const pSignal = new Parameter('signal', signalDelegateIAlias);
      this.add(new Method('Signal', dotnet.System.Threading.Tasks.Task(), { parameters: [pId, pToken, pGetEvent, pSignal], async: Modifier.Async })).add(function* () {
        yield `await ${EventListener.value}?.Invoke(${pId.value},${pToken.value},${pGetEvent.value}, ${pSignal.value});`;
      });

      createPipeline.add(function* () {
        yield `var result = this._pipeline.Clone();`;
        if (isAzure) {
          yield `    ${OnNewRequest.value}?.Invoke( ${boundParams.use}, (step)=> { result.Prepend(step); } , (step)=> { result.Append(step); } );`;
        }
        yield Return(new LiteralExpression(`result`));
      });

    } else {
      // non-azure init method
      init.add(function* () {
        yield `// called at module init time...`;
      });

      // non-azure createPipeline method
      createPipeline.add(function* () {
        yield Return(new LiteralExpression(`this._pipeline.Clone()`));
      });
    }

    this.add(new Constructor(this, {
      access: Access.Private,
    })).add(function* () {
      yield `/// constructor`;
      yield clientProperty.assignPrivate(clientAPI.newInstance());
      yield pipelineField.assignPrivate(ClientRuntime.HttpPipeline.newInstance());
    });
  }
}

