import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { LiteralExpression, StringExpression } from '#csharp/code-dom/expression';
import { Field } from '#csharp/code-dom/field';
import { Alias, Import } from '#csharp/code-dom/import';
import { LambdaMethod, Method } from '#csharp/code-dom/method';

import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { BackedProperty, ImplementedProperty, LambdaProperty, LazyProperty, Property } from '#csharp/code-dom/property';
import { If } from '#csharp/code-dom/statements/if'
import { Return } from '#csharp/code-dom/statements/return';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { State } from '#powershell/state';
import { System, dotnet, ClassType } from '#csharp/code-dom/dotnet';

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
    const TaskOfHttpResponseMessage = System.Threading.Tasks.Task(System.Net.Http.HttpResponseMessage);
    const BoundParameterDictionary = System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object);

    const clientAPI = new ClassType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);

    const clientProperty = this.add(new Property('ClientAPI', clientAPI));

    // lets the common code call the signal again (recursive! careful!)
    const signalDelegateI = System.Func(
      dotnet.String,
      System.Threading.CancellationToken,
      System.Func(System.EventArgs),
      /* returns */ System.Threading.Tasks.Task());

    const signalDelegate = System.Func(
      dotnet.String,
      System.Threading.CancellationToken,
      System.Func(System.EventArgs),
      signalDelegateI,
      /* returns */ System.Threading.Tasks.Task());

    const IEventListenerExpanded = [
      System.Threading.CancellationToken, /* token */
      System.Action(),                    /* Cancel() */
      signalDelegateI,
    ];

    const nextStep = System.Func(
      System.Net.Http.HttpRequestMessage,
      ...IEventListenerExpanded,
      /* returns */ TaskOfHttpResponseMessage);

    const signalDelegateIAlias = namespace.add(new Alias('SignalDelegateI', signalDelegateI));
    const signalDelegateAlias = namespace.add(new Alias('SignalDelegate', signalDelegate));

    const getParameterDelegate = namespace.add(new Alias('GetParameterDelegate', System.Func(
      dotnet.String,
      dotnet.String,
      BoundParameterDictionary,
      dotnet.String,
      /* returns */ dotnet.Object)));

    const sendAsyncStep = namespace.add(new Alias('SendAsyncStepDelegate',
      System.Func(
        System.Net.Http.HttpRequestMessage,
        ...IEventListenerExpanded,
        nextStep,                                  /* Next( ...) */
        /* returns */ TaskOfHttpResponseMessage)));


    const boundParams = new Parameter('boundParameters', System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object));
    const pipelineField = this.add(new Field('_pipeline', ClientRuntime.HttpPipeline, { access: Access.Private }));

    const createPipeline = this.add(new Method('CreatePipeline', ClientRuntime.HttpPipeline, {
      parameters: [boundParams]
    }));

    const init = this.add(new Method('Init', dotnet.Void));

    if (isAzure) {
      const pipelineChangeDelegate = namespace.add(new Alias('PipelineChangeDelegate', System.Action(sendAsyncStep.fullDefinition)));
      const nextDelegate = namespace.add(new Alias('NextDelegate', nextStep));

      const moduleLoadPipelineAction = namespace.add(new Alias('ModuleLoadPipelineDelegate', System.Action(dotnet.String, dotnet.String, pipelineChangeDelegate.fullDefinition, pipelineChangeDelegate.fullDefinition)));
      const newRequestPipelineAction = namespace.add(new Alias('NewRequestPipelineDelegate', System.Action(System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object), pipelineChangeDelegate.fullDefinition, pipelineChangeDelegate.fullDefinition)));

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
      const pToken = new Parameter('token', System.Threading.CancellationToken);
      const pGetEvent = new Parameter('getEventData', System.Func(System.EventArgs));
      const pSignal = new Parameter('signal', signalDelegateIAlias);
      this.add(new Method('Signal', System.Threading.Tasks.Task(), { parameters: [pId, pToken, pGetEvent, pSignal], async: Modifier.Async })).add(function* () {
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
      yield clientProperty.assignPrivate(clientAPI.new());
      yield pipelineField.assignPrivate(ClientRuntime.HttpPipeline.new());
    });
  }
}

