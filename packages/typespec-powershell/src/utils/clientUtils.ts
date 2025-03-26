import { SdkClient, SdkContext, listAllServiceNamespaces } from "@azure-tools/typespec-client-generator-core";
import {
  Namespace,
  getNamespaceFullName,
  listServices
} from "@typespec/compiler";

export function getClients(psContext: SdkContext): SdkClient[] {
  const services = listAllServiceNamespaces(psContext);

  return services.map((service) => {
    const clientName = service.name + "Client";
    return {
      kind: "SdkClient",
      name: clientName,
      service: service,
      type: service,
      arm: Boolean(psContext.arm),
      crossLanguageDefinitionId: `${getNamespaceFullName(
        service
      )}.${clientName}`
    };
  });
}

function isArm(service: Namespace): boolean {
  return service.decorators.some(
    (decorator) => decorator.decorator.name === "$armProviderNamespace"
  );
}

// export function isRLCMultiEndpoint(dpgContext: SdkContext): boolean {
//   return getRLCClients(dpgContext).length > 1;
// }
