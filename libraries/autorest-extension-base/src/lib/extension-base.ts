import {
  createMessageConnection, Logger,
  RequestType0, RequestType1, RequestType2,
  NotificationType2, NotificationType4
} from "vscode-jsonrpc";
import { Readable } from "stream";
import { Mapping, Message, RawSourceMap, Channel } from "./types";
import { basename, dirname } from "path";

module IAutoRestPluginTarget_Types {
  export const GetPluginNames = new RequestType0<string[], Error, void>("GetPluginNames");
  export const Process = new RequestType2<string, string, boolean, Error, void>("Process");
}
interface IAutoRestPluginTarget {
  GetPluginNames(): Promise<string[]>;
  Process(pluginName: string, sessionId: string): Promise<boolean>;
}

module IAutoRestPluginInitiator_Types {
  export const ReadFile = new RequestType2<string, string, string, Error, void>("ReadFile");
  export const GetValue = new RequestType2<string, string, any, Error, void>("GetValue");
  export const ListInputs = new RequestType2<string, string | undefined, string[], Error, void>("ListInputs");
  export const WriteFile = new NotificationType4<string, string, string, Mapping[] | RawSourceMap | undefined, void>("WriteFile");
  export const Message = new NotificationType2<string, Message, void>("Message");
}

export interface IAutoRestPluginInitiator {
  ReadFile(filename: string): Promise<string>;
  GetValue(key: string): Promise<any>;
  ListInputs(artifactType?: string): Promise<string[]>;
  ProtectFiles(path: string): Promise<void>;
  WriteFile(filename: string, content: string, sourceMap?: Mapping[] | RawSourceMap, artifactType?: string): void;
  Message(message: Message): void;
  UpdateConfigurationFile(filename: string, content: string): void;
  GetConfigurationFile(filename: string): Promise<string>
}

export type AutoRestPluginHandler = (initiator: IAutoRestPluginInitiator) => Promise<void>;

export class AutoRestExtension {
  private readonly plugins: { [name: string]: AutoRestPluginHandler } = {};

  public Add(name: string, handler: AutoRestPluginHandler): void {
    this.plugins[name] = handler;
  }

  public async Run(input: NodeJS.ReadableStream = process.stdin, output: NodeJS.WritableStream = process.stdout): Promise<void> {
    // connection setup
    const channel = createMessageConnection(
      input,
      output,
      {
        error(message) { console.error("error: ", message); },
        info(message) { console.error("info: ", message); },
        log(message) { console.error("log: ", message); },
        warn(message) { console.error("warn: ", message); }
      }
    );

    channel.onRequest(IAutoRestPluginTarget_Types.GetPluginNames, async () => Object.keys(this.plugins));
    channel.onRequest(IAutoRestPluginTarget_Types.Process, async (pluginName: string, sessionId: string) => {
      try {
        const handler = this.plugins[pluginName];
        if (!handler) {
          throw new Error(`Plugin host could not find requested plugin '${pluginName}'.`);
        }
        await handler({
          async ProtectFiles(path: string): Promise<void> {
            const send = (uri: string, content: string) => {
              channel.sendNotification(IAutoRestPluginInitiator_Types.Message, sessionId, {
                Channel: Channel.File,
                Details: {
                  content: content,
                  type: "preserved-files",
                  uri: uri,
                },
                Text: content,
                Key: ["preserved-files", uri]
              });
            }

            const items = await channel.sendRequest(IAutoRestPluginInitiator_Types.ListInputs, sessionId, path);

            if (items && items.length > 0) {
              for (const each of items) {
                try {
                  const content = await channel.sendRequest(IAutoRestPluginInitiator_Types.ReadFile, sessionId, each);
                  if (content || content === "") {
                    send(each, content);
                  }
                } catch (E) {
                }

              }
              return;
            }

            // not a folder 
            // try just loading a single file 
            try {

              const content = await channel.sendRequest(IAutoRestPluginInitiator_Types.ReadFile, sessionId, path);
              if (content || content === "") {
                send(path, content);
              }

            } catch {
              // didn't get that either.
            }
          },
          UpdateConfigurationFile(filename: string, content: string): void {
            channel.sendNotification(IAutoRestPluginInitiator_Types.Message, sessionId, { Channel: Channel.Configuration, Key: [filename], Text: content });
          },
          async GetConfigurationFile(filename: string): Promise<string> {
            const configurations = await channel.sendRequest(IAutoRestPluginInitiator_Types.GetValue, sessionId, "configurationFiles");

            const filenames = Object.getOwnPropertyNames(configurations);
            if (filenames.length > 0) {
              const basePath = dirname(filenames[0]);
              for (const configFile of filenames) {
                if (configFile.startsWith(basePath) && filename === basename(configFile)) {
                  return configurations[configFile];
                }
              }
            }
            return "";
          },
          async ReadFile(filename: string): Promise<string> {
            return await channel.sendRequest(IAutoRestPluginInitiator_Types.ReadFile, sessionId, filename);
          },
          async GetValue(key: string): Promise<any> {
            return await channel.sendRequest(IAutoRestPluginInitiator_Types.GetValue, sessionId, key);
          },
          async ListInputs(artifactType?: string): Promise<string[]> {
            return await channel.sendRequest(IAutoRestPluginInitiator_Types.ListInputs, sessionId, artifactType);
          },
          WriteFile(filename: string, content: string, sourceMap?: Mapping[] | RawSourceMap, artifactType?: string): void {
            if (artifactType) {
              channel.sendNotification(IAutoRestPluginInitiator_Types.Message, sessionId, {
                Channel: Channel.File,
                Details: {
                  content: content,
                  type: artifactType,
                  uri: filename,
                  sourceMap: sourceMap
                },
                Text: content,
                Key: [artifactType, filename]
              });
            } else {
              channel.sendNotification(IAutoRestPluginInitiator_Types.WriteFile, sessionId, filename, content, sourceMap);
            }
          },

          Message(message: Message): void {
            channel.sendNotification(IAutoRestPluginInitiator_Types.Message, sessionId, message);
          }
        });
        return true;
      } catch (e) {
        channel.sendNotification(IAutoRestPluginInitiator_Types.Message, sessionId, <Message>{
          Channel: "fatal" as any,
          Text: "" + e,
          Details: e
        });
        return false;
      }
    });

    // activate
    channel.listen();
  }
}
