/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';

export async function generateGitAttributes(service: Host, project: Project) {
  service.WriteFile(project.gitAttributes, `* text=auto`, undefined, 'source-file-other');
}