import { NodePhi, SymbolSource, NodeProc, ControlSink, ControlSource, ControlFlow, Graph, SymbolSink } from "./graph";
import { error, objMap, lundef, errorUnreachable } from "./helpers";
import { validateNodePhi, validateNodeProc } from "./graph-validation";
import { ProcDefinitions, SymbolInstance, Proc } from "./graph-context";

export function getNodes<TType>(g: Graph<TType>): { nodesPhi: Iterable<NodePhi<TType>>, nodesProc: Iterable<NodeProc<TType>> } {
  const nodesPhi = new Set<NodePhi<TType>>();
  const nodesProc = new Set<NodeProc<TType>>();

  const visitSymbolSource = (ss: SymbolSource<TType> | undefined): void => ss !== undefined && visitDataConnector(ss.origin) || undefined;
  const visitDataConnector = (ds: ControlSource<TType> | ControlSink<TType>): void => {
    switch (ds.type) {
      case "phi":
        visitPhi(ds.node);
        break;
      case "proc":
        visitProc(ds.node);
        break;
    }
  };
  const visitPhi = (nodePhi: NodePhi<TType>): void => {
    if (nodesPhi.has(nodePhi)) return;
    nodesPhi.add(nodePhi);
    for (const x of Object.values(nodePhi.merge)) if (x !== undefined) for (const y of Object.values(x.sources)) visitSymbolSource(y);
  };
  const visitProc = (nodeProc: NodeProc<TType>): void => {
    if (nodesProc.has(nodeProc)) return;
    nodesProc.add(nodeProc);
    for (const x of Object.values(nodeProc.inputs)) visitSymbolSource(x);
  };

  for (const f of Object.values(g.outputFlows))
    if (f !== undefined)
      for (const x of Object.values(f))
        if (x !== undefined)
          visitSymbolSource(x.source);
  for (const e of g.edges) {
    visitDataConnector(e.source);
    visitDataConnector(e.target);
  }

  return {
    nodesPhi: nodesPhi,
    nodesProc: nodesProc
  };
}



export function getDataSources<TType>(g: Graph<TType>, procs: ProcDefinitions<TType>, nodesPhi: Iterable<NodePhi<TType>>, nodesProc: Iterable<NodeProc<TType>>): {
  controlSources: ReadonlyArray<ControlSource<TType>>,
  controlSourceEquals: (a: ControlSource<TType>, b: ControlSource<TType>) => boolean
} {
  const controlSources: ControlSource<TType>[] = [];
  controlSources.push({ type: "entry" });
  for (const n of nodesPhi) controlSources.push({ type: "phi", node: n });
  for (const n of nodesProc) for (const f in (procs[n.procID] || { outputFlows: {} }).outputFlows) controlSources.push({ type: "proc", node: n, flow: f });
  const controlSourceEquals = (a: ControlSource<TType>, b: ControlSource<TType>): boolean => {
    if (a.type === "entry" && b.type === "entry")
      return true;
    if (a.type === "phi" && b.type === "phi")
      return a.node === b.node;
    if (a.type === "proc" && b.type === "proc")
      return a.node === b.node && a.flow === b.flow;
    return false;
  };
  return { controlSources, controlSourceEquals };
}

export function getControlSinks<TType>(g: Graph<TType>, procs: ProcDefinitions<TType>, nodesPhi: Iterable<NodePhi<TType>>, nodesProc: Iterable<NodeProc<TType>>): {
  controlSinks: ReadonlyArray<ControlSink<TType>>,
  controlSinkEquals: (a: ControlSink<TType>, b: ControlSink<TType>) => boolean
} {
  const controlSinks: ControlSink<TType>[] = [];
  for (const f in g.outputFlows) controlSinks.push({ type: "output", flow: f });
  for (const n of nodesPhi) for (const m of Object.values(n.merge)) if (m !== undefined) for (const f in m.sources) controlSinks.push({ type: "phi", node: n, flow: f });
  for (const n of nodesProc) controlSinks.push({ type: "proc", node: n });
  const controlSinkEquals = (a: ControlSink<TType>, b: ControlSink<TType>): boolean => {
    if (a.type === "output" && b.type === "output")
      return a.flow === b.flow;
    if (a.type === "phi" && b.type === "phi")
      return a.node === b.node && a.flow === b.flow;
    if (a.type === "proc" && b.type === "proc")
      return a.node === b.node;
    return false;
  };
  return { controlSinks, controlSinkEquals };
}

