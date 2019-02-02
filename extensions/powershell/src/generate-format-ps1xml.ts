import * as XmlBuilder from 'xmlbuilder';
import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from './project';
import { deconstruct, pascalCase, items, length, values, Dictionary } from '@microsoft.azure/codegen';
import { Schema, ClientRuntime, SchemaDefinitionResolver, ObjectImplementation } from '@microsoft.azure/autorest.csharp-v2';
import { State } from './state';

export function generateFormatPs1xml(service: Host, model: codemodel.Model, project: Project) {

  const ps1xmlModel = {
    Configuration: {
      ViewDefinitions: [] as object[]
    }
  };
  // const viewModel = {
  //   View: {
  //     Name: '',
  //     ViewSelectedBy: {
  //     },
  //     TableControl: {
  //       TableHeaders: {
  //       },
  //       TableRowEntries: {
  //         TableRowEntry: {
  //           TableColumnItems: {
  //           }
  //         }
  //       }
  //     }
  //   }
  // }
  // const resolver = new SchemaDefinitionResolver();

  // model.commands.parameters.
  // const classObjects = items(model.schemas)
  //   .linq.where(each => !each.value || each.value.details.csharp.skip)
  //   .linq.select(each => resolver.resolveTypeDeclaration(<any>each.value, true, state))
  //   .linq.where(each => each instanceof ObjectImplementation);
  // for (const classObject of classObjects) {
  //   classObject.schema
  // }
  // const outputClasses = items(model.http.operations)
  //   .linq.selectMany(o => items(o.value.responses))
  //   .linq.where(rd => rd.key === '200')
  //   .linq.selectMany(ra => ra.value)
  //   .linq.where(r => r.schema !== undefined)
  //   .linq.select(r => { const csharp = (<Schema>r.schema).details.csharp; return `${csharp.namespace}${csharp.namespace ? '.' : ''}${csharp.name}` })
  //   .linq.distinct();
  // for (const outputClass in outputClasses) {
  //   const entry = {
  //     TableColumnHeader: {
  //       Label: outputClass
  //     },
  //     TableColumnItem: {
  //       PropertyName: outputClass
  //     }
  //   }
  // }

  const entries = items(model.http.operations)
    .linq.selectMany(o => items(o.value.responses))
    .linq.where(rd => rd.key === '200')
    .linq.selectMany(ra => ra.value)
    .linq.where(r => r.schema !== undefined)
    .linq.select(r => {
      const csharp = (<Schema>r.schema).details.csharp;
      return `${csharp.namespace}${csharp.namespace ? '.' : ''}${csharp.name}`;
    })
    .linq.distinct()
    .linq.select(c => createViewModel(c));

  ps1xmlModel.Configuration.ViewDefinitions.push(...entries);
  const ps1xml = XmlBuilder.create(ps1xmlModel);
  service.WriteFile(`${project.moduleName}.format.ps1xml`, ps1xml.end({ pretty: true }), undefined, 'source-file-other');
}

function createViewModel(className: string): object {
  return {
    View: {
      Name: className,
      ViewSelectedBy: [{
        TypeName: className
      }],
      TableControl: {
        TableHeaders: [],
        TableRowEntries: {
          TableRowEntry: {
            TableColumnItems: []
          }
        }
      }
    }
  }
}