/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { values, Dictionary, items } from '#common/linq';
import * as aio from '@microsoft.azure/async-io';
import { join } from 'path';

function getAllPropertyNames(obj: any) {
  const props = new Array<string>();

  do {
    Object.getOwnPropertyNames(obj).forEach(function (prop) {
      if (props.indexOf(prop) === -1) {
        props.push(prop);
      }
    });
  } while (obj = Object.getPrototypeOf(obj));

  return props;
}

export function fail(text: string): never {
  throw new Error(text);
}

export function applyOverrides(content: string, overrides: Dictionary<string>): string {
  for (const { key: from, value: to } of items(overrides)) {
    content = content.replace(new RegExp(from, 'g'), to);
  }
  return content;
}

export async function copyResources(sourceFolder: string, fileWriter: (filename: string, content: string) => Promise<void>, overrides: Dictionary<string> = {}) {
  const done = new Array<Promise<void>>();
  try {
    const files = await aio.readdir(sourceFolder);

    for (const file of values(files)) {
      const fullPath = join(sourceFolder, file);
      if (await aio.isDirectory(fullPath)) {
        done.push(copyResources(fullPath, async (f, c) => fileWriter(`${file}/${f}`, c), overrides));
        continue;
      }
      if (await aio.isFile(fullPath)) {
        done.push(aio.readFile(fullPath).then(async (content) => fileWriter(file, applyOverrides(content, overrides))
        ));
      }
    }
  } catch {

  }
  await Promise.all(done);
}