export function getSymbolSources<TType>(g: Graph<TType>, procs: ProcDefinitions<TType>, controlSources: Iterable<ControlSource<TType>>, controlSourceEquals: (a: ControlSource<TType>, b: ControlSource<TType>) => boolean): {
  symbolSources: ReadonlyArray<SymbolSource<TType>>,
  symbolSourceEquals: (a: SymbolSource<TType>, b: SymbolSource<TType>) => boolean
} {
  const symbolSources: SymbolSource<TType>[] = [];
  for (const s of controlSources)
    switch (s.type) {
      case "entry":
        for (const id in g.inputs) symbolSources.push({ origin: s, id: id });
        break;
      case "phi":
        for (const id in s.node.merge) symbolSources.push({ origin: s, id: id });
        break;
      case "proc":
        for (const id in (procs[s.node.procID] || { outputFlows: <{ [id: string]: undefined }>{} }).outputFlows[s.flow] || {}) symbolSources.push({ origin: s, id: id });
        break;
    }
  const symbolSourceEquals = (a: SymbolSource<TType>, b: SymbolSource<TType>): boolean => controlSourceEquals(a.origin, b.origin) && a.id === b.id;
  return { symbolSources, symbolSourceEquals };
}

export function getSymbolSinks<TType>(g: Graph<TType>, procs: ProcDefinitions<TType>, controlSinks: Iterable<ControlSink<TType>>, controlSinkEquals: (a: ControlSink<TType>, b: ControlSink<TType>) => boolean): {
  symbolSinks: ReadonlyArray<SymbolSink<TType>>,
  symbolSinkEquals: (a: SymbolSink<TType>, b: SymbolSink<TType>) => boolean
} {
  const symbolSinks: SymbolSink<TType>[] = [];
  for (const s of controlSinks)
    switch (s.type) {
      case "output":
        for (const id in g.outputFlows[s.flow] || {}) symbolSinks.push({ target: s, id: id });
        break;
      case "phi":
        for (const id in s.node.merge) symbolSinks.push({ target: s, id: id });
        break;
      case "proc":
        for (const id in (procs[s.node.procID] || { inputs: {} }).inputs) symbolSinks.push({ target: s, id: id });
        break;
    }
  const symbolSinkEquals = (a: SymbolSink<TType>, b: SymbolSink<TType>): boolean => controlSinkEquals(a.target, b.target) && a.id === b.id;
  return { symbolSinks, symbolSinkEquals };
}

