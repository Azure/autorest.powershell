import { Model } from '#common/code-model/code-model';
import { isHttpOperation } from '#common/code-model/http-operation';
import { JsonType, Schema } from '#common/code-model/schema';
import { items, length, values } from '#common/dictionary';
import { ModelState } from '#common/model-state';
import { processCodeModel } from '#common/process-code-model';
import { camelCase, deconstruct, fixLeadingNumber, pascalCase } from '#common/text-manipulation';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { SchemaDetails } from '#csharp/lowlevel-generator/code-model';
import { ArrayOf } from '#csharp/schema/array';
import { Boolean } from '#csharp/schema/boolean';
import { ByteArray } from '#csharp/schema/byte-array';
import { Char } from '#csharp/schema/char';
import { Date } from '#csharp/schema/date';
import { DateTime, DateTime1123, UnixTime } from '#csharp/schema/date-time';
import { Duration } from '#csharp/schema/duration';
import { Numeric } from '#csharp/schema/integer';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { String } from '#csharp/schema/string';
import { Uuid } from '#csharp/schema/Uuid';
import { IntegerFormat, NumberFormat, StringFormat } from '#remodeler/known-format';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host) {
  return processCodeModel(nameStuffRight, service);
}

async function nameStuffRight(codeModel: Model, service: Host): Promise<Model> {
  const resolver = new SchemaDefinitionResolver();

  // set the namespace for the service
  const serviceNamespace = await service.GetValue('namespace') || 'Sample.API';
  const clientName = pascalCase(fixLeadingNumber(deconstruct(codeModel.details.default.name)));

  // set c# client details (name)
  codeModel.details.csharp = {
    ...codeModel.details.default, // copy everything by default
    name: clientName,
    namespace: serviceNamespace,
    fullname: `${serviceNamespace}.${clientName}`
  };

  for (const { key: schemaName, value: schema } of items(codeModel.schemas)) {
    const details = schema.details.default;

    // object types.
    if (schema.type === JsonType.Object) {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(details.name)])), // objects have an interfaceName
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.name))),
        namespace: pascalCase([serviceNamespace, '.', `Models`]),  // objects have a namespace
        fullname: `${pascalCase([serviceNamespace, '.', `Models`])}.${pascalCase(fixLeadingNumber(deconstruct(schema.details.default.name)))}`,
      };
    } else if (schema.type === JsonType.String && schema.details.default.enum) {
      // oh, it's an enum type
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: pascalCase(fixLeadingNumber(['I', ...deconstruct(details.name)])),
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name))),
        namespace: pascalCase([serviceNamespace, '.', `Support`]),
        fullname: `${pascalCase([serviceNamespace, '.', `Support`])}.${pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name)))}`,
        enum: {
          ...schema.details.default.enum,
          name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name))),
          values: schema.details.default.enum.values.map(each => {
            return {
              ...each,
              name: pascalCase(fixLeadingNumber(deconstruct(each.name)))
            };
          })
        }
      };

    } else {
      schema.details.csharp = <SchemaDetails>{
        ...details,
        interfaceName: '<INVALID>',
        name: schemaName,
        namespace: '<INVALID>',
        fullname: '<INVALID>'
      };
    }

    for (const { key: propertyName, value: propertySchema } of items(schema.properties)) {
      const propertyDetails = propertySchema.details.default;

      const className = schema.details.csharp.name;

      let pname = pascalCase(fixLeadingNumber(deconstruct(propertyDetails.name)));
      if (pname === className) {
        pname = pname + "Property";
      }

      if (pname === 'default') {
        pname = '@default';
      }

      propertySchema.details.csharp = {
        ...propertyDetails,
        name: pname // and so are the propertyNmaes
      };
    }

    // fix enum names
    if (schema.details.default.enum) {
      schema.details.csharp.enum = {
        ...schema.details.default.enum,
        name: pascalCase(fixLeadingNumber(deconstruct(schema.details.default.enum.name)))
      };

      // and the value names themselves
      for (const value of values(schema.details.csharp.enum.values)) {
        value.name = pascalCase(fixLeadingNumber(deconstruct(value.name)));
      }
    }
  }

  for (const operation of values(codeModel.http.operations)) {
    const details = operation.details.default;

    operation.details.csharp = {
      ...details, // inherit
      name: pascalCase(fixLeadingNumber(deconstruct(details.name))), // operations have pascal cased names
    };

    // parameters are camelCased.
    for (const parameter of values(operation.parameters)) {
      const parameterDetails = parameter.details.default;

      let propName = camelCase(fixLeadingNumber(deconstruct(parameterDetails.name)));

      if (propName === 'default') {
        propName = '@default';
      }

      parameter.details.csharp = {
        ...parameterDetails,
        name: propName
      };
    }

    for (const { key: responseCode, value: responses } of items(operation.responses_new)) {
      // per responseCode
      for (const response of values(responses)) {
        const scTd = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, new ModelState(service, codeModel, `?`, ['schemas', response.schema.details.default.name])) : undefined;
        const genericParameters = scTd ? `<${scTd.declaration}>` : ``;

        const code = (dotnet.System.Net.HttpStatusCode[response.responseCode].value || '').replace('System.Net.HttpStatusCode', '') || response.responseCode;

        response.details.csharp = {
          ...response.details.default,
          type: `Response${genericParameters}`,
          name: (length(responses) <= 1) ?
            camelCase(fixLeadingNumber(deconstruct(`on ${code}`))) : // the common type (or the only one.)
            camelCase(fixLeadingNumber(deconstruct(`on ${code} ${response.mimeTypes[0]}`)))
        };
      }
    }
  }

  return codeModel;
}
