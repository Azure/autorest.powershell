/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@azure/autorest-extension-base';
import { Project } from '../project';

export async function generateGitAttributes(project: Project) {
  project.state.writeFile(project.gitAttributes, '* text=auto', undefined, 'source-file-other');
}