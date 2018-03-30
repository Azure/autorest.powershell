
export type JSONValue = string | number | boolean | JSONObject | JSONArray;

export interface JSONObject {
  readonly [x: string]: JSONValue;
}

export interface JSONArray extends ReadonlyArray<JSONValue> { }