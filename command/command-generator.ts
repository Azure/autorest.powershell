import { Model } from '#common/code-model/code-model';
import { processCodeModel } from '#common/process-code-model';
import { ArtifactMessage, Channel, Host, Message } from '@microsoft.azure/autorest-extension-base';
import { getCommandName } from 'highlevel/name-inferrer';

export async function process(service: Host): Promise<void> {
  return processCodeModel(createCommandOperations, service);
}

/** attempts to create command operations for each http operation */
async function createCommandOperations(model: Model, service: Host): Promise<Model> {
  for (const operation of Object.values(model.http.operations)) {
    const names = getCommandName(operation.details.name, service.Message);

  }
  return model;
}
