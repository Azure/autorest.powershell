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
  readonly merge: { readonly [id: string]: TType | undefined };
  readonly flows: ReadonlyArray<string>;
}

export interface NodeProc<TType> {
  readonly procID: string;
}

export interface ControlFlow<TType> {
  readonly source: ControlSource<TType>;
  readonly target: ControlSink<TType>;
}

export interface DataFlow<TType> {
  readonly source: SymbolSource<TType>;
  readonly target: SymbolSink<TType>;
}

export interface GraphInputFlow<TType> {
  readonly [id: string]: {
    readonly names: ReadonlyArray<string>,
    readonly type: TType,
    readonly value?: JSONValue
  } | undefined;
}

export interface GraphOutputFlows<TType> {
  readonly [flow: string]: {
    readonly [id: string]: TType | undefined
  } | undefined;
}

export interface Graph<TType> {
  readonly controlFlow: ReadonlyArray<ControlFlow<TType>>;
  readonly dataFlow: ReadonlyArray<DataFlow<TType>>;
  readonly inputs: GraphInputFlow<TType>;
  readonly outputFlows: GraphOutputFlows<TType>;
}