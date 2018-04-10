import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { Graph, NodePhi, NodeProc } from "../src/graph";
import { GraphContext, FlexArgs, FlexCallbacks, Sample, Proc } from "../src/graph-context";
import { getBuiltInDefs, getBuiltInImpls, typeNumber, typeString, runGraph, MyTType, typeAssignableTo, typeBoolean } from "./common";
import { objMap, error } from "../src/helpers";
import { ProcImplementation } from "../src/reference-generator";

@suite class Synthesis {
  @test "simple"() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        text: { type: typeString, names: ["text"] }
      },
      outputFlows: {
        result: { length: typeNumber }
      }
    };

    let ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs()).synthesize() || error("synthesis failed to produce working code");
    assert.equal(runGraph(ga.graph, { text: "asd" }, "result", ".length"), 3);
    assert.equal(runGraph(ga.graph, { text: "hello world" }, "result", ".length"), 11);
    assert.equal(runGraph(ga.graph, { text: "" }, "result", ".length"), 0);
  }
  @test "simple with samples"() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        text: { type: typeString, names: ["text"] }
      },
      outputFlows: {
        result: { length: typeNumber }
      }
    };

    let ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { text: "asd" }, output: { length: 3 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { text: "hello world" }, output: { length: 11 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    assert.equal(runGraph(ga.graph, { text: "asd" }, "result", ".length"), 3);
    assert.equal(runGraph(ga.graph, { text: "hello world" }, "result", ".length"), 11);
    assert.equal(runGraph(ga.graph, { text: "" }, "result", ".length"), 0);
  }

  @test "add 2"() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        a: { type: typeNumber, names: [] },
        b: { type: typeNumber, names: [] }
      },
      outputFlows: {
        result: { sum: typeNumber }
      }
    };

    let ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4 }, output: { sum: 7 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5 }, output: { sum: 9 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number): void => assert.equal(runGraph(ga.graph, { a, b }, "result", ".sum"), a + b);
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }

  @test "add 3"() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        a: { type: typeNumber, names: [] },
        b: { type: typeNumber, names: [] },
        c: { type: typeNumber, names: [] }
      },
      outputFlows: {
        result: { sum: typeNumber }
      }
    };

    let ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5 }, output: { sum: 12 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6 }, output: { sum: 15 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number, c: number): void => assert.equal(runGraph(ga.graph, { a, b, c }, "result", ".sum"), a + b + c);
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }

  @test "add 4"() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        a: { type: typeNumber, names: [] },
        b: { type: typeNumber, names: [] },
        c: { type: typeNumber, names: [] },
        d: { type: typeNumber, names: [] }
      },
      outputFlows: {
        result: { sum: typeNumber }
      }
    };

    let ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5, d: 6 }, output: { sum: 18 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6, d: 7 }, output: { sum: 22 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number, c: number, d: number): void => assert.equal(runGraph(ga.graph, { a, b, c, d }, "result", ".sum"), a + b + c + d);
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }

  @test "name preference"() {
    const g: Graph<MyTType> = {
      controlFlow: [],
      dataFlow: [],
      inputs: {
        a: { type: typeString, names: [] },
        b: { type: typeNumber, names: [] },
        c: { type: typeString, names: ["main"] },
        d: { type: typeNumber, names: ["suffix"] },
        e: { type: typeString, names: ["cowbell"] },
        f: { type: typeString, names: [] },
        g: { type: typeString, names: [] },
        h: { type: typeString, names: [] },
        i: { type: typeString, names: [] },
        j: { type: typeString, names: ["suffix"] },
        k: { type: typeString, names: [] },
        l: { type: typeString, names: [] },
        m: { type: typeString, names: [] },
        n: { type: typeString, names: ["prefix"] },
        o: { type: typeString, names: [] },
        p: { type: typeString, names: [] }
      },
      outputFlows: {
        result: { res: typeString }
      }
    };

    const concatImpl: ProcImplementation = { defInline: (args, cb) => cb.result({ res: `(${args.a} + ${args.b} + ${args.c})` }) };
    const concatDef: Proc<MyTType> = {
      pure: true,
      inputs: {
        a: { names: ["prefix"], type: typeString },
        b: { names: ["main"], type: typeString },
        c: { names: ["suffix"], type: typeString }
      },
      outputFlows: {
        result: {
          res: { names: ["combined"], nameSources: ["b"], type: typeString }
        }
      }
    };
    let ga = new GraphContext(g, typeAssignableTo, x => x, {/* "concat": concatDef*/ }, [
      { impl: { /*"concat": concatImpl*/ }, input: { a: "a", b: 1, c: "c", d: 2, e: "e", f: "f", g: "g", h: "h", i: "i", j: "j", k: "k", l: "l", m: "m", n: "n", o: "o", p: "p" }, output: { res: "a" /*ncj*/ }, outputFlow: "result" },
    ]).synthesize() || error("synthesis failed to produce working code");
  }

  @test "two calls, one field read, one field write"() {
    // supposed to infer the following:
    // x = f(a: string, b: string, n: string);
    // y = g(a: string, c: string, x.n: string);
    // x.y = y;
    // return x;

    // TODO
  }
}
