import { ControlSink, SymbolSource } from './graph';
import { nodeSink2Sources } from './graph-analysis';
import { GraphContext, Proc, SymbolInstance } from './graph-context';
import { error, errorUnreachable, lundef, objMap, setIntersect } from './helpers';
import { JSONValue } from './json';

export enum GenerationFlavor { ContInlineProc, ContInlineProcAsync }

export interface ProcImplementation {
  defInline(args: { [id: string]: string }, cb: { [flow: string]: (args: { [id: string]: string }) => string }): string;
}
export interface ProcImplementations { readonly [id: string]: ProcImplementation | undefined }

export function generateTS<TType>(ga: GraphContext<TType>, procs: ProcImplementations, typeToTS: (type: TType) => string, flavor: GenerationFlavor = GenerationFlavor.ContInlineProc): string {

  const getSymbol = (x: SymbolSource<TType> | undefined) => x && ga.getSymbolFromSource(x);
  const controlSinks = ga.controlSinks;
  const controlSources = ga.controlSources;
  const flows = ga.controlFlow;
  const nodesPhi = ga.nodesPhi;
  const nodesProc = ga.nodesProc;

  const isAsync = flavor === GenerationFlavor.ContInlineProcAsync;
  const asyncModifier = isAsync ? 'async ' : '';
  const asyncVoid = isAsync ? 'Promise<void>' : 'void';

  const def = (impl: ProcImplementation, proc: Proc<TType>, args: { [id: string]: string }, cb: { [id: string]: string }) => {
    const cbx: { [flow: string]: (args: { [id: string]: string }) => string } = {};
    for (const flow in cb) {
      cbx[flow] = args => `${cb[flow]}(${Object.keys(proc.inputs).map(x => args[x]).join(', ')})`;
    }
    return impl.defInline(args, cbx);
  };

  // TS emit
  const tsValue = (x: JSONValue): string => JSON.stringify(x);

  const tsProcArgType = (p: { readonly [id: string]: { type: TType } | undefined }): string => `{ ${Object.entries(p).filter(x => x[1] !== undefined).map(x => `${x[0]}: ${typeToTS((x[1] || errorUnreachable()).type)}`).join(', ')} }`;
  const tsProcArgCbType = (p: Proc<TType>): string => `{ ${Object.entries(p.outputFlows).filter(x => x[1] !== undefined).map(x => `${x[0]}: (args: ${tsProcArgType(x[1] || errorUnreachable())}) => ${asyncVoid}`).join(', ')} }`;
  const tsProcArgs = (p: Proc<TType>): { [id: string]: string } => objMap(x => x, p.inputs);
  const tsProcArgsCb = (p: Proc<TType>): { [id: string]: string } => objMap(x => x, p.outputFlows);

  const result: Array<string> = [];
  result.push(`${asyncModifier}function (args: ${tsProcArgType(ga.getGraphProc().inputs)}, cbs: ${tsProcArgCbType(ga.getGraphProc())}): ${asyncVoid} {`);
  for (const x of Object.entries(ga.graph.inputs)) {
    const v = x[1];
    if (v !== undefined) { result.push(`  const ${x[0]}: ${typeToTS(v.type)} = ${v.value !== undefined ? tsValue(v.value) : `args.${x[0]}`};`); }
  }
  // prepare signatures for all data sinks
  interface ControlSinkSig { id: string, symbols: { id: string, type: TType, symbol: Set<SymbolInstance<TType>> }[] }
  const sinkSignatures = new Map<ControlSink<TType>, ControlSinkSig>();
  for (const sink of controlSinks) {
    if (sinkSignatures.has(sink)) { continue; }
    const symbols: Array<{ id: string, type: TType, symbol: Set<SymbolInstance<TType>> }> = [];
    if (sink.type === 'phi') {
      const source = ga.nodeSink2Sources(sink)[0];
      const merge = sink.node.merge;
      for (const id of Object.keys(merge)) {
        const outSym = [...ga.getSupply(source)].find(s => s.source.origin === source && s.source.id === id) || errorUnreachable();
        symbols.push({ id, type: outSym.type, symbol: new Set<SymbolInstance<TType>>(sink.node.flows.map(flow => ga.edgeSymbolSink2Source({ id, target: { type: 'phi', flow, node: sink.node } })).map(getSymbol).filter(x => x) as any).add(outSym) });
      }
    }
    for (const symbol of ga.getDemand(sink)) {
      if (symbols.some(x => x.symbol.has(symbol))) { continue; }
      let id = (sink.type === 'output' ? lundef(ga.dataFlow.find(x => x.target.target === sink && getSymbol(x.source) === symbol), _ => _.target.id) : undefined) || symbol.source.id;
      for (const name of symbol.names) {
        if (!symbols.some(s => s.id === id)) { break; }
        id = name;
      }
      if (symbols.some(s => s.id === id)) {
        id = symbol.source.id;
        while (symbols.some(s => s.id === id)) { id = "_" + id; }
      }
      symbols.push({ id, symbol: new Set<SymbolInstance<TType>>([symbol]), type: symbol.type });
    }

    let id: string;
    switch (sink.type) {
      case 'output':
        id = 'cbs.' + sink.flow;
        break;
      case 'phi': {
        let i = 0;
        while ([...sinkSignatures.values()].some(x => x.id === `phi${i}`)) { ++i; }
        id = `phi${i}`;
      }
        break;
      case 'proc': {
        let i = 0;
        const procName = sink.node.procID;
        while ([...sinkSignatures.values()].some(x => x.id === `${procName}${i}`)) { ++i; }
        id = `${procName}${i}`;
      }
        break;
      default:
        return errorUnreachable();
    }
    for (const s of ga.nodeSink2Sinks(sink)) {
      sinkSignatures.set(s, { id, symbols });
    }
  }
  for (const n of nodesPhi) {
    const sink = controlSinks.find(x => x.type === 'phi' && x.node === n) || errorUnreachable();
    const sig = sinkSignatures.get(sink) || errorUnreachable();
    const target = ga.edgeSource2Sink(ga.nodeSink2Sources(sink)[0]);
    const targetSig = target && sinkSignatures.get(target) || <ControlSinkSig>{ id: '/* ? */', symbols: [] };
    const getSymbolId = (sym: Set<SymbolInstance<TType>>): string => 'args.' + ([...sym].map(x => sig.symbols.find(y => y.symbol.has(x))).filter(x => x !== undefined)[0] || { id: '/**/' }).id;
    result.push(`  const ${sig.id} = ${asyncModifier}(args: { ${sig.symbols.map(x => `${x.id}: ${typeToTS(x.type)}`).join(', ')} }): ${asyncVoid} => ${targetSig.id}({ ${targetSig.symbols.map(x => `${x.id}: ${getSymbolId(x.symbol)}`).join(', ')} });`);
  }
  for (const n of nodesProc) {
    const sink = controlSinks.find(x => x.type === 'proc' && x.node === n) || errorUnreachable();
    const sig = sinkSignatures.get(sink) || errorUnreachable();
    const getSymbolId = (sym: Iterable<SymbolInstance<TType>>): string => 'args.' + ([...sym].map(x => sig.symbols.find(y => y.symbol.has(x))).filter(x => x !== undefined)[0] || { id: '/**/' }).id;
    const proc = ga.procs[n.procID];
    const procDef = procs[n.procID];
    if (proc === undefined || procDef === undefined) {
      result.push(`  const ${sig.id} = ${asyncModifier}(${sig.symbols.map(x => `${x.id}: ${typeToTS(x.type)}`).join(', ')}): ${asyncVoid} => /**/;`);
      continue;
    }
    const getInput = (arg: string): SymbolSource<TType> | undefined => ga.edgeSymbolSink2Source({ id: arg, target: { type: 'proc', node: n } });
    const argsInline1: { [id: string]: string } = objMap(x => getInput(x) === undefined ? `/* ${x} */` : getSymbolId(lundef(getInput(x), x => lundef(ga.getSymbolFromSource(x), x => [x])) || []), proc.inputs);
    const argsInline2: { [id: string]: (args: { [id: string]: string }) => string } = {};
    for (const x of Object.entries(proc.outputFlows)) {
      const v = x[1]; if (v === undefined) { continue; }
      const introArgs = Object.entries(v).map(y => getSymbol({ id: y[0], origin: { node: n, type: 'proc', flow: x[0] } }));
      const getSymbolIdX = (sym: Iterable<SymbolInstance<TType>>, args: { [id: string]: string }): string => {
        const introArg = introArgs.find(x => !!x && [...sym].includes(x));
        if (introArg !== undefined) {
          return args[introArg.source.id];
        } else {
          return getSymbolId(sym);
        }
      };
      const flow = flows.find(f => f.source.type === 'proc' && f.source.node === n && f.source.flow === x[0]);
      if (flow === undefined) {
        argsInline2[x[0]] = args => `/* ${x[0]} */`;
        continue;
      }
      const targetSig = sinkSignatures.get(flow.target) || errorUnreachable();
      argsInline2[x[0]] = args => `${targetSig.id}({ ${targetSig.symbols.map(x => `${x.id}: ${getSymbolIdX(x.symbol, args)}`).join(', ')} })`;
    }
    // if (flavor === Flavor.ContFull)
    //   result.push(`  const ${sig.id} = ${asyncModifier}(${sig.symbols.map(x => `${x.id}: ${tsType(x.type)}`).join(', ')}): ${asyncVoid} => ${proc.name}(${args.join(', ')});`);
    // else
    result.push(`  const ${sig.id} = ${asyncModifier}(args: { ${sig.symbols.map(x => `${x.id}: ${typeToTS(x.type)}`).join(', ')} }): ${asyncVoid} => ${procDef.defInline(argsInline1, argsInline2)};`);
  }

  const initialFlow = flows.find(x => x.source.type === 'entry');
  if (initialFlow !== undefined) {
    const targetSig = sinkSignatures.get(initialFlow.target) || errorUnreachable();
    const syms = ga.symbols.filter(x => x.source.origin.type === 'entry');
    const getSymbolId = (sym: Iterable<SymbolInstance<TType>>): string => lundef([...setIntersect(syms, sym)][0], x => x.source.id) || '/**/';
    result.push(`  ${isAsync ? 'return ' : ''}${targetSig.id}({ ${targetSig.symbols.map(x => `${x.id}: ${getSymbolId(x.symbol)}`).join(', ')} });`);
  }

  result.push('}');
  return `(() => ${result.join('\n')})()`;
}

