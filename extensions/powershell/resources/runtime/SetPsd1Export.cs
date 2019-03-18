using System;
using System.IO;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.Set, "Psd1Export")]
    [OutputType(typeof(string))]
    public class SetPsd1Export : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string[] CmdletNames { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Psd1Path { get; set; }

        private const string CmdletsToExport = "CmdletsToExport";
        private const string RegionExportStart = "# region exports";
        private const string ExportHeader = "  " + CmdletsToExport + " = ";
        private const string RegionExportEnd = "# endregion";

        protected override void ProcessRecord()
        {
            if (!File.Exists(Psd1Path))
            {
                throw new ArgumentException($"Psd1 file '{Psd1Path}' does not exist");
            }

            var psd1Lines = File.ReadAllLines(Psd1Path).ToList();
            var startRegionIndex = psd1Lines.Select((l, i) => (Line: l, Index: i)).Where(l => l.Line.StartsWith(RegionExportStart)).Select(li => (int?)li.Index).FirstOrDefault();
            if (startRegionIndex == null)
            {
                var tableEndIndex = psd1Lines.Select((l, i) => (Line: l, Index: i)).Where(l => l.Line.StartsWith("}")).Select(li => (int?)li.Index).LastOrDefault();
                if (tableEndIndex == null)
                {
                    throw new ArgumentException($"Cannot find hashtable end '}}' to insert {CmdletsToExport} list");
                }
                psd1Lines.Insert(tableEndIndex.Value, RegionExportStart);
                startRegionIndex = tableEndIndex.Value;
            }

            var exportIndex = startRegionIndex.Value + 1;
            var hasExportLine = psd1Lines[exportIndex].StartsWith(ExportHeader);
            if (!hasExportLine)
            {
                psd1Lines.Insert(exportIndex, String.Empty);
            }

            var exportList = CmdletNames.ToList();
            exportList.Add("*");
            psd1Lines[exportIndex] = $"{ExportHeader}{exportList.ToPsList()}";

            var endRegionIndex = exportIndex + 1;
            var hasEndRegionLine = psd1Lines[endRegionIndex].StartsWith(RegionExportEnd);
            if (!hasEndRegionLine)
            {
                psd1Lines.Insert(endRegionIndex, RegionExportEnd);
                psd1Lines.Insert(endRegionIndex + 1, String.Empty);
            }

            // https://stackoverflow.com/questions/11689337/net-file-writealllines-leaves-empty-line-at-the-end-of-file#comment15499548_11689503
            File.WriteAllText(Psd1Path, String.Join(Environment.NewLine, psd1Lines));
        }
    }
}
