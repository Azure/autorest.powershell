/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Channel, AutorestExtensionHost as Host, JsonPointerSegments as JsonPath, Mapping, RawSourceMap, Message } from '@autorest/extension-base';
import { safeEval, deserialize, Initializer, DeepPartial } from '@azure-tools/codegen';
import { Dictionary } from '@azure-tools/linq';
import { TspHost, TspHostImpl } from './tsp-host';

export class ModelState<T extends Dictionary<any>> extends Initializer {
  public model!: T;
  protected documentName!: string;
  protected currentPath: JsonPath = new Array<string>();
  private context!: any;
  private _debug = false;
  private _verbose = false;

  public constructor(public service: TspHost | Host, objectInitializer?: DeepPartial<ModelState<T>>) {
    super();
    this.apply(objectInitializer);
  }

  async init(project?: any) {
    if (this.service instanceof TspHostImpl) {
      // skip init for tsp
      this.initContext(project);
      return this;
    }
    const m = await ModelState.getModel<T>(this.service);
    this.model = m.model;
    this.documentName = m.filename;
    this.initContext(project);
    this._debug = await this.getValue('debug', false);
    this._verbose = await this.getValue('verbose', false);
    return this;
  }

  async initContext(project: any) {
    this.context = this.context || {
      $config: await this.service.getValue(''),
      $project: project,
      $lib: {
        path: require('path')
      }
    };
    return this;
  }

  async readFile(filename: string): Promise<string> {
    return this.service.readFile(filename);
  }


  async getValue<V>(key: string, defaultValue?: V): Promise<V> {
    // check if it's in the model first
    let value = this.model && this.model.language && this.model.language.default ? (<any>this.model.language.default)[key] : undefined;

    // fall back to the configuration
    if (value == null || value === undefined) {
      value = await this.service.getValue(key);
    }

    // try as a safe eval execution.
    if (value === null || value === undefined) {
      try {
        value = safeEval(key, this.context);
      }
      catch {
        value = null;
      }
    }

    if (defaultValue === undefined && value === null) {
      throw new Error(`No value for configuration key '${key}' was provided`);
    }

    if (typeof value === 'string') {
      value = await this.resolveVariables(value);
    }

    // ensure that any content variables are resolved at the end.
    return <V>(value !== null ? value : defaultValue);
  }

  async setValue<V>(key: string, value: V) {
    (<any>this.model.language.default)[key] = value;
  }

  async listInputs(artifactType?: string | undefined): Promise<Array<string>> {
    return this.service.listInputs(artifactType);
  }

  async protectFiles(path: string): Promise<void> {
    return this.service.protectFiles(path);
  }
  writeFile(filename: string, content: string, sourceMap?: undefined, artifactType?: string | undefined): void {
    return this.service.writeFile({ filename: filename, content: content, sourceMap: sourceMap, artifactType: artifactType });
  }

  message(message: Message): void {
    if (message.Channel === Channel.Debug && this._debug === false) {
      return;
    }
    if (message.Channel === Channel.Verbose && this._verbose === false) {
      return;
    }
    return this.service.message(message);
  }

  updateConfigurationFile(filename: string, content: string): void {
    return this.service.UpdateConfigurationFile(filename, content);
  }
  async getConfigurationFile(filename: string): Promise<string> {
    return this.service.GetConfigurationFile(filename);
  }
  protected errorCount = 0;

  protected static async getModel<T>(service: Host | TspHost) {
    const files = await service.listInputs();
    const filename = files[0];
    if (files.length === 0) {
      throw new Error('Inputs missing.');
    }
    return {
      filename,
      model: deserialize<T>(await service.readFile(filename), filename)
    };
  }


  cache!: Array<any>;
  replacer(key: string, value: any) {
    this.cache = this.cache || new Array<any>();

    if (typeof value === 'object' && value !== null) {
      if (this.cache.indexOf(value) !== -1) {
        // Duplicate reference found
        try {
          // If this value does not reference a parent it can be deduped
          return JSON.parse(JSON.stringify(value));
        } catch (error) {
          // discard key if value cannot be deduped
          return;
        }
      }
      // Store value in our collection
      this.cache.push(value);
    }
    return value;
  }

  async resolveVariables(input: string): Promise<string> {
    let output = input;
    for (const rx of [/\$\((.*?)\)/g, /\$\{(.*?)\}/g]) {
      /* eslint-disable */
      for (let match; match = rx.exec(input);) {
        const text = match[0];
        const inner = match[1];
        let value = await this.getValue<any>(inner, null);

        if (value !== undefined && value !== null) {
          if (typeof value === 'object') {
            value = JSON.stringify(value, this.replacer, 2);
          }
          if (value === '{}') {
            value = 'true';
          }
          output = output.replace(text, value);
        }
      }
    }
    return output;
  }


  public path(...childPath: JsonPath) {
    // this strategy for tracking source path locations
    // has proved fundementally crappy.

    // will be removing this stuff and transitioning to source-track method.

    //const result = new ModelState<T>(this.service, <any>this);
    //result.currentPath = [...this.currentPath, ...childPath];
    // return result;
    return this;
  }

  public checkpoint() {
    if (this.errorCount > 0) {
      throw new Error();
    }
  }

  protected msg(channel: Channel, message: string, key: Array<string>, details: any) {
    this.message({
      Channel: channel,
      Key: key,
      Source: [
        {
          document: this.documentName,
          Position: {
            path: this.currentPath
          }
        }
      ],
      Text: message,
      Details: details
    });
  }

  public warning(message: string, key: Array<string>, details?: any) {
    this.msg(Channel.Warning, message, key, details);
  }
  public hint(message: string, key: Array<string>, details?: any) {
    this.msg(Channel.Hint, message, key, details);
  }

  public error(message: string, key: Array<string>, details?: any) {
    this.errorCount++;
    this.msg(Channel.Error, message, key, details);
  }
  public fatal(message: string, key: Array<string>, details?: any) {
    this.errorCount++;
    this.msg(Channel.Fatal, message, key, details);
  }

  protected output(channel: Channel, message: string, details?: any) {
    this.message({
      Channel: channel,
      Text: message,
      Details: details
    });
  }

  public debug(message: string, details: any) {
    this.output(Channel.Debug, message, details);
  }
  public verbose(message: string, details: any) {
    this.output(Channel.Verbose, message, details);
  }
  public log(message: string, details: any) {
    this.output(Channel.Information, message, details);
  }
}