// experimental (mutable state rather than parameters)
export function generateTS2<TType>(ga: GraphContext<TType>, procs: ProcImplementations, typeToTS: (type: TType) => string, flavor: GenerationFlavor = GenerationFlavor.ContInlineProc): string {

  const getSymbol = (x: SymbolSource<TType> | undefined) => x && ga.getSymbolFromSource(x);
  const controlSinks = ga.controlSinks;
  const controlSources = ga.controlSources;
  const flows = ga.controlFlow;
  const nodesPhi = ga.nodesPhi;
  const nodesProc = ga.nodesProc;

  const isAsync = flavor === GenerationFlavor.ContInlineProcAsync;
  const asyncModifier = isAsync ? 'async ' : '';
  const asyncVoid = isAsync ? 'Promise<void>' : 'void';

  const def = (impl: ProcImplementation, proc: Proc<TType>, args: { [id: string]: string }, cb: { [id: string]: string }) => {
    const cbx: { [flow: string]: (args: { [id: string]: string }) => string } = {};
    for (const flow in cb) {
      cbx[flow] = args => `${cb[flow]}(${Object.keys(proc.inputs).map(x => args[x]).join(', ')})`;
    }
    return impl.defInline(args, cbx);
  };

  // TS emit
  const tsValue = (x: JSONValue): string => JSON.stringify(x);

  const tsProcArgType = (p: { readonly [id: string]: { type: TType } | undefined }): string => `{ ${Object.entries(p).filter(x => x[1] !== undefined).map(x => `${x[0]}: ${typeToTS((x[1] || errorUnreachable()).type)}`).join(', ')} }`;
  const tsProcArgCbType = (p: Proc<TType>): string => `{ ${Object.entries(p.outputFlows).filter(x => x[1] !== undefined).map(x => `${x[0]}: (args: ${tsProcArgType(x[1] || errorUnreachable())}) => ${asyncVoid}`).join(', ')} }`;
  const tsProcArgs = (p: Proc<TType>): { [id: string]: string } => objMap(x => x, p.inputs);
  const tsProcArgsCb = (p: Proc<TType>): { [id: string]: string } => objMap(x => x, p.outputFlows);

  const getUniqueSymbolName = ((): ((symbol: SymbolInstance<TType>) => string) => {
    const names = new Map<SymbolInstance<TType>, string>();
    return (symbol: SymbolInstance<TType>): string => {
      const exists = new Set(names.values());
      if (!names.has(symbol)) {
        let id = symbol.source.id;
        for (const name of symbol.names) {
          if (!exists.has(id)) { break; }
          id = name;
        }
        if (exists.has(id)) {
          id = symbol.source.id;
          while (exists.has(id)) { id = "_" + id; }
        }
        names.set(symbol, id);
      }
      return names.get(symbol) || errorUnreachable();
    };
  })();

  const result: Array<string> = [];
  result.push(`${asyncModifier}function (args: ${tsProcArgType(ga.getGraphProc().inputs)}, cbs: ${tsProcArgCbType(ga.getGraphProc())}): ${asyncVoid} {`);

  for (const symbol of ga.symbols) {
    const init = symbol.source.origin.type === 'entry' && lundef(ga.graph.inputs[symbol.source.id], v => ' = ' + (v.value !== undefined ? tsValue(v.value) : `args.${symbol.source.id}`)) || undefined;
    result.push(`  let ${getUniqueSymbolName(symbol)}: ${typeToTS(symbol.type)}${init || ''};${symbol.names.length === 0 ? '' : ' // ' + symbol.names.join(', ')}`);
  }

  // prepare signatures for all data sinks
  const sinkSignatures = new Map<ControlSink<TType>, { func: string, call: string }>();
  for (const sink of ga.controlSinks) {
    const fl = ga.dataFlow.filter(x => x.target.target === sink);
    switch (sink.type) {
      case 'output':
        sinkSignatures.set(sink, { func: `output_${sink.flow}`, call: `output_${sink.flow}();` });
        break;
      case 'proc':
        let i = 0;
        const procName = sink.node.procID;
        while ([...sinkSignatures.values()].some(x => x.func === `${procName}${i}`)) { ++i; }
        sinkSignatures.set(sink, { func: `${procName}${i}`, call: `${procName}${i}();` });
        break;
      case 'phi':
        const out = ga.nodeSink2Sources(sink)[0] || errorUnreachable();
        let j = 0;
        while ([...sinkSignatures.values()].some(x => x.func === `phi${j}`)) { ++j; }
        sinkSignatures.set(sink, { func: `phi${j}`, call: `${fl.map(x => `${lundef(getSymbol({ id: x.target.id, origin: out }), getUniqueSymbolName) || '/**/'} = ${lundef(getSymbol(x.source), getUniqueSymbolName)}; `).join('')}phi${j}();` });
        break;
    }
  }

  for (const sink of ga.controlSinks) {
    const name = lundef(sinkSignatures.get(sink), _ => _.func) || '/**/';
    const fl = ga.dataFlow.filter(x => x.target.target === sink);
    switch (sink.type) {
      case 'output':
        result.push(`  const ${name} = ${asyncModifier}(): ${asyncVoid} => cbs.${sink.flow}({ ${fl.map(x => `${x.target.id}: ${lundef(getSymbol(x.source), getUniqueSymbolName) || '/**/'}`)} });`);
        break;
      case 'phi':
        const node = sink.node;
        const out = ga.nodeSink2Sources(sink)[0] || errorUnreachable();
        const flow = flows.find(f => f.source === out);
        const targetSig = flow && sinkSignatures.get(flow.target) || errorUnreachable() || '/**/';
        result.push(`  const ${name} = ${asyncModifier}(): ${asyncVoid} => { ${targetSig.call} };`);
        break;
      case 'proc':
        const procDef = procs[sink.node.procID];
        if (procDef === undefined) {
          result.push(`  const ${name} = ${asyncModifier}(): ${asyncVoid} => /**/;`);
          continue;
        }

        const argsInline1: { [id: string]: string } = {};
        for (const x of fl) { argsInline1[x.target.id] = lundef(getSymbol(x.source), getUniqueSymbolName) || "/**/"; }
        const argsInline2: { [id: string]: (args: { [id: string]: string }) => string } = {};
        for (const src of ga.nodeSink2Sources(sink)) {
          if (src.type !== 'proc') { return errorUnreachable(); }
          const introArgs = ga.symbols.filter(x => x.source.origin === src);
          const flow = flows.find(f => f.source === src);
          if (flow === undefined) {
            argsInline2[src.flow] = args => `/* ${src.flow} */`;
            continue;
          }
          const targetSig = sinkSignatures.get(flow.target) || errorUnreachable();
          argsInline2[src.flow] = args => `(() => { ${introArgs.map(x => `${getUniqueSymbolName(x)} = ${args[x.source.id]}; `).join('')}${targetSig.call} })()`;
        }

        result.push(`  const ${name} = ${asyncModifier}(): ${asyncVoid} => ${procDef.defInline(argsInline1, argsInline2)};`);
        break;
    }
  }

  const initialFlow = flows.find(x => x.source.type === 'entry');
  if (initialFlow !== undefined) {
    result.push(`  ${isAsync ? 'return ' : ''}(() => { ${lundef(sinkSignatures.get(initialFlow.target), _ => _.call) || '/**/'} })();`);
  }

  result.push('}');
  return `(() => ${result.join('\n')})()`;
}
