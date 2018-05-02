import { suite, test, slow, timeout, skip, only } from 'mocha-typescript';
import * as assert from 'assert';
import { Graph, NodePhi, NodeProc } from '../src/graph';
import { GraphContext, FlexArgs, FlexCallbacks, Sample, Proc } from '../src/graph-context';
import { getBuiltInDefs, getBuiltInImpls, typeNumber, typeString, runGraph, MyTType, typeAssignableTo, typeBoolean } from './common';
import { objMap, error } from '../src/helpers';
import { ProcImplementation } from '../src/reference-generator';

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
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 6, d: 5 }, output: { sum: 18 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5, d: 6 }, output: { sum: 18 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6, d: 7 }, output: { sum: 22 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
    const test = (a: number, b: number, c: number, d: number): void => {
      const sum = runGraph(ga.graph, { a, b, c, d }, "result", ".sum");
      assert.equal(sum, a + b + c + d, `${a} + ${b} + ${c} + ${d} != ${sum}\n${ga.compile(getBuiltInImpls())}`);
    };
    for (let i = 0; i < 4; ++i)
      test(Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0, Math.random() * 1000 | 0);
  }

  @test "select"() {
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
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5, d: 6 }, output: { sum: 5 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6, d: 7 }, output: { sum: 6 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");
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
    let ga = new GraphContext(g, typeAssignableTo, x => x, { "concat": concatDef }, [
      { impl: { "concat": concatImpl }, input: { a: "a", b: 1, c: "c", d: 2, e: "e", f: "f", g: "g", h: "h", i: "i", j: "j", k: "k", l: "l", m: "m", n: "n", o: "o", p: "p" }, output: { res: "ncj" }, outputFlow: "result" },
    ]).synthesize() || error("synthesis failed to produce working code");
  }

  @test "two calls, one field read, one field write"() {
    // supposed to infer the following (function call contains actual parameter, not formal parameter)
    //
    // x = f(a: string, b: string, n: string);
    // y = g(a: string, c: string, x.n: string);
    // x.y = y;
    // return x;

    const fImpl: ProcImplementation = {
      defInline: (args, cb) => cb.result({
        res: `(${args.a} === "mySubscription" as string && ${args.b} === "someRG" as string && ${args.n} === "fred cowbell" as string ? { serverName: "server 1" } : {})`
      })
    };
    const fDef: Proc<MyTType> = {
      pure: false,
      inputs: {
        a: { names: ["subscription"], type: typeString },
        b: { names: ["resourceGroup"], type: typeString },
        n: { names: ["name"], type: typeString }
      },
      outputFlows: {
        result: { res: { names: ["resource"], nameSources: [], type: "SqlServer" } }
      }
    };
    const gImpl: ProcImplementation = {
      defInline: (args, cb) => cb.result({
        res: `(${args.a} === "mySubscription" as string && ${args.n} === "server 1" as string ? { color: "red", size: ${args.c} } : {})`
      })
    };
    const gDef: Proc<MyTType> = {
      pure: false,
      inputs: {
        a: { names: ["subscription"], type: typeString },
        c: { names: ["size"], type: typeString },
        n: { names: ["serverName"], type: typeString }
      },
      outputFlows: {
        result: { res: { names: ["details"], nameSources: [], type: "SqlServerDetails" } }
      }
    };
    const getServerNameImpl: ProcImplementation = { defInline: (args, cb) => cb.result({ res: `${args.a}.serverName` }) };
    const getServerNameDef: Proc<MyTType> = {
      pure: true,
      inputs: {
        a: { names: ["server"], type: "SqlServer" }
      },
      outputFlows: {
        result: { res: { names: ["serverName"], nameSources: [], type: typeString } }
      }
    };
    const setDetailsImpl: ProcImplementation = { defInline: (args, cb) => `(() => { ${args.a}.details = ${args.b}; ${cb.result({})} })()` };
    const setDetailsDef: Proc<MyTType> = {
      pure: false,
      inputs: {
        a: { names: ["server"], type: "SqlServer" },
        b: { names: ["details"], type: "SqlServerDetails" }
      },
      outputFlows: { result: {} }
    };

    const nodeF = { procID: "f" };
    const nodeGetServerName = { procID: "getServerName" };
    const nodeG = { procID: "g" };
    const nodeSetDetails = { procID: "setDetails" };

    const g: Graph<MyTType> = {
      controlFlow: [  // user hint: there must be a call to "f", "g" and "setDetails" and "getServerName"
        { source: { type: "proc", node: nodeF, flow: "result" }, target: { type: "proc", node: nodeGetServerName } },
        { source: { type: "proc", node: nodeGetServerName, flow: "result" }, target: { type: "proc", node: nodeG } },
        { source: { type: "proc", node: nodeG, flow: "result" }, target: { type: "proc", node: nodeSetDetails } },
        { source: { type: "proc", node: nodeSetDetails, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [],
      inputs: {
        a: { type: typeString, names: ["subscription"] },
        b: { type: typeString, names: ["resourceGroup"] },
        c: { type: typeString, names: ["size"] },
        n: { type: typeString, names: ["name"] }
      },
      outputFlows: {
        result: { res: "SqlServer" }
      }
    };
    let ga = new GraphContext(g, typeAssignableTo, x => x.startsWith("Sql") ? "any" : x, { "f": fDef, "g": gDef, "getServerName": getServerNameDef, "setDetails": setDetailsDef }, [
      {
        impl: { "f": fImpl, "g": gImpl, "getServerName": getServerNameImpl, "setDetails": setDetailsImpl },
        input: { a: "mySubscription", b: "someRG", c: "large", n: "fred cowbell" }, output: { res: { serverName: "server 1", details: { color: "red", size: "large" } } }, outputFlow: "result"
      }
    ]).synthesize() || error("synthesis failed to produce working code");
  }
}
