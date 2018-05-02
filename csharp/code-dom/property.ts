import { Initializer } from '#common/initializer';
import { Abstract, Access, Extern, Modifier, New, Override, Sealed, Static, Virtual, highestAccess } from '#csharp/code-dom/access-modifier';
import { Expression } from '#csharp/code-dom/expression';
import { TypeDeclaration } from './type-declaration';
import { comment, docCommentPrefix, docComment } from '#common/text-manipulation';
import { summary } from '#csharp/code-dom/doc-comments';

export class Property extends Initializer implements Expression {
  public "new": New = Modifier.None;
  public getAccess = Access.Public;
  public setAccess = Access.Public;
  public "static": Static = Modifier.None;
  public virtual: Virtual = Modifier.None;
  public sealed: Sealed = Modifier.None;
  public override: Override = Modifier.None;
  public abstract: Abstract = Modifier.None;
  public extern: Extern = Modifier.None;

  public description: string = "";

  protected get visibility(): Access {
    return highestAccess(this.getAccess, this.setAccess);
  }

  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Property>) {
    super();
    this.apply(objectInitializer);
  }

  protected get getter(): string {
    return this.getAccess == this.visibility ? "get" : `${this.getAccess} get`
  };
  protected get setter(): string {
    return this.setAccess == this.visibility ? "set" : `${this.setAccess} set`
  };

  public get declaration(): string {
    return `
${docComment(summary(this.description))}  
${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.use} ${this.name} { ${this.getter}; ${this.setter}; }
`.slim();
  }
  public get value(): string {
    return `${this.name}`;
  }
}


export class BackedProperty extends Property {
  public backingName: string;
  constructor(name: string, type: TypeDeclaration, objectInitializer?: Partial<BackedProperty>) {
    super(name, type);
    this.backingName = this.name.uncapitalize();
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `
${docComment(summary(`Backing field for ${this.name} property`))}    
private ${this.type.use} _${this.backingName};
EOL
${docComment(summary(this.description))}    
${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.use} ${this.name} { ${this.getter} { return this._${this.backingName}; } ${this.setter} { this._${this.backingName} = value; } }
EOL`.slim();
  }
  public get value(): string {
    return `${this.name}`;
  }
  public get privateValue(): string {
    return `this._${this.backingName}`;
  }
}