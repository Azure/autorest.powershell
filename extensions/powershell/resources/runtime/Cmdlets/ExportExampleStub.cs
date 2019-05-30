using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.MarkdownTypesExtensions;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "ExampleStub")]
    [DoNotExport]
    public class ExportExampleStub : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ExportsFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        protected override void ProcessRecord()
        {
            if (!Directory.Exists(ExportsFolder))
            {
                throw new ArgumentException($"Exports folder '{ExportsFolder}' does not exist");
            }

            var directories = Directory.GetDirectories(ExportsFolder);
            if (!directories.Any())
            {
                directories = new[] { ExportsFolder };
            }

            var exampleText = String.Join(String.Empty, DefaultExampleHelpInfos.Select(ehi => ehi.ToHelpExampleOutput()));
            foreach (var directory in directories)
            {
                var outputFolder = OutputFolder;
                if (directory != ExportsFolder)
                {
                    outputFolder = Path.Combine(OutputFolder, Path.GetFileName(directory));
                    Directory.CreateDirectory(outputFolder);
                }

                var filePaths = GetScriptCmdlets(directory).Select(fi => Path.Combine(outputFolder, $"{fi.Name}.md")).Where(f => !File.Exists(f));
                foreach (var filePath in filePaths)
                {
                    File.WriteAllText(filePath, exampleText);
                }
            }
        }
    }
}
