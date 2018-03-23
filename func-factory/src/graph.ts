import { JSONValue } from "./json";
import { Type } from "./type";

export type ControlSource =
  { readonly type: "entry" } |
  { readonly type: "phi", readonly node: NodePhi } |
  { readonly type: "proc", readonly node: NodeProc, readonly flow: string };
export type ControlSink =
  { readonly type: "output", readonly flow: string } |
  { readonly type: "phi", readonly node: NodePhi, readonly flow: string } |
  { readonly type: "proc", readonly node: NodeProc };

export interface SymbolSource {
  readonly origin: ControlSource;
  readonly id: string;
}
/* @internal */
export interface SymbolSink {
  readonly target: ControlSink;
  readonly id: string;
}

export interface NodePhi {
  readonly merge: { readonly [id: string]: { readonly type: Type, readonly sources: { readonly [flow: string]: SymbolSource | undefined } } | undefined };
}

export interface NodeProc {
  readonly procID: string;
  readonly inputs: { readonly [id: string]: SymbolSource | undefined };
}

export interface ControlFlow {
  readonly source: ControlSource;
  readonly target: ControlSink;
}

/* @internal */
export interface DataFlow {
  readonly source: SymbolSource;
  readonly target: SymbolSink;
}

export interface Graph {
  readonly edges: ReadonlyArray<ControlFlow>;
  readonly inputs: { readonly [id: string]: { readonly names: ReadonlyArray<string>, readonly type: Type, readonly value?: JSONValue } | undefined }; // symbol source
  readonly outputFlows: { readonly [flow: string]: { readonly [id: string]: { readonly source?: SymbolSource | undefined, readonly type: Type } | undefined } | undefined }; // symbol sink
}