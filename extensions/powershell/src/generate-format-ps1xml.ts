import * as XmlBuilder from 'xmlbuilder';
import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from './project';

export function generateFormatPs1xml(service: Host, model: codemodel.Model, project: Project) {

  const ps1xmlModel = {
    Configuration: {
      ViewDefinitions: {
      }
    }
  };
  const viewModel = {
    View: {
      Name: '',
      ViewSelectedBy: {
      },
      TableControl: {
        TableHeaders: {
        },
        TableRowEntries: {
          TableRowEntry: {
            TableColumnItems: {
            }
          }
        }
      }
    }
  }
  // model.commands.parameters.
  project.

  const ps1xml = XmlBuilder.create(ps1xmlModel);
  service.WriteFile(`${project.moduleName}.format.ps1xml`, ps1xml.toString(), undefined, 'source-file-other');
}