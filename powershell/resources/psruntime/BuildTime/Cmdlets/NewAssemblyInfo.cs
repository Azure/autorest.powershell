/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet("New", "AssemblyInfo")]
    [DoNotExport]
    public class NewAssemblyInfo : PSCmdlet
    {
        private const string baseFolder = "${project.baseFolder}";
        private const string propertiesFolderName = "Properties";
        private const string assemblyInfoFileName = "AssemblyInfo.cs";
        private const string assemblyInfoPath = Path.Combine(baseFolder, propertiesFolderName, assemblyInfoFileName);
        private const string assemblyName = "${project.moduleName}";
        private const string assemblyVersion = "${project.moduleVersion}";

        protected override void ProcessRecord()
        {
            try
            {
                if (File.Exists(assemblyInfoPath))
                {
                    return;
                }
                StringBuilder sb = new StringBuilder();
                sb.Append(@"
# ----------------------------------------------------------------------------------
${$project.pwshCommentHeaderForCsharp}
# ----------------------------------------------------------------------------------
");
                sb.Append($"{Environment.NewLine}");
                sb.Append("using System;");
                sb.Append("using System.Reflection;");
                sb.Append("using System.Runtime.InteropServices;");
                sb.Append($"{Environment.NewLine}");
                sb.Append($"[assembly: AssemblyTitle(\"Microsoft Azure Powershell - ${assemblyName}\")]");
                sb.Append("[assembly: AssemblyCompany(Microsoft.WindowsAzure.Commands.Common.AzurePowerShell.AssemblyCompany)]");
                sb.Append("[assembly: AssemblyProduct(Microsoft.WindowsAzure.Commands.Common.AzurePowerShell.AssemblyProduct)]");
                sb.Append("[assembly: AssemblyCopyright(Microsoft.WindowsAzure.Commands.Common.AzurePowerShell.AssemblyCopyright)]");
                sb.Append($"{Environment.NewLine}");
                sb.Append("[assembly: ComVisible(false)]");
                sb.Append("[assembly: CLSCompliant(false)]");
                sb.Append($"[assembly: Guid(\"${Guid.NewGuid()}\")]");
                sb.Append($"[assembly: AssemblyVersion(\"${assemblyVersion}\")]");
                sb.Append($"[assembly: AssemblyFileVersion(\"${assemblyVersion}\")]");

                FileInfo assemblyInfo = new FileInfo(assemblyInfoPath);
                assemblyInfo.Directory.Create();
                File.WriteAllText(assemblyInfo.FullName, sb.ToString());
            }
            catch (Exception ee)
            {
                Console.WriteLine($"${ee.GetType().Name}/{ee.StackTrace}");
                throw ee;
            }
        }
    }
}