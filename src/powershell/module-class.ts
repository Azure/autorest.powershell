import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { LiteralExpression } from '#csharp/code-dom/expression';
import { Import, Alias } from '#csharp/code-dom/import';
import { Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { BackedProperty, ImplementedProperty, LambdaProperty, LazyProperty, Property } from '#csharp/code-dom/property';
import { If } from '#csharp/code-dom/statements/if'
import { Return } from '#csharp/code-dom/statements/return';
import { Statements } from '#csharp/code-dom/statements/statement';
import { Using } from '#csharp/code-dom/statements/using';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { State } from '#powershell/state';
import { Parameter } from '#csharp/code-dom/parameter';

export class ModuleClass extends Class {

  constructor(namespace: Namespace, private state: State, objectInitializer?: Partial<ModuleClass>) {
    super(namespace, 'Module');
    this.apply(objectInitializer);

    // static instance property
    this.add(new LazyProperty('Instance', this, new LiteralExpression(`new ${this.declaration}()`), {
      instanceAccess: this.declaration,
      static: Modifier.Static,
    }));

    // get the name of the client API class
    const clientAPI = new dotnet.LibraryType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);

    const clientProperty = this.add(new Property('ClientAPI', clientAPI));

    const pipelineAction = new dotnet.LibraryType(dotnet.System, `Action<PipelineChangeDelegate,PipelineChangeDelegate>`);

    const OnModuleLoad = this.add(new Property('OnModuleLoad', pipelineAction));
    const OnNewRequest = this.add(new Property('OnNewRequest', pipelineAction));

    // create the pipeline property
    // todo: setup non-azure version of pipeline.
    const pipelineProperty: Property = this.add(new BackedProperty('Pipeline', ClientRuntime.HttpPipeline, {
      getterStatements: new Statements(function* () {
        yield `var result = this._pipeline.Clone();`; //ouch
        yield If(`${OnNewRequest.value} != null`, function* () {
          yield `    ${OnNewRequest.value}( (step)=> { result.Prepend(step); } , (step)=> { result.Append(step); } );`;
        });
        yield Return(new LiteralExpression(`result`));
      })
    })
    );

    this.add(new Constructor(this, {
      access: Access.Private,
    })).add(function* () {
      yield `/// constructor`;
      yield clientProperty.assignPrivate(clientAPI.newInstance());
      yield pipelineProperty.assignPrivate(ClientRuntime.HttpPipeline.newInstance());
    });

    const eventListener = dotnet.System.Func(dotnet.String, dotnet.System.Threading.CancellationToken, dotnet.System.Func(dotnet.System.EventArgs), dotnet.System.Threading.Tasks.Task());
    const nextStep = dotnet.System.Func(dotnet.System.Net.Http.HttpRequestMessage, eventListener, dotnet.System.Threading.Tasks.Task(dotnet.System.Net.Http.HttpResponseMessage));

    const eventListenerDelegate = namespace.add(new Alias('EventListenerDelegate', dotnet.System.Func(dotnet.String, dotnet.System.Threading.CancellationToken, dotnet.System.Func(dotnet.System.EventArgs), dotnet.System.Threading.Tasks.Task())));
    const getParameterDelegate = namespace.add(new Alias('GetParameterDelegate', dotnet.System.Func(dotnet.String, dotnet.System.Collections.Generic.Dictionary(dotnet.String, dotnet.Object), dotnet.String, dotnet.Object)));
    const sendAsyncStep = namespace.add(new Alias('SendAsyncStep', dotnet.System.Func(dotnet.System.Net.Http.HttpRequestMessage, eventListener, nextStep, dotnet.System.Threading.Tasks.Task(dotnet.System.Net.Http.HttpResponseMessage))));
    const pipelineChangeDelegate = namespace.add(new Alias('PipelineChangeDelegate', dotnet.System.Action(sendAsyncStep.fullDefinition)));

    const GetParameterValue = this.add(new Property('GetParameterValue', getParameterDelegate));
    const EventListener = this.add(new Property('EventListener', eventListenerDelegate));

    this.add(new Method('Init', dotnet.Void)).add(function* () {
      yield If(`${OnModuleLoad.value} != null`, function* () {
        yield `${OnModuleLoad.value}( (step)=> { ${pipelineProperty.valuePrivate}.Prepend(step); } , (step)=> { ${pipelineProperty.valuePrivate}.Append(step); } );`;
      });
    });


    const pId = new Parameter('id', dotnet.String);
    const pToken = new Parameter('token', dotnet.System.Threading.CancellationToken);
    const pGetEvent = new Parameter('getEventData', dotnet.System.Func(dotnet.System.EventArgs));
    this.add(new Method('Signal', dotnet.System.Threading.Tasks.Task(), { parameters: [pId, pToken, pGetEvent], async: Modifier.Async })).add(function* () {
      yield If(`${EventListener.value} != null`, `await ${EventListener.value}(${pId.value},${pToken.value},${pGetEvent.value});`);
    });
  }
}
