/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from "@microsoft.azure/autorest-extension-base";
import { process as remodeler } from "./remodeler/main";

async function main() {
  const pluginHost = new AutoRestExtension();

  pluginHost.Add("remodeler", remodeler);

  await pluginHost.Run();
}

main();