import { NodePhi, SymbolSource, NodeProc, ControlSink, ControlSource, ControlFlow, Graph, SymbolSink } from "./graph";
import { error, objMap, lundef, errorUnreachable } from "./helpers";
import { typeEmpty, Type, typeUnion, typeEquals } from "./type";
import { validateNodePhi, validateNodeProc } from "./graph-validation";
import { ProcDefinitions, SymbolInstance, Proc } from "./graph-context";

export function getNodes(g: Graph): { nodesPhi: Iterable<NodePhi>, nodesProc: Iterable<NodeProc> } {
  const nodesPhi = new Set<NodePhi>();
  const nodesProc = new Set<NodeProc>();

  const visitSymbolSource = (ss: SymbolSource | undefined): void => ss !== undefined && visitDataConnector(ss.origin) || undefined;
  const visitDataConnector = (ds: ControlSource | ControlSink): void => {
    switch (ds.type) {
      case "phi":
        visitPhi(ds.node);
        break;
      case "proc":
        visitProc(ds.node);
        break;
    }
  };
  const visitPhi = (nodePhi: NodePhi): void => {
    if (nodesPhi.has(nodePhi)) return;
    nodesPhi.add(nodePhi);
    for (const x of Object.values(nodePhi.merge)) if (x !== undefined) for (const y of Object.values(x.sources)) visitSymbolSource(y);
  };
  const visitProc = (nodeProc: NodeProc): void => {
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



export function getDataSources(g: Graph, procs: ProcDefinitions, nodesPhi: Iterable<NodePhi>, nodesProc: Iterable<NodeProc>): {
  controlSources: ReadonlyArray<ControlSource>,
  controlSourceEquals: (a: ControlSource, b: ControlSource) => boolean
} {
  const controlSources: ControlSource[] = [];
  controlSources.push({ type: "entry" });
  for (const n of nodesPhi) controlSources.push({ type: "phi", node: n });
  for (const n of nodesProc) for (const f in (procs[n.procID] || { outputFlows: {} }).outputFlows) controlSources.push({ type: "proc", node: n, flow: f });
  const controlSourceEquals = (a: ControlSource, b: ControlSource): boolean => {
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

export function getControlSinks(g: Graph, procs: ProcDefinitions, nodesPhi: Iterable<NodePhi>, nodesProc: Iterable<NodeProc>): {
  controlSinks: ReadonlyArray<ControlSink>,
  controlSinkEquals: (a: ControlSink, b: ControlSink) => boolean
} {
  const controlSinks: ControlSink[] = [];
  for (const f in g.outputFlows) controlSinks.push({ type: "output", flow: f });
  for (const n of nodesPhi) for (const m of Object.values(n.merge)) if (m !== undefined) for (const f in m.sources) controlSinks.push({ type: "phi", node: n, flow: f });
  for (const n of nodesProc) controlSinks.push({ type: "proc", node: n });
  const controlSinkEquals = (a: ControlSink, b: ControlSink): boolean => {
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

export function getSymbolSources(g: Graph, procs: ProcDefinitions, controlSources: Iterable<ControlSource>, controlSourceEquals: (a: ControlSource, b: ControlSource) => boolean): {
  symbolSources: ReadonlyArray<SymbolSource>,
  symbolSourceEquals: (a: SymbolSource, b: SymbolSource) => boolean
} {
  const symbolSources: SymbolSource[] = [];
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
  const symbolSourceEquals = (a: SymbolSource, b: SymbolSource): boolean => controlSourceEquals(a.origin, b.origin) && a.id === b.id;
  return { symbolSources, symbolSourceEquals };
}

export function getSymbolSinks(g: Graph, procs: ProcDefinitions, controlSinks: Iterable<ControlSink>, controlSinkEquals: (a: ControlSink, b: ControlSink) => boolean): {
  symbolSinks: ReadonlyArray<SymbolSink>,
  symbolSinkEquals: (a: SymbolSink, b: SymbolSink) => boolean
} {
  const symbolSinks: SymbolSink[] = [];
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
  const symbolSinkEquals = (a: SymbolSink, b: SymbolSink): boolean => controlSinkEquals(a.target, b.target) && a.id === b.id;
  return { symbolSinks, symbolSinkEquals };
}

export function getSymbolMapper(g: Graph, procs: ProcDefinitions, symbolSources: ReadonlyArray<SymbolSource>, symbolSourceNorm: (a: SymbolSource) => SymbolSource | undefined):
  (src: SymbolSource) => SymbolInstance | undefined {
  interface SymbolInstanceMutable {
    source: SymbolSource;
    type: Type;
    names: Array<string>;
  }

  const symbols = new Map<SymbolSource, SymbolInstanceMutable>();
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
  const getSymbol = (src: SymbolSource): SymbolInstanceMutable | undefined => {
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
      // type
      if (transfer.transferType) {
        const type = transfer.source.type;
        const newType = typeUnion(transfer.target.type, type);
        if (!typeEquals(transfer.target.type, newType)) {
          transfer.target.type = newType;
          redo = true;
        }
      }
    }
  }

  return getSymbol;
}

export function nodeSource2Sinks(x: ControlSource, controlSinks: ReadonlyArray<ControlSink>): ReadonlyArray<ControlSink> {
  switch (x.type) {
    case "entry": return [];
    case "phi": return controlSinks.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSinks.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}
export function nodeSource2Sources(x: ControlSource, controlSources: ReadonlyArray<ControlSource>): ReadonlyArray<ControlSource> {
  switch (x.type) {
    case "entry": return controlSources.filter(y => y.type === "entry");
    case "phi": return controlSources.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSources.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}
export function nodeSink2Sinks(x: ControlSink, controlSinks: ReadonlyArray<ControlSink>): ReadonlyArray<ControlSink> {
  switch (x.type) {
    case "output": return controlSinks.filter(y => y.type === "output");
    case "phi": return controlSinks.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSinks.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}
export function nodeSink2Sources(x: ControlSink, controlSources: ReadonlyArray<ControlSource>): ReadonlyArray<ControlSource> {
  switch (x.type) {
    case "output": return [];
    case "phi": return controlSources.filter(y => y.type === "phi" && y.node === x.node);
    case "proc": return controlSources.filter(y => y.type === "proc" && y.node === x.node);
    default: return errorUnreachable();
  }
}

export function getSymbolSourceType(graph: Graph, procs: ProcDefinitions, src: SymbolSource): Type | undefined {
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
export function getSymbolSinkType(graph: Graph, procs: ProcDefinitions, symbolSink: SymbolSink): Type | undefined {
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
export function getSymbolSourceKnownNames(graph: Graph, procs: ProcDefinitions, src: SymbolSource): ReadonlyArray<string> {
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
export function getSymbolSinkKnownNames(graph: Graph, procs: ProcDefinitions, symbolSink: SymbolSink): ReadonlyArray<string> {
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

export function getSymbolSourceOf(graph: Graph, procs: ProcDefinitions, symbolSink: SymbolSink): SymbolSource | undefined {
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

export function getMarket(
  g: Graph,
  flows: ReadonlyArray<ControlFlow>,
  controlSources: ReadonlyArray<ControlSource>,
  controlSinks: ReadonlyArray<ControlSink>,
  symbolSources: ReadonlyArray<SymbolSource>,
  controlSourceNorm: (a: ControlSource) => ControlSource | undefined,
  controlSinkNorm: (a: ControlSink) => ControlSink | undefined,
  _getSymbol: (src: SymbolSource) => SymbolInstance | undefined): { supply: ReadonlyMap<ControlSource, ReadonlySet<SymbolInstance>>, demand: ReadonlyMap<ControlSink, ReadonlySet<SymbolInstance>> } {

  const getSymbol = (src: SymbolSource | undefined): SymbolInstance | undefined => src === undefined ? undefined : _getSymbol(src);

  // adjacency
  const flowOut = new Map<ControlSource, ControlFlow>();
  const flowIn = new Map<ControlSink, ControlFlow>();
  for (const f of flows) {
    flowOut.set(f.source, f);
    flowIn.set(f.target, f);
  }

  // propagate available symbols through flow (forward)
  const supply = new Map<ControlSource, Set<SymbolInstance>>(controlSources.map<[ControlSource, Set<SymbolInstance>]>(x => [x, new Set<SymbolInstance>()]));
  for (const src of symbolSources) {
    // - init
    const conditions = new Map<ControlSource, Set<ControlFlow>>();
    conditions.set(src.origin, new Set<ControlFlow>());
    const updated = new Set<ControlSource>();
    updated.add(src.origin);

    // - propagate (fixed-point iteration; need to detect self-sustaining cycles involving phi!)
    while (updated.size > 0) {
      const update = updated.values().next().value;
      updated.delete(update);
      const flow = flowOut.get(update);
      if (flow !== undefined) {
        const sink = flow.target;
        // -- collect influx conditions
        const conditionsToProceed = new Set<ControlFlow>();
        for (const influx of nodeSink2Sinks(sink, controlSinks).map(x => flowIn.get(x)).filter(x => x) as any) {
          const influxConditions = conditions.get(influx.source);
          if (influxConditions) for (const x of influxConditions) conditionsToProceed.add(x);
          else conditionsToProceed.add(influx);
        }

        // -- propagate conditions
        for (const outflux of nodeSink2Sources(sink, controlSources).map(x => flowOut.get(x)).filter(x => x) as any) {
          const newCond = new Set<ControlFlow>(conditionsToProceed);
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
  const demand = new Map<ControlSink, Set<SymbolInstance>>(controlSinks.map<[ControlSink, Set<SymbolInstance>]>(x => [x, new Set<SymbolInstance>()]));
  const updated = new Set<ControlSink>();
  for (const ds of controlSinks) {
    const markRequired = (sym: SymbolInstance | undefined) => {
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
          const set = demand.get(predFlow) || new Set<SymbolInstance>();
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
