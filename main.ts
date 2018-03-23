/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from "@microsoft.azure/autorest-extension-base";
import { process as remodeler } from "./remodeler/main";
import { process as inferrer } from "./remodeler/inferrer";

import { process as llcsharp } from "./csharp/lowlevel-generator/main";
import { process as csnamer } from "./csharp/namer";
import { process as csinferrer } from "./csharp/inferrer";

import { CommaChar } from "#common/text-manipulation";

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // remodeler extensions
  pluginHost.Add("remodeler", remodeler);
  pluginHost.Add("inferrer", inferrer);

  // csharp extensions
  pluginHost.Add("csinferrer", csinferrer);
  pluginHost.Add("csnamer", csnamer);
  pluginHost.Add("llcsharp", llcsharp);

  await pluginHost.Run();
}

main();