export function getSymbolMapper<TType>(g: Graph<TType>, procs: ProcDefinitions<TType>, symbolSources: ReadonlyArray<SymbolSource<TType>>, symbolSourceNorm: (a: SymbolSource<TType>) => SymbolSource<TType> | undefined):
  (src: SymbolSource<TType>) => SymbolInstance<TType> | undefined {
  interface SymbolInstanceMutable {
    source: SymbolSource<TType>;
    type: TType;
    names: Array<string>;
  }

  const symbols = new Map<SymbolSource<TType>, SymbolInstanceMutable>();
  // init symbols (only statically known names and types)
  for (const src of symbolSources) {
    const type = getSymbolSourceType(g, procs, src);
    if (type) {
      const symbol: SymbolInstanceMutable = {
        source: src,
        names: getSymbolSourceKnownNames(g, procs, src).slice(),
        type: type
      };
      symbols.set(src, symbol);
    }
  }
  const getSymbol = (src: SymbolSource<TType>): SymbolInstanceMutable | undefined => {
    const x = symbolSourceNorm(src);
    return x && symbols.get(x);
  };

  // name/type propagation across symbols
  const transfers: { source: SymbolInstanceMutable, target: SymbolInstanceMutable, transferType: boolean, transferNames: boolean }[] = [];
  // - collect
  for (const target of symbolSources) {
    switch (target.origin.type) {
      case "entry":
        break;
      case "phi":
        lundef(target.origin.node.merge[target.id], x =>
          Object.values(x.sources).forEach(source =>
            lundef(source, source =>
              lundef(getSymbol(source), s1 =>
                lundef(getSymbol(target), s2 =>
                  transfers.push({ source: s1, target: s2, transferType: true, transferNames: true }))))));
        break;
      case "proc":
        const flow = target.origin.flow;
        const node = target.origin.node;
        lundef(procs[node.procID], _ =>
          lundef(_.outputFlows[flow], _ =>
            lundef(_[target.id], _ =>
              _.nameSources.forEach(sourceId =>
                lundef(node.inputs[sourceId], source =>
                  lundef(getSymbol(source), s1 =>
                    lundef(getSymbol(target), s2 =>
                      transfers.push({ source: s1, target: s2, transferType: false, transferNames: true }))))))));

        break;
      default: return errorUnreachable();
    }
  }
  // - propagate (fixed-point iteration)
  let redo = true;
  while (redo) {
    redo = false;
    for (const transfer of transfers) {
      // names
      if (transfer.transferNames) {
        for (const name of transfer.source.names) {
          if (!transfer.target.names.includes(name)) {
            transfer.target.names.push(name);
            redo = true;
          }
        }
      }
    }
  }

  return getSymbol;
}

