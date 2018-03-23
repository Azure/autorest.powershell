import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { Graph, NodePhi, NodeProc } from "../src/graph";
import { GraphContext, FlexArgs, FlexCallbacks } from "../src/graph-context";
import { getBuiltInDefs, getBuiltInImpls, typeNumber, typeString, runGraph } from "./common";
import { objMap } from "../src/helpers";

@suite class Mutation {
  @test "build graph"() {
    const g: Graph = {
      edges: [],
      inputs: {
        text: { type: typeString, names: ["text"] }
      },
      outputFlows: {
        result: { length: { type: typeNumber } },
        error: {}
      }
    };

    const len: NodeProc = { procID: "strlen", inputs: {} };

    let ga = new GraphContext(g, getBuiltInDefs())
      .connectControlFlow({ type: "proc", node: len, flow: "result" }, { type: "output", flow: "result" })
      .connectControlFlow({ type: "entry" }, { type: "proc", node: len })
      .connectDataFlow({ origin: { type: "proc", node: len, flow: "result" }, id: "length" }, { target: { type: "output", flow: "result" }, id: "length" })
      .connectDataFlow({ origin: { type: "entry" }, id: "text" }, { target: { type: "proc", node: len }, id: "s" });

    assert.equal(runGraph(ga.graph, { text: "asd" }, "result", ".length"), 3);
    assert.equal(runGraph(ga.graph, { text: "hello world" }, "result", ".length"), 11);
    assert.equal(runGraph(ga.graph, { text: "" }, "result", ".length"), 0);
  }
}
