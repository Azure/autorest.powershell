/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';

export async function generateGitIgnore(service: Host, project: Project) {
  service.WriteFile(project.gitIgnore, `bin
obj
.vs
generated
internal
exports
custom/*.psm1
test/*-TestResults.xml
/*.ps1
/*.ps1xml
/*.psm1
/*.snk
/*.csproj
/*.nuspec`, undefined, 'source-file-other');
}