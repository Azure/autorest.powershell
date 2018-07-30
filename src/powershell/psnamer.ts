import { Model } from '#common/code-model/code-model';
import { processCodeModel } from '#common/process-code-model';
import { Host } from '@microsoft.azure/autorest-extension-base';

// Azure version -
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model): Promise<Model> {

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
