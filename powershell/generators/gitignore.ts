/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@azure-tools/autorest-extension-base';
import { Project } from '../internal/project';

export async function generateGitIgnore(project: Project) {
  project.state.writeFile(project.gitIgnore, `bin
obj
.vs
generated
internal
exports
tools
test/*-TestResults.xml
license.txt
/*.ps1
/*.psd1
/*.ps1xml
/*.psm1
/*.snk
/*.csproj
/*.nuspec`, undefined, 'source-file-other');
}