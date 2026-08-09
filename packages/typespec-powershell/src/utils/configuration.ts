import { deserialize } from '@azure-tools/codegen';
import { readFileSync } from "fs";
import path from "path";
import { fileURLToPath } from "url";

function isPlainObject(value: any): value is Record<string, any> {
  return value !== null && typeof value === 'object' && !Array.isArray(value);
}

// Recursively merges source into target. Plain objects merge by key; arrays,
// primitives and null in source replace the target value. Inputs are not mutated.
export function deepMerge(target: any, source: any): any {
  if (!isPlainObject(target) || !isPlainObject(source)) {
    return source === undefined ? target : source;
  }

  const result: Record<string, any> = { ...target };
  for (const key of Object.keys(source)) {
    const sourceValue = source[key];
    if (sourceValue === undefined) {
      continue;
    }
    result[key] = isPlainObject(result[key]) && isPlainObject(sourceValue)
      ? deepMerge(result[key], sourceValue)
      : sourceValue;
  }
  return result;
}

// Recursively interpolate {placeholder} tokens in string values.
export function interpolatePlaceholders(obj: any, values: Record<string, any>): void {
  for (const key in obj) {
    if (typeof obj[key] === 'string') {
      obj[key] = obj[key].replace(/{([^}]+)}/g, (match: string, placeholder: string) => values[placeholder]);
    } else if (obj[key] !== null && typeof obj[key] === 'object') {
      interpolatePlaceholders(obj[key], values);
    }
  }
}

// Load configuration.yaml and merge emitter options over it, with emitter
// options taking precedence at every level of nested mappings.
export function loadConfiguration(emitterOptions: Record<string, any>): Record<string, any> {
  const __filename = fileURLToPath(import.meta.url);
  const __dirname = path.dirname(__filename);
  const configPath = path.join(__dirname, '../../../configuration.yaml');
  const configuration = deserialize<Record<string, any>>(readFileSync(configPath, 'utf8'), configPath);

  // Emitter options take precedence over the defaults, merged recursively so
  // partial nested mappings (e.g. metadata) keep unspecified defaults.
  const merged = deepMerge(configuration, emitterOptions);

  const interpolationValues = {
    'module-name': merged['module-name'],
    'service-name': merged['service-name']
  };
  interpolatePlaceholders(merged, interpolationValues);

  return merged;
}
