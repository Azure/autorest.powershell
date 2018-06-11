import { suite, test, slow, timeout, skip, only } from 'mocha-typescript';
import * as assert from 'assert';
import { Graph, NodePhi, NodeProc } from '../src/graph';
import { GraphContext, FlexFunc, FlexArgs, FlexCallbacks } from '../src/graph-context';
import { getBuiltInDefs, getBuiltInImpls, typeNumber, runGraph, MyTType } from './common';
import { generateTS, GenerationFlavor } from '../src/reference-generator';
import { DeepMutable, objMap, tsc } from '../src/helpers';

@suite class Generation {
  @test "addition"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    const graph: Graph<MyTType> = {
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: {
        a: { names: ["a"], type: typeNumber },
        b: { names: ["b"], type: typeNumber }
      },
      outputFlows: {
        result: { res: typeNumber }
      }
    };

    assert.equal(runGraph(graph, { a: 1, b: 2 }, "result", ".res"), 3);
    assert.equal(runGraph(graph, { a: 4, b: 2 }, "result", ".res"), 6);
    assert.equal(runGraph(graph, { a: 4, b: 8 }, "result", ".res"), 12);
  }

  @test "loop"() {
    const inputPhi: NodePhi<MyTType> = { merge: { "x": typeNumber }, flows: ["init", "loop"] };
    const ltA: NodeProc<MyTType> = { procID: "lt" };
    const ifA: NodeProc<MyTType> = { procID: "if" };
    const addA: NodeProc<MyTType> = { procID: "add" };

    const graph: Graph<MyTType> = {
      controlFlow: [
        { source: { type: "phi", node: inputPhi }, target: { type: "proc", node: ltA } },
        { source: { type: "entry" }, target: { type: "phi", node: inputPhi, flow: "init" } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "phi", node: inputPhi, flow: "loop" } },
        { source: { type: "proc", node: ltA, flow: "result" }, target: { type: "proc", node: ifA } },
        { source: { type: "proc", node: ifA, flow: "true" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: ifA, flow: "false" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "start" }, target: { target: { type: "phi", node: inputPhi, flow: "init" }, id: "x" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "phi", node: inputPhi, flow: "loop" }, id: "x" } },
        { source: { origin: { type: "phi", node: inputPhi }, id: "x" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "n1" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: ltA, flow: "result" }, id: "res" }, target: { target: { type: "proc", node: ifA }, id: "condition" } },
        { source: { origin: { type: "phi", node: inputPhi }, id: "x" }, target: { target: { type: "proc", node: ltA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "end" }, target: { target: { type: "proc", node: ltA }, id: "b" } },
        { source: { origin: { type: "phi", node: inputPhi }, id: "x" }, target: { target: { type: "output", flow: "result" }, id: "res" } },
      ],
      inputs: {
        start: { names: ["start"], type: typeNumber },
        end: { names: ["end"], type: typeNumber },
        n1: { names: ["1"], type: typeNumber, value: 1 }
      },
      outputFlows: {
        result: { res: typeNumber }
      }
    };

    assert.equal(runGraph(graph, { start: -5, end: 10 }, "result", ".res"), 10);
    assert.equal(runGraph(graph, { start: 0, end: 10 }, "result", ".res"), 10);
    assert.equal(runGraph(graph, { start: 5, end: 10 }, "result", ".res"), 10);
    assert.equal(runGraph(graph, { start: 10, end: 10 }, "result", ".res"), 10);
    assert.equal(runGraph(graph, { start: 15, end: 10 }, "result", ".res"), 15);
    assert.equal(runGraph(graph, { start: 20, end: 10 }, "result", ".res"), 20);
    assert.equal(runGraph(graph, { start: 20, end: 19 }, "result", ".res"), 20);
    assert.equal(runGraph(graph, { start: 20, end: 20 }, "result", ".res"), 20);
    assert.equal(runGraph(graph, { start: 20, end: 21 }, "result", ".res"), 21);
  }
}
