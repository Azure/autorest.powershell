using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "CmdletSurface")]
    [DoNotExport]
    public class ExportCmdletSurface : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string CmdletFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        protected override void ProcessRecord()
        {
            var variants = GetScriptCmdlets(this, CmdletFolder)
                .SelectMany(fi => fi.ToVariants())
                .Where(v => !v.IsDoNotExport)
                .ToArray();
            var allProfiles = variants.SelectMany(v => v.Profiles).Distinct().ToArray();
            var profileGroups = allProfiles.Any()
                ? variants
                    .SelectMany(v => (v.Profiles.Any() ? v.Profiles : allProfiles).Select(p => (profile: p, variant: v)))
                    .GroupBy(pv => pv.profile)
                    .Select(pvg => new ProfileGroup(pvg.Select(pv => pv.variant).ToArray(), pvg.Key))
                : new[] { new ProfileGroup(variants) };
            foreach (var profileGroup in profileGroups)
            {
                var variantGroups = profileGroup.Variants
                    .GroupBy(v => new { v.CmdletName })
                    .Select(vg => new VariantGroup(vg.Key.CmdletName, vg.Select(v => v).ToArray(), String.Empty, profileGroup.ProfileName))
                    .OrderBy(vg => vg.CmdletName);
                var sb = new StringBuilder();
                foreach (var variantGroup in variantGroups)
                {
                    sb.Append($"### {variantGroup.CmdletName}{Environment.NewLine}");
                    foreach (var parameterGroup in variantGroup.ParameterGroups.Where(pg => !pg.DontShow).OrderBy(pg => pg.ParameterName))
                    {
                        sb.Append($"  - {parameterGroup.ParameterName}{Environment.NewLine}");
                    }
                    sb.AppendLine();
                }

                Directory.CreateDirectory(OutputFolder);
                File.WriteAllText(Path.Combine(OutputFolder, $"CmdletSurface-{profileGroup.ProfileName}.md"), sb.ToString());
            }
        }
    }
}
