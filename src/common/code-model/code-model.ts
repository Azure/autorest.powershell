import { CommandComponents } from '#common/code-model/command-operation';
import { Extensions } from '#common/code-model/extensions';
import { HttpComponents } from '#common/code-model/http-operation';
import { Info } from '#common/code-model/info';
import { Schema } from '#common/code-model/schema';
import { Dictionary } from '#common/dictionary';
import { ImplementationDetails, ExternalDocumentation, LanguageDetails, SecurityRequirement, Server, Tag } from './components';

// ------------------------------------------------------------------------------------------------------------------
// Constructors for Code Model classes
// ------------------------------------------------------------------------------------------------------------------

export interface Model extends Extensions {
  schemas: Dictionary<Schema>;

  details: LanguageDetails<ClientDetails>;
  info: Info;
  externalDocs?: ExternalDocumentation;
  servers: Array<Server>;
  security: Array<SecurityRequirement>;
  tags: Array<Tag>;
  http: HttpComponents;
  commands: CommandComponents;
}

export class Model extends Extensions implements Model {
  public schemas = new Dictionary<Schema>();
  public details: LanguageDetails<ClientDetails>;

  public info: Info;

  public servers = new Array<Server>();
  public security = new Array<SecurityRequirement>();
  public tags = new Array<Tag>();

  public http = new HttpComponents();
  public commands = new CommandComponents();

  constructor(title: string, version: string, initializer?: Partial<Model>) {
    super();
    this.details = { default: { name: title, description: '' } };
    this.info = new Info(title, version, initializer ? initializer.info : {});
    this.apply(initializer);
  }
}

export interface ClientDetails extends ImplementationDetails {

}

