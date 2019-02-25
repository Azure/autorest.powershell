using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyOutputExtensions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.New, "TestStub")]
    [OutputType(typeof(string))]
    public class NewTestStub : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public CommandInfo[] CommandInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        private const string Indent = "    ";

        protected override void ProcessRecord()
        {
            var cmdletFilenameGroups = CommandInfo
                .Select(ci => {
                    var metadata = new CommandMetadata(ci);
                    var parts = metadata.Name.Split('_');
                    return (name: parts[0], variant: parts.Length > 1 ? parts[1] : NoParameters, info: ci, metadata: metadata);
                })
                .GroupBy(cg => cg.name)
                .Select(cg => (cmdletGroup: cg, filename: Path.Combine(OutputFolder, $"{cg.Key}.Tests.ps1")))
                .Where(cgf => !File.Exists(cgf.filename));
            foreach (var cmdletFilenameGroup in cmdletFilenameGroups)
            {
                var sb = new StringBuilder();
                sb.AppendLine($@". ""$PSScriptRoot/HttpPipelineMocking.ps1""{Environment.NewLine}");

                var cmdletName = cmdletFilenameGroup.cmdletGroup.Key;
                sb.AppendLine($"Describe '{cmdletName}' {{");
                var cmdletGroupList = cmdletFilenameGroup.cmdletGroup.ToList();

                foreach (var variantGroup in cmdletGroupList)
                {
                    sb.AppendLine($"{Indent}It '{variantGroup.variant}' {{");
                    sb.AppendLine($"{Indent}{Indent}{{ throw [System.NotImplementedException] }} | Should -Not -Throw");
                    var variantSeparator = cmdletGroupList.IndexOf(variantGroup) == cmdletGroupList.Count - 1 ? String.Empty : Environment.NewLine;
                    sb.AppendLine($"{Indent}}}{variantSeparator}");
                }
                sb.AppendLine("}");

                File.WriteAllText(cmdletFilenameGroup.filename, sb.ToString());
            }
        }
    }
}
