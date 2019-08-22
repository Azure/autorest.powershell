using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyOutputExtensions;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "TestStub")]
    [DoNotExport]
    public class ExportTestStub : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ModuleName { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ExportsFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        [Parameter]
        public SwitchParameter IncludeGenerated { get; set; }

        private const string RuntimeFolder = @"${$lib.path.relative($project.testFolder, $project.runtimeFolder)}";

        protected override void ProcessRecord()
        {
            if (!Directory.Exists(ExportsFolder))
            {
                throw new ArgumentException($"Exports folder '{ExportsFolder}' does not exist");
            }

            var exportDirectories = Directory.GetDirectories(ExportsFolder);
            if (!exportDirectories.Any())
            {
                exportDirectories = new[] { ExportsFolder };
            }

            foreach (var exportDirectory in exportDirectories)
            {
                var outputFolder = OutputFolder;
                if (exportDirectory != ExportsFolder)
                {
                    outputFolder = Path.Combine(OutputFolder, Path.GetFileName(exportDirectory));
                    Directory.CreateDirectory(outputFolder);
                }

                var variantGroups = GetScriptCmdlets(exportDirectory)
                    .SelectMany(fi => fi.ToVariants())
                    .Where(v => !v.IsDoNotExport)
                    .GroupBy(v => v.CmdletName)
                    .Select(vg => new VariantGroup(ModuleName, vg.Key, vg.Select(v => v).ToArray(), outputFolder, isTest: true))
                    .Where(vtg => !File.Exists(vtg.FilePath) && (IncludeGenerated || !vtg.IsGenerated));

                foreach (var variantGroup in variantGroups)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine($@"$TestRecordingFile = Join-Path $PSScriptRoot '{variantGroup.CmdletName}.Recording.json'");
                    sb.AppendLine($@". (Join-Path $PSScriptRoot '{RuntimeFolder}' 'HttpPipelineMocking.ps1'){Environment.NewLine}");

                    sb.AppendLine($"Describe '{variantGroup.CmdletName}' {{");
                    var variants = variantGroup.Variants
                        .Where(v => IncludeGenerated || !v.Attributes.OfType<GeneratedAttribute>().Any())
                        .ToList();

                    foreach (var variant in variants)
                    {
                        sb.AppendLine($"{Indent}It '{variant.VariantName}' {{");
                        sb.AppendLine($"{Indent}{Indent}{{ throw [System.NotImplementedException] }} | Should -Not -Throw");
                        var variantSeparator = variants.IndexOf(variant) == variants.Count - 1 ? String.Empty : Environment.NewLine;
                        sb.AppendLine($"{Indent}}}{variantSeparator}");
                    }
                    sb.AppendLine("}");

                    File.WriteAllText(variantGroup.FilePath, sb.ToString());
                }
            }
        }
    }
}
