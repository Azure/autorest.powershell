import { HttpComponents } from "#common/code-model/http-operation";
import { Dictionary } from "#common/dictionary";
import { Schema } from "#common/code-model/schema";
import { Info } from "#common/code-model/info";
import { CommandComponents } from "#common/code-model/command-operation";
import { Extensions } from "#common/code-model/extensions";
import { Details, ExternalDocumentation, SecurityRequirement, Server, Tag } from "./components";

//------------------------------------------------------------------------------------------------------------------ */
// Constructors for Code Model classes
//------------------------------------------------------------------------------------------------------------------ */

export interface Model extends Extensions {
  schemas: Dictionary<Schema>;

  details: ClientDetails;
  info: Info;
  externalDocs?: ExternalDocumentation;
  servers: Array<Server>;
  security: Array<SecurityRequirement>;
  tags: Array<Tag>;
  http: HttpComponents;
  commands: CommandComponents;
}

export class Model extends Extensions implements Model {
  schemas = new Dictionary<Schema>();
  details: ClientDetails;

  info: Info;

  servers = new Array<Server>();
  security = new Array<SecurityRequirement>();
  tags = new Array<Tag>();

  http = new HttpComponents();
  commands = new CommandComponents();

  constructor(title: string, version: string, initializer?: Partial<Model>) {
    super();
    this.details = { name: title };
    this.info = new Info(title, version, initializer ? initializer.info : {});
    this.apply(initializer);
  }
}

export interface ClientDetails extends Details {

}

