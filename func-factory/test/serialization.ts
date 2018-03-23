import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { Graph, NodePhi, NodeProc } from "../src/graph";
import { GraphContext, FlexArgs, FlexCallbacks } from "../src/graph-context";
import { getBuiltInDefs, getBuiltInImpls, typeNumber, typeString, runGraph, MyTType, typeAssignableTo } from "./common";
import { objMap, error } from "../src/helpers";
import { safeGraph } from "../src/graph-serializer";

@suite class Serialization {
  @test "simple"() {
    const g: Graph<MyTType> = {
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

    let ga = new GraphContext(g, typeAssignableTo, x => x, getBuiltInDefs(), [
      { impl: getBuiltInImpls(), input: { a: 3, b: 4, c: 5 }, output: { sum: 12 }, outputFlow: "result" },
      { impl: getBuiltInImpls(), input: { a: 4, b: 5, c: 6 }, output: { sum: 15 }, outputFlow: "result" }
    ]).synthesize() || error("synthesis failed to produce working code");

    console.error(safeGraph(ga.graph));
  }
}