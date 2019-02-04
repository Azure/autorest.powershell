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

  const entries = items(model.http.operations)
    .linq.selectMany(o => items(o.value.responses))
    .linq.where(rd => rd.key === '200')
    .linq.selectMany(ra => ra.value)
    .linq.where(r => r.schema !== undefined && r.schema.details.csharp.fullname)
    .linq.select(r => <string>(<Schema>r.schema).details.csharp.fullname)
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