/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from "@microsoft.azure/autorest-extension-base";
import { process as remodeler } from "./remodeler/main";
import { process as llcsharp } from "./lowlevel-csharp/main";

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  pluginHost.Add("remodeler", remodeler);
  pluginHost.Add("llcsharp", llcsharp);

  await pluginHost.Run();
}

main();