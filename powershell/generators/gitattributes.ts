/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../internal/project';

export async function generateGitAttributes(project: Project) {
  project.state.writeFile(project.gitAttributes, '* text=auto', undefined, 'source-file-other');
}