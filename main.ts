/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from "@microsoft.azure/autorest-extension-base";
import { process as normalizer } from "./normalizer/main";

async function main() {
  const pluginHost = new AutoRestExtension();

  pluginHost.Add("normalizer", normalizer);

  await pluginHost.Run();
}

main();