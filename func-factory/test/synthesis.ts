import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { Graph, NodePhi, NodeProc } from "../src/graph";
import { GraphContext, FlexArgs, FlexCallbacks } from "../src/graph-context";
import { getBuiltInDefs, getBuiltInImpls, typeNumber, typeString, runGraph } from "./common";
import { objMap, error } from "../src/helpers";

@suite class Synthesis {
  @test "simple"() {
    const g: Graph = {
      edges: [],
      inputs: {
        text: { type: typeString, names: ["text"] }
      },
      outputFlows: {
        result: { length: { type: typeNumber } }
      }
    };

    let ga = new GraphContext(g, getBuiltInDefs()).synthesize() || error("synthesis failed to produce working code");
    assert.equal(runGraph(ga.graph, { text: "asd" }, "result", ".length"), 3);
    assert.equal(runGraph(ga.graph, { text: "hello world" }, "result", ".length"), 11);
    assert.equal(runGraph(ga.graph, { text: "" }, "result", ".length"), 0);
  }
  @test "simple with samples"() {
    const g: Graph = {
      edges: [],
      inputs: {
        text: { type: typeString, names: ["text"] }
      },
      outputFlows: {
        result: { length: { type: typeNumber } }
      }
    };

    let ga = new GraphContext(g, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { text: "asd" }, output: { length: 3 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { text: "hello world" }, output: { length: 11 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    assert.equal(runGraph(ga.graph, { text: "asd" }, "result", ".length"), 3);
    assert.equal(runGraph(ga.graph, { text: "hello world" }, "result", ".length"), 11);
    assert.equal(runGraph(ga.graph, { text: "" }, "result", ".length"), 0);
  }

  @test "add 2"() {
    const g: Graph = {
      edges: [],
      inputs: {
        a: { type: typeNumber, names: [] },
        b: { type: typeNumber, names: [] }
      },
      outputFlows: {
        result: { sum: { type: typeNumber } }
      }
    };

    let ga = new GraphContext(g, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4 }, output: { sum: 7 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5 }, output: { sum: 9 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number): void => assert.equal(runGraph(ga.graph, { a, b }, "result", ".sum"), a + b);
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }

  @test "add 3"() {
    const g: Graph = {
      edges: [],
      inputs: {
        a: { type: typeNumber, names: [] },
        b: { type: typeNumber, names: [] },
        c: { type: typeNumber, names: [] }
      },
      outputFlows: {
        result: { sum: { type: typeNumber } }
      }
    };

    let ga = new GraphContext(g, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5 }, output: { sum: 12 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6 }, output: { sum: 15 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number, c: number): void => assert.equal(runGraph(ga.graph, { a, b, c }, "result", ".sum"), a + b + c);
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }

  @test "add 4"() {
    const g: Graph = {
      edges: [],
      inputs: {
        a: { type: typeNumber, names: [] },
        b: { type: typeNumber, names: [] },
        c: { type: typeNumber, names: [] },
        d: { type: typeNumber, names: [] }
      },
      outputFlows: {
        result: { sum: { type: typeNumber } }
      }
    };

    let ga = new GraphContext(g, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5, d: 6 }, output: { sum: 18 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6, d: 7 }, output: { sum: 22 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number, c: number, d: number): void => assert.equal(runGraph(ga.graph, { a, b, c, d }, "result", ".sum"), a + b + c + d);
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }
}
