import { error, objMap, lundef, DeepMutable } from "./helpers";
import { JSONValue } from "./json";
import { ControlSink, ControlSource, Graph, NodePhi, NodeProc, SymbolSource } from "./graph";
import { Type, typeEmpty, typeUnion, typeEquals, typeNominal } from "./type";
import { GraphContext, Proc, SymbolInstance, ProcDefinitions } from "./graph-context";
import { ProcImplementation, ProcImplementations, generateTS } from "./reference-generator";
import { getBuiltInImpls, getBuiltInDefs, typeNumber, typeString } from "../test/common";

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

// const inputPhi: NodePhi = { merge: {} };
// const inputPhiMutable: DeepMutable<NodePhi> = inputPhi;
// const ltA: NodeProc = {
//   procID: "lt",
//   inputs: {
//     "a": { origin: { type: "phi", node: inputPhi }, id: "x" },
//     "b": { origin: { type: "entry" }, id: "end" }
//   }
// };
// const ifA: NodeProc = {
//   procID: "if",
//   inputs: {
//     "condition": { origin: { type: "proc", node: ltA, flow: "result" }, id: "res" }
//   }
// };
// const addA: NodeProc = {
//   procID: "add",
//   inputs: {
//     "a": { origin: { type: "phi", node: inputPhi }, id: "x" },
//     "b": { origin: { type: "entry" }, id: "n1" }
//   }
// };

// inputPhiMutable.merge = {
//   "x": {
//     type: typeNumber,
//     sources: {
//       init: { origin: { type: "entry" }, id: "start" },
//       loop: { origin: { type: "proc", node: addA, flow: "result" }, id: "res" }
//     }
//   }
// };

// const graph: Graph = {
//   edges: [
//     { source: { type: "phi", node: inputPhi }, target: { type: "proc", node: ltA } },
//     { source: { type: "entry" }, target: { type: "phi", node: inputPhi, flow: "init" } },
//     { source: { type: "proc", node: addA, flow: "result" }, target: { type: "phi", node: inputPhi, flow: "loop" } },
//     { source: { type: "proc", node: ltA, flow: "result" }, target: { type: "proc", node: ifA } },
//     { source: { type: "proc", node: ifA, flow: "true" }, target: { type: "proc", node: addA } },
//     { source: { type: "proc", node: ifA, flow: "false" }, target: { type: "output", flow: "result" } }
//   ],
//   inputs: {
//     start: { names: ["start"], type: typeNumber },
//     end: { names: ["end"], type: typeNumber },
//     n1: { names: ["1"], type: typeNumber, value: 1 }
//   },
//   outputFlows: {
//     result: {
//       res: {
//         type: typeNumber,
//         source: { origin: { type: "phi", node: inputPhi }, id: "x" }
//       }
//     }
//   }
// };
// const ga = new GraphContext(graph, getBuiltInDefs());



const code = ga.compile(getBuiltInImpls());
console.log(code);
debugger;
