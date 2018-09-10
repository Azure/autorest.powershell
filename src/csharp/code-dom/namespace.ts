/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Initializer } from '#common/initializer';
import { comment, dotCombine, EOL, indent, toMap } from '#common/text-manipulation';
import { Class } from './class';
import { Delegate } from './delegate';
import { ImportDirective } from './import';
import { Interface } from './interface';
import { Project } from './project';

export class Namespace extends Initializer {
  private usings = new Array<ImportDirective>();
  private classes = new Array<Class>();
  private interfaces = new Array<Interface>();
  private delegates = new Array<Delegate>();
  private namespaces = new Array<Namespace>();
  private folder: string;
  public header: string = '';

  constructor(public name: string, protected parent?: Project | Namespace, objectInitializer?: Partial<Namespace>) {
    super();
    this.folder = this.fullName.replace(/\./g, '/');
    this.apply(objectInitializer);
  }

  public get outputFolder(): string {
    return this.folder;
  }

  private addImport(using: ImportDirective): ImportDirective {
    if (this.usings.indexOf(using) === -1) {
      this.usings.push(using);
    }
    return using;
  }
  public addClass(c: Class): Class {
    if (this.classes.indexOf(c) === -1) {
      if (this.classes.find(each => each.name === c.name && each.fileName === c.fileName)) {
        console.error(`Class ${c.name} already exists in namespace${this.name}`);
        throw new Error(`Class ${c.name} already exists in namespace${this.name}`);
      }
      this.classes.push(c);
    }
    return c;
  }
  public addInterface(i: Interface): Interface {
    if (this.interfaces.indexOf(i) === -1) {
      this.interfaces.push(i);
    }
    return i;
  }
  public addDelegate(delegate: Delegate): Delegate {
    if (this.delegates.indexOf(delegate) === -1) {
      this.delegates.push(delegate);
    }
    return delegate;
  }
  public addNamespace(n: Namespace): Namespace {
    if (this.namespaces.indexOf(n) === -1) {
      this.namespaces.push(n);
    }
    return n;
  }

  public add<T extends object>(item: T & (Class | Namespace | Interface | ImportDirective)): T {
    if (item instanceof Class) {
      this.addClass(item);
      return item;
    }
    if (item instanceof Namespace) {
      this.addNamespace(item);
      return item;
    }
    if (item instanceof Interface) {
      this.addInterface(item);
      return item;
    }
    if (item instanceof ImportDirective) {
      this.addImport(item);
      return item;
    }
    throw Error(`FATAL - UNABLE TO ADD UNKNOWN TYPE for '${JSON.stringify(item)}'`);
  }

  public findClassByName(name: string): Array<Class> {
    return this.classes.filter(each => each.name === name);
  }

  public get fullName(): string {
    if (this.parent instanceof Namespace) {
      return dotCombine(this.parent.fullName, this.name);
    }
    return this.name;
  }

  public toString(): string {
    return this.fullName;
  }

  public async writeFiles(writer: (filename: string, content: string) => Promise<void>) {
    // write out all the files

    // handle nested namespaces
    const children = this.namespaces.map(async namespace => namespace.writeFiles(writer));

    // combine class (XYZ) and interfaces (IXYZ) together in a single file
    const classes = toMap(this.classes, c => c.fileName);
    const interfaces = toMap(this.interfaces, i => i.fileName);

    for (const [key, classesWithSameName] of classes) {
      const contents = classesWithSameName.map(each => each.definition);
      const interfaceName = `I${key}`;
      const interfacesWithSameName = interfaces.get(interfaceName);
      if (interfacesWithSameName) {
        contents.push(...interfacesWithSameName.map(each => each.definition));
        // remove from the list.
        interfaces.delete(interfaceName);
      }
      await writer(`${this.outputFolder}/${key}.cs`, this.render(contents.join(EOL)));
    }

    for (const [key, interfacesWithSameName] of interfaces) {
      const contents = interfacesWithSameName.map(each => each.definition);
      await writer(`${this.outputFolder}/${key}.cs`, this.render(contents.join(EOL)));
    }

    // do the delegates in a single file
    const delegates = this.delegates.map(v => v.implementation).join(EOL);
    if (delegates) {
      await writer(`${this.outputFolder}/delegates.cs`, this.render(delegates));
    }

    // wait for children to finish.
    await (Promise.all(children));
  }

  protected render(content: string) {
    // all files get the header comment
    const header = comment(this.header);

    // all files get imports
    const imports = indent(this.usings.map((v) => v.implementation).join(EOL), 1);
    const body = indent(content, 1);

    return `
${header}

namespace ${this.fullName}
{
${imports}

${body}
}
`.trim().replace(/ *$/gm, '').replace(/\n\n/g, '\n').replace(/^\s*EOL\s*$/igm, '');
  }
}
