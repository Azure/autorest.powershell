import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { LiteralExpression } from '#csharp/code-dom/expression';
import { Import, Alias } from '#csharp/code-dom/import';
import { Method } from '#csharp/code-dom/method';
import * as mscorlib from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { BackedProperty, ImplementedProperty, LambdaProperty, LazyProperty, Property } from '#csharp/code-dom/property';
import { If } from '#csharp/code-dom/statements/if'
import { Return } from '#csharp/code-dom/statements/return';
import { Statements } from '#csharp/code-dom/statements/statement';
import { Using } from '#csharp/code-dom/statements/using';
import { HttpPipeline } from '#csharp/lowlevel-generator/clientruntime';
import { State } from '#powershell/state';

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
    const clientAPI = new mscorlib.LibraryType(`${this.state.model.details.csharp.namespace}.${this.state.model.details.csharp.name}`);
    const clientProperty = this.add(new Property('ClientAPI', clientAPI));

    const pipelineAction = new mscorlib.LibraryType(`System.Action<PipelineChangeDelegate,PipelineChangeDelegate>`);

    const OnModuleLoad = this.add(new Property('OnModuleLoad', pipelineAction));
    const OnNewRequest = this.add(new Property('OnNewRequest', pipelineAction));

    // create the pipeline property
    // todo: setup non-poweshell version of pipeline.
    const pipelineProperty: Property = this.add(new BackedProperty('Pipeline', HttpPipeline, {
      getterStatements: new Statements(function* () {
        yield `var result = this._pipeline.Clone();`;
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
      yield pipelineProperty.assignPrivate(HttpPipeline.newInstance());
    });

    const eventListener = mscorlib.Func(mscorlib.String, mscorlib.CancellationToken, mscorlib.Func(mscorlib.EventArgs), mscorlib.Task());
    const nextStep = mscorlib.Func(mscorlib.HttpRequestMessage, eventListener, mscorlib.Task(mscorlib.HttpResponseMessage));

    const eventListenerDelegate = namespace.add(new Alias('EventListenerDelegate', mscorlib.Func(mscorlib.String, mscorlib.CancellationToken, mscorlib.Func(mscorlib.EventArgs), mscorlib.Task())));
    const getParameterDelegate = namespace.add(new Alias('GetParameterDelegate', mscorlib.Func(mscorlib.String, mscorlib.Dictionary(mscorlib.String, mscorlib.Object), mscorlib.String, mscorlib.Object)));
    const sendAsyncStep = namespace.add(new Alias('SendAsyncStep', mscorlib.Func(mscorlib.HttpRequestMessage, eventListener, nextStep, mscorlib.Task(mscorlib.HttpResponseMessage))));
    const pipelineChangeDelegate = namespace.add(new Alias('PipelineChangeDelegate', mscorlib.Action(sendAsyncStep.fullDefinition)));

    const GetParameterValue = this.add(new Property('GetParameterValue', getParameterDelegate));
    const EventListener = this.add(new Property('EventListener', eventListenerDelegate));

    this.add(new Method('Init', mscorlib.Void)).add(function* () {
      yield If(`${OnModuleLoad.value} != null`, function* () {
        yield `${OnModuleLoad.value}( (step)=> { ${pipelineProperty.value}.Prepend(step); } , (step)=> { ${pipelineProperty.value}.Append(step); } );`;
      });
    });

  }
}
