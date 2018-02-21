import * as CodeModel from "./code-model"
import { Dictionary, Dereferenced } from "./common";

export class CodeModelEditor {
  constructor(private model: CodeModel.Model) {

  }

  add<TSource, TDestination>(name: string, original: Dereferenced<TSource>, target: Dictionary<TDestination>, copyFunc: (name: string, source: TSource) => TDestination, newAlias: (a: any) => TDestination): TDestination {
    // is this an alias to another model?
    if (original.name) {
      // console.error(`adding something with a name: ${name},${original.name}`);
      // Yes, ensure the target is in the new model
      // (the assumption being that the target is the right instance if it is there with the expected name.)

      if (target[original.name]) {
        // the target model is already added to this return it as the instance.
        return this.safeAdd(target, name, target[original.name]);
      }

      // otherwise, create the referenced type, and then add it again with our name,
      const actual = this.add(original.name, { instance: original.instance }, target, copyFunc, newAlias);
      return this.safeAdd(target, name, actual);
    }

    // copy it over and add it to the model
    return this.safeAdd(target, name, copyFunc(name, original.instance));
  }

  private safeAdd<T>(target: Dictionary<T>, name: string, item: T): T {

    if (target[name] && target[name] !== item) {
      // if the <T> is already in the collection of <T>, and it's not this instance...
      //   throw new Error(`${name} exists in model.`);
      console.error(`${name} exists in model.`);
      item = target[name];
      return item;
    }

    // add it.
    target[name] = item;
    return item;
  }

}