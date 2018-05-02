import { Initializer } from '#common/initializer';
import { EOL, comment, dotCombine, indent, toMap } from '#common/text-manipulation';
import { Class } from './class';
import { Delegate } from './delegate';
import { Import } from './import';
import { Interface } from './interface';
import { Project } from './project';

export class Namespace extends Initializer {
  private usings = new Array<Import>();
  private classes = new Array<Class>();
  private interfaces = new Array<Interface>();
  private delegates = new Array<Delegate>();
  private namespaces = new Array<Namespace>();
  public header: string = "";

  constructor(public name: string, protected parent?: Project | Namespace, objectInitializer?: Partial<Namespace>) {
    super();
    this.apply(objectInitializer);
  }

  public addUsing(using: Import): Import {
    if (this.usings.indexOf(using) === -1) {
      this.usings.push(using);
    }
    return using;
  }
  public addClass(c: Class): Class {
    if (this.classes.indexOf(c) === -1) {
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


  public findClassByName(name: string): Class[] {
    return this.classes.filter(each => each.name === name);
  }


  public get fullName(): string {
    if (this.parent instanceof Namespace) {
      return dotCombine(this.parent.fullName, this.name);
    }
    return this.name;
  }

  public async writeFiles(writer: (filename: string, content: string) => Promise<void>) {
    const basePath = this.fullName.replace(/\./g, '/');

    // write out all the files

    // handle nested namespaces
    const children = this.namespaces.map(namespace => namespace.writeFiles(writer));

    // combine class (XYZ) and interfaces (IXYZ) together in a single file
    const classes = toMap(this.classes, c => c.name);
    const interfaces = toMap(this.interfaces, i => i.name);

    for (const [key, classesWithSameName] of classes) {
      const contents = classesWithSameName.map(each => each.implementation);
      const interfaceName = `I${key}`;
      const interfacesWithSameName = interfaces.get(interfaceName);
      if (interfacesWithSameName) {
        contents.push(...interfacesWithSameName.map(each => each.implementation))
        // remove from the list.
        interfaces.delete(interfaceName);
      }
      await writer(`${basePath}/${key}.cs`, this.render(contents.join(EOL)));
    }

    for (const [key, interfacesWithSameName] of interfaces) {
      const contents = interfacesWithSameName.map(each => each.implementation);
      await writer(`${basePath}/${key}.cs`, this.render(contents.join(EOL)));
    }

    // do the delegates in a single file
    const delegates = this.delegates.map(v => v.implementation).join(EOL);
    if (delegates) {
      await writer(`${basePath}/delegates.cs`, this.render(delegates));
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

