/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { CommandComponents } from './command-operation';
import { Extensions } from './extensions';
import { HttpComponents } from './http-operation';
import { Info } from './info';
import { Schema } from './schema';
import { Dictionary } from '@microsoft.azure/codegen';
import { ExternalDocumentation, ImplementationDetails, LanguageDetails, SecurityRequirement, Server, Tag } from './components';

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
