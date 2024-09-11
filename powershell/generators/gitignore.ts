/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutorestExtensionHost as Host } from '@autorest/extension-base';
import { Project } from '../internal/project';

export async function generateGitIgnore(project: Project) {
  project.state.writeFile(project.gitIgnore, `bin
obj
.vs
generated
internal
exports
tools
Properties
custom/*.psm1
custom/autogen-model-cmdlets
test/*-TestResults.xml
/*.ps1
/*.psd1
/*.ps1xml
/*.psm1
/*.snk
/*.csproj
/*.nuspec`, undefined, 'source-file-other');
}