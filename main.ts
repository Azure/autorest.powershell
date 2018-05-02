/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';
import { process as remodeler } from './remodeler/main';
import { process as tweakCodeModel } from './remodeler/tweak-model';
import { process as tweakCodeModelAzure } from './remodeler/tweak-model-azure';

import { process as llcsharp } from './csharp/lowlevel-generator/main';
import { process as powershell } from './powershell/powershell-generator';
import { process as csnamer } from './csharp/namer';
import { process as csinferrer } from './csharp/inferrer';

import { process as hlnameinferrer } from './highlevel/name-inferrer';

import { CommaChar } from '#common/text-manipulation';

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // remodeler extensions
  pluginHost.Add("remodeler", remodeler);

  pluginHost.Add("tweakcodemodel", tweakCodeModel);
  pluginHost.Add("tweakcodemodelazure", tweakCodeModelAzure);

  // csharp extensions
  // pluginHost.Add("csinferrer", csinferrer);

  pluginHost.Add("csnamer", csnamer);

  pluginHost.Add("llcsharp", llcsharp);
  pluginHost.Add("powershell", powershell);

  // powershell extensions
  pluginHost.Add("hlnameinferrer", hlnameinferrer);

  await pluginHost.Run();
}

main();