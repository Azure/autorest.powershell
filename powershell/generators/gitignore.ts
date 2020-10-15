/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@azure-tools/autorest-extension-base';
import { NewProject } from '../internal/project';

export async function generateGitIgnore(project: NewProject) {
  project.state.writeFile(project.gitIgnore, `bin
obj
.vs
generated
internal
exports
tools
custom/*.psm1
test/*-TestResults.xml
/*.ps1
/*.ps1xml
/*.psm1
/*.snk
/*.csproj
/*.nuspec`, undefined, 'source-file-other');
}