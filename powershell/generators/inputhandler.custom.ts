/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../internal/project';

export async function generateInputHandlersCustom(project: Project) {
  const handlers = project.inputHandlers;
  for (const handler of handlers) {
    let content = await project.state.readFile(`${project.customFolder}\\input-handlers\\${handler}.cs`) || '';
    if (content !== '') {
      // skip generation since it has been generated before.
      continue;
    }
    content = `${project.csharpCommentHeader}

namespace ${project.projectNamespace}.Runtime.Cmdlets
{
    public class ${handler} : InputHandler
    {
        public override void Process( ${project.projectNamespace}.Runtime.IContext context)
        {
            // ToDO: Add the custom code here
            NextHandler?.Process(context);
        }
    }
}`;
    project.state.writeFile(`${project.customFolder}\\input-handlers\\${handler}.cs`, content, undefined, 'source-file-csharp');
  }
}