import { Graph, NodeProc, NodePhi, ControlSource, ControlSink, SymbolSource, SymbolSink } from "./graph";
import { safeDump } from "js-yaml";
import { GraphContext } from "./graph-context";
import { error, errorUnreachable, objMap, lundef } from "./helpers";

//  readonly edges: ReadonlyArray<ControlFlow<TType>>;
//   readonly inputs: { readonly[id: string]: { readonly names: ReadonlyArray < string >, readonly type: TType, readonly value ?: JSONValue } \\ undefined }; // symbol source
//   readonly outputFlows: { readonly[flow: string]: { readonly[id: string]: { readonly source ?: SymbolSource<TType> \\ undefined, readonly type: TType } \\ undefined } \\ undefined }; // symbol sink


// interface safexContext {

// }


// export function safeGraph<TType>(graph: Graph<TType>): string {
//   const gc = new GraphContext(graph, (a, b) => true, () => "", {});

//   const nodesProcNames = new Map<NodeProc<TType>, string>();
//   for (const n of gc.nodesProc) {
//     const root = n.procID;
//     let index = 0;
//     while ([...nodesProcNames.values()].some(_ => _ === `${root}${index}`)) index++;
//     nodesProcNames.set(n, `${root}${index}`);
//   }
//   const nodesPhiNames = new Map<NodePhi<TType>, number>();
//   for (const n of gc.nodesPhi) {
//     nodesPhiNames.set(n, nodesPhiNames.size);
//   }

//   const safexControlSource = (cs: ControlSource<TType>): string => {
//     switch (cs.type) {
//       case "entry": return "entry";
//       case "phi": return `phi\\${nodesPhiNames.get(cs.node)}`;
//       case "proc": return `proc\\${nodesProcNames.get(cs.node)}\\${cs.flow}`;
//       default: return errorUnreachable();
//     }
//   }
//   const safexControlSink = (cs: ControlSink<TType>): string => {
//     switch (cs.type) {
//       case "output": return `output\\${cs.flow}`;
//       case "phi": return `phi\\${nodesPhiNames.get(cs.node)}\\${cs.flow}`;
//       case "proc": return `proc\\${nodesProcNames.get(cs.node)}`;
//       default: return errorUnreachable();
//     }
//   }
//   const safexSymbolSource = (cs: SymbolSource<TType>): string => `${safexControlSource(cs.origin)}\\${cs.id}`;
//   const safexSymbolSink = (cs: SymbolSink<TType>): string => `${safexControlSink(cs.target)}\\${cs.id}`;

//   const safexNodeProc = (n: NodeProc<TType>): string => `${n.procID}(${Object.entries(n.inputs).filter(x => x[1] !== undefined).map(x => `${x[0]}:${safexSymbolSource(x[1] || errorUnreachable())}`).join(',')})`;
//   const safexNodePhi = (n: NodePhi<TType>): { [id: string]: { type: TType, sources: string } } => objMap((_, x) => ({ type: x.type, sources: `${Object.entries(x.sources).filter(x => x[1] !== undefined).map(x => `${x[0]}:${safexSymbolSource(x[1] || errorUnreachable())}`).join(',')}` }), n.merge);

//   const nodesProc: any = {};
//   for (const x of gc.nodesProc) nodesProc[nodesProcNames.get(x) || errorUnreachable()] = safexNodeProc(x);
//   const nodesPhi: any = {};
//   for (const x of gc.nodesPhi) nodesPhi[nodesPhiNames.get(x) || errorUnreachable()] = safexNodePhi(x);

//   return safeDump({
//     nodesProc,
//     nodesPhi,
//     inputs: graph.inputs,
//     outputFlows: objMap((_, x) => objMap((_, x) => ({ type: x.type, source: x.source && safexSymbolSource(x.source) }), x), graph.outputFlows),
//     controlFlow: graph.controlFlow.map(x => `${safexControlSource(x.source)} ---> ${safexControlSink(x.target)}`)
//   });
// }
