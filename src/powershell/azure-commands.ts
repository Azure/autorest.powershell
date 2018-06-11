
import { Dictionary, values, length, items } from '#common/dictionary';
import { EnglishPluralizationService } from '#common/english-pluralization-service/pluralization';
import { processCodeModel } from '#common/process-code-model';
import { deconstruct, pascalCase, fixLeadingNumber } from '#common/text-manipulation';
import { deserialize, serialize } from '#common/yaml';
import { Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { Lazy } from '@microsoft.azure/tasks';
import { getAllProperties } from '#common/code-model/schema';
import { Model } from '#common/code-model/code-model';
import { CommandOperation } from '#common/code-model/command-operation';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { IParameter } from '#common/code-model/components';

export async function process(service: Host) {
  return processCodeModel(tweakCommands, service);
}

async function tweakCommands(model: Model, service: Host): Promise<Model> {

  // TODO: 
  // identify SubscriptionId, resourceGroup, Location parameters, and tweak them for azure-specific behavior.

  // TODO: 
  // inject support for Azure Authentication into the commands


  return model;
}