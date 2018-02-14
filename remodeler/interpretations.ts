import * as OAI from "./oai3";


export function GetName(defaultValue: string, original: OAI.Extensions) {
  return typeof (original["x-ms-client-name"]) === "string" ? original["x-ms-client-name"] : defaultValue;
}

export function GetDescription(defaultValue: string | undefined, original: OAI.Extensions & { title?: string, summary?: string, description?: string }) {
  return original.description || original.title || original.summary || defaultValue;
}

export function GetEnumDefinition() {

}

export function GetKnownFormatType() {

}