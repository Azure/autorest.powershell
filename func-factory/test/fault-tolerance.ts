import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { Graph, NodePhi, NodeProc } from "../src/graph";
import { GraphContext } from "../src/graph-context";
import { getBuiltInDefs, getBuiltInImpls, typeNumber, typeString, MyTType, typeAssignableTo } from "./common";
import { generateTS, GenerationFlavor } from "../src/reference-generator";
import { DeepMutable, objMap, tsc } from "../src/helpers";

/**
 * Incomplete graphs are an everyday case, we're the ones who are supposed to fill in blanks!
 * This requires that the GraphContext constructor works regardless of the state of the incoming Graph.
 * Ideally, the same is true for code gen, however we do not expect the generated code to be runnable - but incomplete code may still be insightful.
 * 
 * Bottom line: GraphContext and the reference generator should never throw.
 */

function compileGraph(graph: Graph<MyTType>, expectCompiles: boolean): void {
  let context: GraphContext<MyTType>;
  try { context = new GraphContext(graph, typeAssignableTo, x => x, getBuiltInDefs()); }
  catch (e) { console.error("Error: GraphContext creation failed"); throw e; }
  let funcTs: string;
  try { funcTs = generateTS(context, getBuiltInImpls(), x => x, GenerationFlavor.ContInlineProc); }
  catch (e) { console.error("Error: Code generation failed"); throw e; }
  let funcJs: string;
  try { funcJs = tsc("const f = " + funcTs); if (!expectCompiles) throw "Compilation succeeded unexpectedly."; }
  catch (e) { if (expectCompiles) throw "Compilation failed unexpectedly: " + e; }
}

@suite class FaultTolerance {
  @test "addition good"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, true);
  }
  @test "addition bad procID"() {
    const addA: NodeProc<MyTType> = { procID: "asd" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition missing edge 1"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        // { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition missing edge 2"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        // { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition circular edge"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "proc", node: addA } }, // circular
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition bad control flow source"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "resalt" /*bad*/ }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition bad control flow target"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "resalt" /*bad*/ } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition bad proc input dst"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "aa" /*bad dst*/ } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition bad symbol source"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "aa" /*bad src*/ }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition bad input type"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeString /*mismatch*/ }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeNumber } }
    }, false);
  }
  @test "addition bad output type"() {
    const addA: NodeProc<MyTType> = { procID: "add" };
    compileGraph({
      controlFlow: [
        { source: { type: "entry" }, target: { type: "proc", node: addA } },
        { source: { type: "proc", node: addA, flow: "result" }, target: { type: "output", flow: "result" } }
      ],
      dataFlow: [
        { source: { origin: { type: "entry" }, id: "a" }, target: { target: { type: "proc", node: addA }, id: "a" } },
        { source: { origin: { type: "entry" }, id: "b" }, target: { target: { type: "proc", node: addA }, id: "b" } },
        { source: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }, target: { target: { type: "output", flow: "result" }, id: "res" } }
      ],
      inputs: { a: { names: ["a"], type: typeNumber }, b: { names: ["b"], type: typeNumber } },
      outputFlows: { result: { res: typeString /*mismatch*/ } }
    }, false);
  }

}
