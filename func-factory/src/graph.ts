import { JSONValue } from "./json";

export type ControlSource<TType> =
  { readonly type: "entry" } |
  { readonly type: "phi", readonly node: NodePhi<TType> } |
  { readonly type: "proc", readonly node: NodeProc<TType>, readonly flow: string };
export type ControlSink<TType> =
  { readonly type: "output", readonly flow: string } |
  { readonly type: "phi", readonly node: NodePhi<TType>, readonly flow: string } |
  { readonly type: "proc", readonly node: NodeProc<TType> };

export interface SymbolSource<TType> {
  readonly origin: ControlSource<TType>;
  readonly id: string;
}
export interface SymbolSink<TType> {
  readonly target: ControlSink<TType>;
  readonly id: string;
}

export interface NodePhi<TType> {
  readonly merge: { readonly [id: string]: { readonly type: TType, readonly sources: { readonly [flow: string]: SymbolSource<TType> | undefined } } | undefined };
}

export interface NodeProc<TType> {
  readonly procID: string;
  readonly inputs: { readonly [id: string]: SymbolSource<TType> | undefined };
}

export interface ControlFlow<TType> {
  readonly source: ControlSource<TType>;
  readonly target: ControlSink<TType>;
}

export interface DataFlow<TType> {
  readonly source: SymbolSource<TType>;
  readonly target: SymbolSink<TType>;
}

export interface Graph<TType> {
  readonly edges: ReadonlyArray<ControlFlow<TType>>;
  readonly inputs: { readonly [id: string]: { readonly names: ReadonlyArray<string>, readonly type: TType, readonly value?: JSONValue } | undefined }; // symbol source
  readonly outputFlows: { readonly [flow: string]: { readonly [id: string]: { readonly source?: SymbolSource<TType> | undefined, readonly type: TType } | undefined } | undefined }; // symbol sink
}