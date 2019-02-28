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

        protected override void ProcessRecord()
        {
            var variantGroups = CommandInfo
                .Select(ci => ci.ToVariant())
                .GroupBy(v => v.CmdletName)
                .Select(vg => new VariantTestGroup(vg.Key, vg.Select(v => v).ToArray(), Path.Combine(OutputFolder, $"{vg.Key}.Tests.ps1")))
                .Where(vtg => !File.Exists(vtg.Filename) && !vtg.IsGenerated);

            foreach (var variantGroup in variantGroups)
            {
                var sb = new StringBuilder();
                sb.AppendLine($@". ""$PSScriptRoot/HttpPipelineMocking.ps1""{Environment.NewLine}");

                sb.AppendLine($"Describe '{variantGroup.CmdletName}' {{");
                var variants = variantGroup.Variants
                    .Where(v => !v.Attributes.OfType<GeneratedAttribute>().Any())
                    .ToList();

                foreach (var variant in variants)
                {
                    sb.AppendLine($"{Indent}It '{variant.VariantName}' {{");
                    sb.AppendLine($"{Indent}{Indent}{{ throw [System.NotImplementedException] }} | Should -Not -Throw");
                    var variantSeparator = variants.IndexOf(variant) == variants.Count - 1 ? String.Empty : Environment.NewLine;
                    sb.AppendLine($"{Indent}}}{variantSeparator}");
                }
                sb.AppendLine("}");

                File.WriteAllText(variantGroup.Filename, sb.ToString());
            }
        }
    }
}