export function nodeSource2Sinks<TType>(x: ControlSource<TType>, controlSinks: ReadonlyArray<ControlSink<TType>>): ReadonlyArray<ControlSink<TType>> {
  switch (x.type) {
    case "entry": return [];
    case "phi": return controlSinks.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSinks.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}
export function nodeSource2Sources<TType>(x: ControlSource<TType>, controlSources: ReadonlyArray<ControlSource<TType>>): ReadonlyArray<ControlSource<TType>> {
  switch (x.type) {
    case "entry": return controlSources.filter(y => y.type === "entry");
    case "phi": return controlSources.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSources.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}
export function nodeSink2Sinks<TType>(x: ControlSink<TType>, controlSinks: ReadonlyArray<ControlSink<TType>>): ReadonlyArray<ControlSink<TType>> {
  switch (x.type) {
    case "output": return controlSinks.filter(y => y.type === "output");
    case "phi": return controlSinks.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSinks.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}
export function nodeSink2Sources<TType>(x: ControlSink<TType>, controlSources: ReadonlyArray<ControlSource<TType>>): ReadonlyArray<ControlSource<TType>> {
  switch (x.type) {
    case "output": return [];
    case "phi": return controlSources.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSources.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}

export function getSymbolSourceType<TType>(graph: Graph<TType>, procs: ProcDefinitions<TType>, src: SymbolSource<TType>): TType | undefined {
  const dsrc = src.origin;
  switch (dsrc.type) {
    case "entry": {
      const x = graph.inputs[src.id];
      return x && x.type;
    }
    case "phi": {
      const x = dsrc.node.merge[src.id];
      return x && x.type;
    }
    case "proc": {
      const proc = procs[dsrc.node.procID];
      const flow = proc && proc.outputFlows[dsrc.flow];
      const x = flow && flow[src.id];
      return x && x.type;
    }
    default: return errorUnreachable();
  }
}
export function getSymbolSinkType<TType>(graph: Graph<TType>, procs: ProcDefinitions<TType>, symbolSink: SymbolSink<TType>): TType | undefined {
  const controlSink = symbolSink.target;
  switch (controlSink.type) {
    case "output": {
      const flow = graph.outputFlows[controlSink.flow];
      const x = flow && flow[symbolSink.id];
      return x && x.type;
    }
    case "phi": {
      const x = controlSink.node.merge[symbolSink.id];
      return x && x.type;
    }
    case "proc": {
      const proc = procs[controlSink.node.procID];
      const x = proc && proc.inputs[symbolSink.id];
      return x && x.type;
    }
    default: return errorUnreachable();
  }
}
export function getSymbolSourceKnownNames<TType>(graph: Graph<TType>, procs: ProcDefinitions<TType>, src: SymbolSource<TType>): ReadonlyArray<string> {
  const dsrc = src.origin;
  switch (dsrc.type) {
    case "entry": {
      const x = graph.inputs[src.id];
      return x && x.names || [];
    }
    case "phi": {
      const x = dsrc.node.merge[src.id];
      return [];
    }
    case "proc": {
      const proc = procs[dsrc.node.procID];
      const flow = proc && proc.outputFlows[dsrc.flow];
      const x = flow && flow[src.id];
      return x && x.names || [];
    }
    default: return errorUnreachable();
  }
}
export function getSymbolSinkKnownNames<TType>(graph: Graph<TType>, procs: ProcDefinitions<TType>, symbolSink: SymbolSink<TType>): ReadonlyArray<string> {
  const controlSink = symbolSink.target;
  switch (controlSink.type) {
    case "output":
      return [];
    case "phi":
      return []; // could try fetching from consumers (but careful, loop possible!)
    case "proc": {
      const proc = procs[controlSink.node.procID];
      const x = proc && proc.inputs[symbolSink.id];
      return x && x.names || [];
    }
    default: return errorUnreachable();
  }
}

export function getSymbolSourceOf<TType>(graph: Graph<TType>, procs: ProcDefinitions<TType>, symbolSink: SymbolSink<TType>): SymbolSource<TType> | undefined {
  const controlSink = symbolSink.target;
  switch (controlSink.type) {
    case "output":
      return ((graph.outputFlows[controlSink.flow] || <{ [id: string]: { source: undefined } }>{})[symbolSink.id] || { source: undefined }).source;
    case "phi":
      return (controlSink.node.merge[symbolSink.id] || { sources: <{ [id: string]: undefined }>{} }).sources[controlSink.flow];
    case "proc":
      return controlSink.node.inputs[symbolSink.id];
  }
}

export function getMarket<TType>(
  g: Graph<TType>,
  flows: ReadonlyArray<ControlFlow<TType>>,
  controlSources: ReadonlyArray<ControlSource<TType>>,
  controlSinks: ReadonlyArray<ControlSink<TType>>,
  symbolSources: ReadonlyArray<SymbolSource<TType>>,
  controlSourceNorm: (a: ControlSource<TType>) => ControlSource<TType> | undefined,
  controlSinkNorm: (a: ControlSink<TType>) => ControlSink<TType> | undefined,
  _getSymbol: (src: SymbolSource<TType>) => SymbolInstance<TType> | undefined): { supply: ReadonlyMap<ControlSource<TType>, ReadonlySet<SymbolInstance<TType>>>, demand: ReadonlyMap<ControlSink<TType>, ReadonlySet<SymbolInstance<TType>>> } {

  const getSymbol = (src: SymbolSource<TType> | undefined): SymbolInstance<TType> | undefined => src === undefined ? undefined : _getSymbol(src);

  // adjacency
  const flowOut = new Map<ControlSource<TType>, ControlFlow<TType>>();
  const flowIn = new Map<ControlSink<TType>, ControlFlow<TType>>();
  for (const f of flows) {
    flowOut.set(f.source, f);
    flowIn.set(f.target, f);
  }

  // propagate available symbols through flow (forward)
  const supply = new Map<ControlSource<TType>, Set<SymbolInstance<TType>>>(controlSources.map<[ControlSource<TType>, Set<SymbolInstance<TType>>]>(x => [x, new Set<SymbolInstance<TType>>()]));
  for (const src of symbolSources) {
    // - init
    const conditions = new Map<ControlSource<TType>, Set<ControlFlow<TType>>>();
    conditions.set(src.origin, new Set<ControlFlow<TType>>());
    const updated = new Set<ControlSource<TType>>();
    updated.add(src.origin);

    // - propagate (fixed-point iteration; need to detect self-sustaining cycles involving phi!)
    while (updated.size > 0) {
      const update = updated.values().next().value;
      updated.delete(update);
      const flow = flowOut.get(update);
      if (flow !== undefined) {
        const sink = flow.target;
        // -- collect influx conditions
        const conditionsToProceed = new Set<ControlFlow<TType>>();
        for (const influx of nodeSink2Sinks(sink, controlSinks).map(x => flowIn.get(x)).filter(x => x) as any) {
          const influxConditions = conditions.get(influx.source);
          if (influxConditions) for (const x of influxConditions) conditionsToProceed.add(x);
          else conditionsToProceed.add(influx);
        }

        // -- propagate conditions
        for (const outflux of nodeSink2Sources(sink, controlSources).map(x => flowOut.get(x)).filter(x => x) as any) {
          const newCond = new Set<ControlFlow<TType>>(conditionsToProceed);
          newCond.delete(outflux);
          const previousCond = conditions.get(outflux.source);
          if (!previousCond || previousCond.size > newCond.size) {
            conditions.set(outflux.source, newCond);
            updated.add(outflux.source);
          }
        }
      }
    }

    // - commit
    const symbol = _getSymbol(src) || errorUnreachable();
    for (const [flow, cond] of conditions.entries())
      if (cond.size === 0)
        (supply.get(flow) || errorUnreachable()).add(symbol);
  }

  // mark required symbols
  const demand = new Map<ControlSink<TType>, Set<SymbolInstance<TType>>>(controlSinks.map<[ControlSink<TType>, Set<SymbolInstance<TType>>]>(x => [x, new Set<SymbolInstance<TType>>()]));
  const updated = new Set<ControlSink<TType>>();
  for (const ds of controlSinks) {
    const markRequired = (sym: SymbolInstance<TType> | undefined) => {
      if (sym !== undefined) {
        (demand.get(ds) || errorUnreachable()).add(sym);
        updated.add(ds);
      }
    };
    switch (ds.type) {
      case "output":
        for (const sym of Object.values(g.outputFlows[ds.flow] || {}).map(x => x && x.source).map(getSymbol))
          markRequired(sym);
        break;
      case "phi":
        for (const sym of Object.values(ds.node.merge).map(x => x && x.sources[ds.flow]).map(getSymbol))
          markRequired(sym); // TODO: only if outgoing symbol is required
        break;
      case "proc":
        for (const sym of Object.values(ds.node.inputs).map(getSymbol))
          markRequired(sym);
        break;
    }
  }


  // propagate required symbols through flow (backward)
  while (updated.size > 0) {
    const update = updated.values().next().value;
    updated.delete(update);
    const tmp = flowIn.get(update);
    if (tmp === undefined) continue;
    const source = tmp.source;
    const predFlows = nodeSource2Sinks(source, controlSinks);
    for (const sym of demand.get(update) || []) {
      if (sym.source.origin !== source) {
        for (const predFlow of predFlows) {
          const set = demand.get(predFlow) || new Set<SymbolInstance<TType>>();
          if (!set.has(sym)) {
            set.add(sym);
            demand.set(predFlow, set);
            updated.add(predFlow);
          }
        }
      }
    }
  }


  return { demand, supply };
}
