/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host, Channel } from '@microsoft.azure/autorest-extension-base';
import { codemodel, processCodeModel, allVirtualParameters, allVirtualProperties, resolveParameterNames, resolvePropertyNames } from '@microsoft.azure/autorest.codemodel-v3';
import { deconstruct, values, removeProhibitedPrefix } from '@microsoft.azure/codegen';
import * as linq from '@microsoft.azure/linq';
import { singularize } from './name-inferrer';

// well-known parameters to singularize
const namesToSingularize = new Set<string>([
  'Tags'
]);

export async function namer(service: Host) {
  return processCodeModel(tweakModel, service);
}

export function getDeduplicatedSubjectPrefix(subjectPrefix: string, subject: string): string {
  // It removes intersection with the subject from the subjectPrefix:
  //    ContainerServiceContainerService -> ContainerService, 
  //    AppConfigurationConfigurationService -> AppConfiguration

  const deconstructedSubject = deconstruct(subject);
  const endingsToMatch = [];
  for (let i = 0; i < deconstructedSubject.length; i++) {
    endingsToMatch.push(`${deconstructedSubject.slice(0, i + 1).join('')}$`);
  }

  const regex = new RegExp(`(.*)(${endingsToMatch.join('|')})`, 'g');
  return subjectPrefix.replace(regex, '$1');
}

async function tweakModel(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  // get the value 
  const isAzure = model.details.default.isAzure;
  const shouldSanitize = !!await service.GetValue('sanitize-names');

  // make sure recursively that every details field has csharp
  for (const { index, instance } of linq.visitor(model)) {
    if (index === 'details' && instance.default && !instance.csharp) {
      instance.csharp = linq.clone(instance.default, false, undefined, undefined, ['schema', 'origin']);
    }
  }

  if (shouldSanitize || isAzure) {
    for (const operation of values(model.commands.operations)) {
      // clean the noun (i.e. subjectPrefix + subject)
      const prevSubjectPrefix = operation.details.csharp.subjectPrefix;
      const newSubjectPrefix = getDeduplicatedSubjectPrefix(operation.details.csharp.subjectPrefix, operation.details.csharp.subject);
      if (prevSubjectPrefix !== newSubjectPrefix) {
        const verb = operation.details.csharp.verb;
        const subject = operation.details.csharp.subject;
        const variantName = operation.details.csharp.name;
        const prevCmdletName = getCmdletName(verb, prevSubjectPrefix, subject);
        operation.details.csharp.subjectPrefix = newSubjectPrefix;
        const newCmdletName = getCmdletName(verb, operation.details.csharp.subjectPrefix, subject);
        service.Message(
          {
            Channel: Channel.Verbose,
            Text: `Sanitized cmdlet-name -> Changed cmdlet-name from ${prevCmdletName} to ${newCmdletName}: {subjectPrefix: ${newSubjectPrefix}, subject: ${subject}${variantName ? `, variant: ${variantName}}` : '}'}`
          }
        );
      }

      const virtualParameters = [...allVirtualParameters(operation.details.csharp.virtualParameters)]
      for (const parameter of virtualParameters) {
        // save previous name as alias
        const prevName = parameter.name;
        const otherParametersNames = values(virtualParameters)
          .linq.select(each => each.name)
          .linq.where(name => name !== parameter.name)
          .linq.toArray();

        const sanitizedName = removeProhibitedPrefix(
          parameter.name,
          operation.details.csharp.subject,
          otherParametersNames
        );

        if (prevName !== sanitizedName) {
          if (parameter.alias === undefined) {
            parameter.alias = [];
          }

          parameter.alias.push(parameter.name);

          // change name
          parameter.name = sanitizedName;
          service.Message({ Channel: Channel.Verbose, Text: `Sanitized parameter-name -> Changed parameter-name ${prevName} to ${parameter.name} from command ${operation.verb}-${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}` });
        } else if (namesToSingularize.has(parameter.name) && isAzure) {
          if (parameter.alias === undefined) {
            parameter.alias = [];
          }

          parameter.alias.push(parameter.name);

          // change name
          parameter.name = singularize(parameter.name);
          service.Message({ Channel: Channel.Verbose, Text: `Well-Know Azure parameter rename -> Changed parameter-name ${prevName} to ${parameter.name} from command ${operation.verb}-${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}` });
        }
      }
    }

    for (const schema of values(model.schemas)) {
      const virtualProperties = [...allVirtualProperties(schema.details.csharp.virtualProperties)];

      for (const property of virtualProperties) {
        // save previous name as alias
        const otherPropertiesNames = values(virtualProperties)
          .linq.select(each => each.name)
          .linq.where(name => name !== property.name)
          .linq.toArray();

        const sanitizedName = removeProhibitedPrefix(
          property.name,
          schema.details.csharp.name,
          otherPropertiesNames
        );

        if (property.name !== sanitizedName) {
          // apply alias
          const prevName = property.name;
          if (property.alias === undefined) {
            property.alias = [];
          }

          property.alias.push(property.name);

          // change name
          property.name = sanitizedName;
          service.Message({ Channel: Channel.Verbose, Text: `Sanitized property-name -> Changed property-name ${prevName} to ${property.name} from model ${schema.details.csharp.name}` });
        } else if (namesToSingularize.has(property.name) && isAzure) {
          // apply alias
          const prevName = property.name;
          if (property.alias === undefined) {
            property.alias = [];
          }

          property.alias.push(prevName);

          // change name
          property.name = singularize(property.name);
          service.Message({ Channel: Channel.Verbose, Text: `Well-Know Azure property-rename -> Changed property-name ${prevName} to ${property.name} from model ${schema.details.csharp.name}` });
        }
      }
    }
  }

  // do collision detection work.
  for (const command of values(model.commands.operations)) {
    const vp = command.details.csharp.virtualParameters;
    if (vp) {
      resolveParameterNames([], vp);
    }
  }

  for (const schema of values(model.schemas)) {
    const vp = schema.details.csharp.virtualProperties;
    if (vp) {
      resolvePropertyNames([schema.details.csharp.name], vp);
    }
  }
  return model;
}


function getCmdletName(verb: string, subjectPrefix: string, subject: string): string {
  return `${verb}_${subjectPrefix}${subject}`;
}