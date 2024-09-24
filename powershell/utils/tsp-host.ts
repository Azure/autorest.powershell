import { Message } from '@autorest/extension-base';
import { comment } from '@azure-tools/codegen';
import { writeFileSync, existsSync, mkdirSync } from 'fs';
import { dirname } from 'path';
export interface TspWriteFileOptions {
  /**
   * @param filename Name of the file.
   */
  filename: string;
  /**
   * @param content Content of the file.
   */
  content: string;
  /**
   * @param sourceMap Source map that can be used to trace back source position in case of error.
   */
  sourceMap?: string;
  /**
   * @param artifactType Artifact type
   */
  artifactType?: string;
}

export interface TspHost {
  protectFiles(path: string): Promise<void>;
  readFile(filename: string): Promise<string>;
  getValue<T>(key: string): Promise<T | undefined>;
  listInputs(artifactType?: string): Promise<Array<string>>;
  writeFile({ filename, content, sourceMap, artifactType }: TspWriteFileOptions): void;
  message(message: Message): void;

  UpdateConfigurationFile(filename: string, content: string): void;

  GetConfigurationFile(filename: string): Promise<string>;

  // WriteFile(filename: string, content: string): void;

  // GetValue(key: string): any;
}

export class TspHostImpl implements TspHost {
  configurations: Record<string, any>;
  constructor(configurations: Record<string, any>) {
    this.configurations = configurations;
  }
  protectFiles(path: string): Promise<void> {
    // ToDo by xiaogang, skip this for now
    return Promise.resolve();
  }
  readFile(filename: string): Promise<string> {
    // ToDo by xiaogang, skip this for now
    return Promise.resolve('');
  }
  getValue<T>(key: string): Promise<T | undefined> {
    return this.configurations[key];
  }
  listInputs(artifactType?: string): Promise<Array<string>> {
    // Shall not be called, so throw an exception
    throw new Error('Method listInputs not implemented');
  }
  writeFile({ filename, content, sourceMap, artifactType }: TspWriteFileOptions): void {
    const directoryPath = dirname(filename);
    if (!existsSync(directoryPath)) {
      mkdirSync(directoryPath, { recursive: true });
    }
    if (artifactType === 'binary-file') {
      writeFileSync(filename, Buffer.from(content, 'base64'));
    } else {
      if (artifactType === 'source-file-csharp' && filename.endsWith('.cs')) {
        const header = comment('Copyright (c) Microsoft Corporation. All rights reserved.\nLicensed under the MIT License. See License.txt in the project root for license information.\nChanges may cause incorrect behavior and will be lost if the code is regenerated.', '//');
        content = header + '\n' + content;
      }
      writeFileSync(filename, content);
    }
  }
  UpdateConfigurationFile(filename: string, content: string): void {
    // Shall not be called 
    throw new Error('Method UpdateConfigurationFile not implemented');
  }
  GetConfigurationFile(filename: string): Promise<string> {
    throw new Error('Method GetConfigurationFile not implemented');
  }
  // WriteFile(filename: string, content: string): void {
  //   throw new Error('Method not implemented');
  // }
  // GetValue(key: string): any {
  //   throw new Error('Method not implemented');
  // }
  message(message: Message): void {
    // ToDo by xiaogang, skip this for now
    return;
  }
}