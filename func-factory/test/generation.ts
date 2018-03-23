import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { Graph, NodePhi, NodeProc } from "../src/graph";
import { GraphContext, FlexFunc, FlexArgs, FlexCallbacks } from "../src/graph-context";
import { getBuiltInDefs, getBuiltInImpls, typeNumber, runGraph } from "./common";
import { generateTS, GenerationFlavor } from "../src/reference-generator";
import { DeepMutable, objMap, tsc } from "../src/helpers";

@suite class Generation {
  @test "addition"() {
    const addA: NodeProc = {
      procID: "add",
      inputs: {
        a: { origin: { type: "entry" }, id: "a" },
        b: { origin: { type: "entry" }, id: "b" }
      }
    };
    const graph: Graph = {
      edges: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      inputs: {
        a: { names: ["a"], type: typeNumber },
        b: { names: ["b"], type: typeNumber }
      },
      outputFlows: {
        result: {
          res: {
            type: typeNumber,
            source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }
          }
        }
      }
    };

    assert.equal(runGraph(graph, { a: 1, b: 2 }, "result", ".res"), 3);
    assert.equal(runGraph(graph, { a: 4, b: 2 }, "result", ".res"), 6);
    assert.equal(runGraph(graph, { a: 4, b: 8 }, "result", ".res"), 12);
  }

  @test "loop"() {
    const inputPhi: NodePhi = { merge: {} };
    const inputPhiMutable: DeepMutable<NodePhi> = inputPhi;
    const ltA: NodeProc = {
      procID: "lt",
      inputs: {
        "a": { origin: { type: "phi", node: inputPhi }, id: "x" },
        "b": { origin: { type: "entry" }, id: "end" }
      }
    };
    const ifA: NodeProc = {
      procID: "if",
      inputs: {
        "condition": { origin: { type: "proc", node: ltA, flow: "result" }, id: "res" }
      }
    };
    const addA: NodeProc = {
      procID: "add",
      inputs: {
        "a": { origin: { type: "phi", node: inputPhi }, id: "x" },
        "b": { origin: { type: "entry" }, id: "n1" }
      }
    };

    inputPhiMutable.merge = {
      "x": {
        type: typeNumber,
        sources: {
          init: { origin: { type: "entry" }, id: "start" },
          loop: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }
        }
      }
    };

    const graph: Graph = {
      edges: [
        { source: { type: "phi", node: inputPhi }, target: { type: "proc", node: ltA } },
        { source: { type: "entry" }, target: { type: "phi", node: inputPhi, flow: "init" } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "phi", node: inputPhi, flow: "loop" } },
        { source: { type: "proc", node: ltA, flow: "result" }, target: { type: "proc", node: ifA } },
        { source: { type: "proc", node: ifA, flow: "true" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: ifA, flow: "false" }, target: { type: "output", flow: "result" } }
      ],
      inputs: {
        start: { names: ["start"], type: typeNumber },
        end: { names: ["end"], type: typeNumber },
        n1: { names: ["1"], type: typeNumber, value: 1 }
      },
      outputFlows: {
        result: {
          res: {
            type: typeNumber,
            source: { origin: { type: "phi", node: inputPhi }, id: "x" }
          }
        }
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
