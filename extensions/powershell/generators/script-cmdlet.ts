/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../project';

export async function generateScriptCmdlets(project: Project) {
  const directives = await project.state.getValue<any>('directive', {});

  //console.error(JSON.stringify(directives, undefined, 2));


}