/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../internal/project';

export async function generateAssemblyInfo(project: Project) {
  const info = `${project.csharpCommentHeaderForCsharp}

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: System.Reflection.AssemblyCompanyAttribute("${project.assemblyCompany}")]
[assembly: System.Reflection.AssemblyCopyrightAttribute("${project.assemblyCopyright}")]
[assembly: System.Reflection.AssemblyProductAttribute("${project.assemblyProduct}")]
[assembly: System.Reflection.AssemblyTitleAttribute("${project.assemblyProduct} - ${project.title}")]
[assembly: System.Reflection.AssemblyFileVersionAttribute("0.1.0.0")]
[assembly: System.Reflection.AssemblyVersionAttribute("0.1.0.0")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.CLSCompliantAttribute(false)]`;

  project.state.writeFile(project.assemblyInfoPath, info, undefined, 'source-file-csharp');
}