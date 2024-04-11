import { Message } from '@autorest/extension-base';

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
  configurations: (key: string) => any;
  constructor(configurations: (key: string) => any) {
    this.configurations = configurations;
  }
  protectFiles(path: string): Promise<void> {
    throw new Error('Method not implemented');
  }
  readFile(filename: string): Promise<string> {
    throw new Error('Method not implemented');
  }
  getValue<T>(key: string): Promise<T | undefined> {
    throw new Error('Method not implemented');
  }
  listInputs(artifactType?: string): Promise<string[]> {
    throw new Error('Method not implemented');
  }
  writeFile({ filename, content, sourceMap, artifactType }: TspWriteFileOptions): void {
    throw new Error('Method not implemented');
  }
  UpdateConfigurationFile(filename: string, content: string): void {
    throw new Error('Method not implemented');
  }
  GetConfigurationFile(filename: string): Promise<string> {
    throw new Error('Method not implemented');
  }
  // WriteFile(filename: string, content: string): void {
  //   throw new Error('Method not implemented');
  // }
  // GetValue(key: string): any {
  //   throw new Error('Method not implemented');
  // }
  message(message: Message): void {
    throw new Error('Method not implemented');
  }
}