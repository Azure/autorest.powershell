/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';

// Azure version -
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function namer(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model): Promise<codemodel.Model> {

  // rewrite things so the names are what we want.


  /* I'm not so sure we should be doing this here.

  // make sure descriptions are properly escaped.
  for (const each of values(model.commands.operations)) {
    if (each.details && each.details.powershell) {
      each.details.powershell.description = escapeString(each.details.powershell.description);
    }
  }

  for (const each of values(model.schemas)) {
    if (each.details && each.details.powershell) {
      each.details.powershell.description = escapeString(each.details.powershell.description);
    }
    for (const prop of values(each.properties)) {
      if (prop.details && prop.details.powershell) {
        prop.details.powershell.description = escapeString(prop.details.powershell.description);
      }
    }
  }
  */
  return model;
}
