import { SdkClient, SdkContext, listAllServiceNamespaces, listClients } from "@azure-tools/typespec-client-generator-core";
import {
  Namespace,
  getNamespaceFullName,
  listServices,
  Operation,
  Interface,
  isTemplateDeclarationOrInstance,
  isTemplateDeclaration
} from "@typespec/compiler";

export function getClients(psContext: SdkContext): SdkClient[] {
  const services = new Set<Namespace>();
  listClients(psContext).forEach((c) => services.add(c.service));
  const rawServiceNamespaces = listAllServiceNamespaces(psContext);
  if (services.size === 0 && rawServiceNamespaces.length > 0) {
    // If no clients are found, fall back to raw service namespaces
    [...rawServiceNamespaces.values()].forEach((ns) => services.add(ns));
  }
  return [...services.values()].map((service) => {
    const clientName = service.name + "Client";
    return {
      kind: "SdkClient",
      name: clientName,
      service: service,
      type: service,
      arm: Boolean(psContext.arm),
      crossLanguageDefinitionId: `${getNamespaceFullName(
        service
      )}.${clientName}`,
      subOperationGroups: []
    };
  });
}

function isArm(service: Namespace): boolean {
  return service.decorators.some(
    (decorator) => decorator.decorator.name === "$armProviderNamespace"
  );
}

export function listOperations(client: SdkClient): Operation[] {
  const operations = [];
  const queue: (Namespace | Interface)[] = [client.service];
  while (queue.length > 0) {
    const current = queue.shift()!;
    if (
      current.decorators.some(
        (d) =>
          d.definition?.name === "@client" &&
          getNamespaceFullName(d.definition?.namespace) ===
          "Azure.ClientGenerator.Core"
      ) &&
      current !== client.service
    ) {
      continue;
    }
    operations.push(
      ...[...current.operations.values()].filter(
        (op) => isTemplateDeclarationOrInstance(op) === false
      )
    );
    if (current.kind === "Namespace") {
      queue.push(...current.namespaces.values());
      queue.push(
        ...[...current.interfaces.values()].filter(
          (i) => isTemplateDeclaration(i) === false
        )
      );
    }
  }
  return operations;
}
// export function isRLCMultiEndpoint(dpgContext: SdkContext): boolean {
//   return getRLCClients(dpgContext).length > 1;
// }
