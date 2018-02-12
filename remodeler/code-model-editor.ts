import * as CodeModel from "./code-model"
import { Reference, Dictionary, Dereferenced } from "./common";

export class CodeModelEditor {
  constructor(private model: CodeModel.Model) {

  }

  add<TSource, TDestination>(name: string, original: Dereferenced<TSource>, target: Dictionary<Reference<TDestination>>, copyFunc: (name: string, source: TSource) => TDestination, newAlias: (a: any) => TDestination): TDestination {
    // is this an alias to another model?
    if (original.name) {
      // Yes, ensure the target is in the new model
      // (the assumption being that the target is the right instance if it is there with the expected name.)
      const actual = target[original.name] || this.add(original.name, { instance: original.instance }, target, copyFunc, newAlias);

      // create an alias to the actual instance 
      return this.safeAdd(target, name, newAlias({ extensions: { aliasTo: actual } }));
    }

    // copy it over and add it to the model
    return this.safeAdd(target, name, copyFunc(name, original.instance));
  }

  private safeAdd<T>(target: Dictionary<Reference<T>>, name: string, item: T): T {

    if (target[name] && target[name].$ref !== item) {
      // if the <T> is already in the collection of <T>, and it's not this instance...
      throw new Error(`${name} exists in model.`);
    }

    // add it.
    target[name] = new Reference(item);
    return item;
  }

  addSchema(name: string, schema: CodeModel.Schema): CodeModel.Schema {
    const m = this.model;
    const schemas = m.components.schemas;
    if (schemas[name] && schemas[name].$ref !== schema) {
      // if the schema is already in the collection of schemas, and it's not this instance...
      throw new Error(`schema ${name} exists in model.`);
    }

    // add it.
    schemas[name] = new Reference(schema);
    return schema;
  }
}