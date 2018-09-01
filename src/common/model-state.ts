/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Channel, Host, JsonPath } from '@microsoft.azure/autorest-extension-base';

export class ModelState<T> {
  protected errorCount = 0;

  constructor(public service: Host, public model: T, protected documentName: string, protected currentPath: JsonPath = new Array<string>()) {
  }

  public path(...childPath: JsonPath): ModelState<T> {
    return new ModelState<T>(this.service, this.model, this.documentName, [...this.currentPath, ...childPath]);
  }

  public checkpoint() {
    if (this.errorCount > 0) {
      throw new Error();
    }
  }

  protected msg(channel: Channel, message: string, key: Array<string>, details: any) {
    this.service.Message({
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
    this.service.Message({
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
