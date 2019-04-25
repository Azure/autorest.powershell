using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.Set, "Psd1Export")]
    [DoNotExport]
    public class SetPsd1Export : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ExportsFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Psd1Path { get; set; }

        private const string CmdletsToExport = "CmdletsToExport";
        private const string AliasesToExport = "AliasesToExport";
        private const string RegionExportStart = "# region exports";
        private const string CmdletsHeader = "  " + CmdletsToExport + " = ";
        private const string AliasesHeader = "  " + AliasesToExport + " = ";
        private const string RegionExportEnd = "# endregion";

        protected override void ProcessRecord()
        {
            if (!Directory.Exists(ExportsFolder))
            {
                throw new ArgumentException($"Exports folder '{ExportsFolder}' does not exist");
            }

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

            var cmdletsIndex = startRegionIndex.Value + 1;
            var hasCmdletsLine = psd1Lines[cmdletsIndex].StartsWith(CmdletsHeader);
            if (!hasCmdletsLine)
            {
                psd1Lines.Insert(cmdletsIndex, String.Empty);
            }

            var functionInfos = GetScriptCmdlets(ExportsFolder).ToArray();
            var cmdlets = functionInfos.Select(sc => sc.Name).Distinct().Append("*").ToArray();
            psd1Lines[cmdletsIndex] = $"{CmdletsHeader}{cmdlets.ToPsList()}";

            var aliasesIndex = cmdletsIndex + 1;
            var hasAliasesLine = psd1Lines[aliasesIndex].StartsWith(AliasesHeader);
            if (!hasAliasesLine)
            {
                psd1Lines.Insert(aliasesIndex, String.Empty);
            }

            var aliases = functionInfos.SelectMany(i => i.ScriptBlock.Attributes).ToAliasNames().Append("*").ToArray();
            psd1Lines[aliasesIndex] = $"{AliasesHeader}{aliases.ToPsList()}";

            var endRegionIndex = aliasesIndex + 1;
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
