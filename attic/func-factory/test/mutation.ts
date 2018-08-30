import * as assert from 'assert';
import { only, skip, slow, suite, test, timeout } from 'mocha-typescript';
import { Graph, NodePhi, NodeProc } from '../src/graph';
import { FlexArgs, FlexCallbacks, GraphContext } from '../src/graph-context';
import { objMap } from '../src/helpers';
import { getBuiltInDefs, getBuiltInImpls, MyTType, runGraph, typeAssignableTo, typeNumber, typeString } from './common';

@suite class Mutation {
  @test 'build graph'() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        text: { type: typeString, names: ['text'] }
      },
      outputFlows: {
        result: { length: typeNumber },
        error: {}
      }
    };

    const len: NodeProc<MyTType> = { procID: 'strlen' };

    const ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs())
      .connectControlFlow({ type: 'proc', node: len, flow: 'result' }, { type: 'output', flow: 'result' })
      .connectControlFlow({ type: 'entry' }, { type: 'proc', node: len })
      .connectDataFlow({ origin: { type: 'proc', node: len, flow: 'result' }, id: 'length' }, { target: { type: 'output', flow: 'result' }, id: 'length' })
      .connectDataFlow({ origin: { type: 'entry' }, id: 'text' }, { target: { type: 'proc', node: len }, id: 's' });

    assert.equal(runGraph(ga.graph, { text: 'asd' }, 'result', '.length'), 3);
    assert.equal(runGraph(ga.graph, { text: 'hello world' }, 'result', '.length'), 11);
    assert.equal(runGraph(ga.graph, { text: '' }, 'result', '.length'), 0);
  }
}
