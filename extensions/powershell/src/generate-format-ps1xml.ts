import * as XmlBuilder from 'xmlbuilder';
import { codemodel, JsonType } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from './project';
import { length, values } from '@microsoft.azure/codegen';
import { Schema } from '@microsoft.azure/autorest.csharp-v2';

export function generateFormatPs1xml(service: Host, model: codemodel.Model, project: Project) {
  const viewModels = values(model.schemas)
    .linq.where(s => s.type === JsonType.Object && (length(s.properties) || length(s.allOf)) && s.details.csharp.fullname)
    .linq.select(s => ({ schema: <Schema>s, className: <string>s.details.csharp.fullname }))
    .linq.select(x => createViewModel(x.schema, x.className));

  const ps1xml = XmlBuilder.create({
    Configuration: {
      ViewDefinitions: viewModels.linq.toArray()
    }
  });
  service.WriteFile(`${project.moduleName}.format.ps1xml`, ps1xml.end({ pretty: true }), undefined, 'source-file-other');
}

function createViewModel(schema: Schema, className: string): object {
  const allOfProperties = values(schema.allOf).linq.selectMany(a => values(a.properties));
  const topLevelProperties = values(schema.properties);

  const entries = values([...allOfProperties, ...topLevelProperties])
    .linq.select(p => {
      const propName = p.details.csharp.name;
      return {
        HeaderEntry: {
          TableColumnHeader: {
            Label: propName
          }
        },
        ItemEntry: {
          TableColumnItem: {
            PropertyName: propName
          }
        }
      }
    }).linq.toArray();

  return {
    View: {
      Name: className,
      ViewSelectedBy: [{
        TypeName: className
      }],
      TableControl: {
        TableHeaders: values(entries).linq.select(e => e.HeaderEntry).linq.toArray(),
        TableRowEntries: {
          TableRowEntry: {
            TableColumnItems: values(entries).linq.select(e => e.ItemEntry).linq.toArray()
          }
        }
      }
    }
  }
}