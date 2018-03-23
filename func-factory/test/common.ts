import { ProcImplementations } from "../src/reference-generator";
import { ProcDefinitions, Proc, FlexArgs, GraphContext, FlexCallbacks } from "../src/graph-context";
import { Type, typeNominal } from "../src/type";
import { DeepMutable, objMap } from "../src/helpers";
import { Graph } from "../src/graph";

export const typeNumber: Type = typeNominal("number");
export const typeBoolean: Type = typeNominal("boolean");
export const typeString: Type = typeNominal("string");

const builtInDefs: ProcDefinitions = {};
const builtInImpls: ProcImplementations = {};

const addBuiltIn = (name: string, defInline: (args: { [id: string]: string }, cb: { [flow: string]: (args: { [id: string]: string }) => string }) => string, proc: Proc) => {
  (builtInImpls as any)[name] = { defInline: defInline };
  (builtInDefs as { [id: string]: Proc | undefined })[name] = proc;
};


export function getBuiltInDefs(): ProcDefinitions { return builtInDefs; }
export function getBuiltInImpls(): ProcImplementations { return builtInImpls; }

// number comparison
addBuiltIn("lt", (args, cb) => cb.result({ res: `(${args.a} < ${args.b})` }), {
  pure: true,
  inputs: {
    a: { names: [], type: typeNumber },
    b: { names: [], type: typeNumber }
  },
  outputFlows: {
    result: {
      res: { names: [], nameSources: [], type: typeBoolean }
    }
  }
});
addBuiltIn("eq", (args, cb) => cb.result({ res: `(${args.a} === ${args.b})` }), {
  pure: true,
  inputs: {
    a: { names: [], type: typeNumber },
    b: { names: [], type: typeNumber }
  },
  outputFlows: {
    result: {
      res: { names: [], nameSources: [], type: typeBoolean }
    }
  }
});

// branching
addBuiltIn("if", (args, cb) => `(${args.condition} ? ${cb.true({})} : ${cb.false({})})`, {
  pure: true,
  inputs: {
    condition: { names: [], type: typeBoolean }
  },
  outputFlows: {
    true: {},
    false: {}
  }
});

// number ops
addBuiltIn("add", (args, cb) => cb.result({ res: `(${args.a} + ${args.b})` }), {
  pure: true,
  inputs: {
    a: { names: [], type: typeNumber },
    b: { names: [], type: typeNumber }
  },
  outputFlows: {
    result: {
      res: { names: [], nameSources: [], type: typeNumber }
    }
  }
});

// string ops
addBuiltIn("strlen", (args, cb) => cb.result({ length: `${args.s}.length` }), {
  pure: true,
  inputs: {
    s: { names: [], type: typeString }
  },
  outputFlows: {
    result: {
      length: { names: ["length"], nameSources: [], type: typeNumber }
    }
  }
});
addBuiltIn("lt-res=>condition-if1", (args, cb) => `${args.a} < ${args.b} ? ${cb.true({})} : ${cb.false({})}`, {
  pure: true,
  inputs: {
    a: { names: [], type: typeNumber },
    b: { names: [], type: typeNumber }
  },
  outputFlows: {
    true: {
      res: { names: [], nameSources: [], type: typeBoolean }
    },
    false: {
      res: { names: [], nameSources: [], type: typeBoolean }
    }
  }
});





// run
export function runGraph(graph: Graph, args: FlexArgs, expectedCb: string, subExpression: string = ""): any {
  const context = new GraphContext(graph, getBuiltInDefs());
  const func = context.build(getBuiltInImpls());
  const cps: FlexCallbacks = objMap(id => (x: FlexArgs) => { throw `unexpected result flow ${id}`; }, graph.outputFlows);
  let res: any;
  let resAssigned = false;
  cps[expectedCb] = x => { res = x; resAssigned = true };
  func(args, cps);
  if (!resAssigned) throw `expected result flow ${expectedCb} not called`;
  return eval("res" + subExpression);
}