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
        private readonly string assemblyInfoPath = Path.Combine("${$project.baseFolder}", "Properties", "AssemblyInfo.cs");
        private const string assemblyName = "${$project.title}";
        private const string assemblyVersion = "${$project.moduleVersion}";
        private const string assemblyCompanyName = "${$project.assemblyCompany}";
        private const string assemblyProduct = "${$project.assemblyProduct}";
        private const string assemblyCopyright = "${$project.assemblyCopyright}";
        protected override void ProcessRecord()
        {
            try
            {
                if (File.Exists(assemblyInfoPath))
                {
                    return;
                }
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(@"
# ----------------------------------------------------------------------------------
${$project.pwshCommentHeaderForCsharp}
# ----------------------------------------------------------------------------------
");
                sb.Append($"{Environment.NewLine}");
                sb.AppendLine("using System;");
                sb.AppendLine("using System.Reflection;");
                sb.AppendLine("using System.Runtime.InteropServices;");
                sb.Append($"{Environment.NewLine}");
                sb.AppendLine($"[assembly: AssemblyTitle(\"Microsoft Azure Powershell - {assemblyName}\")]");
                sb.AppendLine($"[assembly: AssemblyCompany({assemblyCompanyName})]");
                sb.AppendLine($"[assembly: AssemblyProduct({assemblyProduct})]");
                sb.AppendLine($"[assembly: AssemblyCopyright({assemblyCopyright})]");
                sb.Append($"{Environment.NewLine}");
                sb.AppendLine("[assembly: ComVisible(false)]");
                sb.AppendLine("[assembly: CLSCompliant(false)]");
                sb.AppendLine($"[assembly: Guid(\"{Guid.NewGuid()}\")]");
                sb.AppendLine($"[assembly: AssemblyVersion(\"{assemblyVersion}\")]");
                sb.Append($"[assembly: AssemblyFileVersion(\"{assemblyVersion}\")]");

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