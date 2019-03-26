using System;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "ScriptCmdlet")]
    [DoNotExport]
    public class ExportScriptCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ScriptFolder { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        protected override void ProcessRecord()
        {
            var functionExports = GetScriptCmdlets(this, ScriptFolder)
                .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
                .Select(fi => fi.Name).ToPsList();

            if (!String.IsNullOrEmpty(functionExports))
            {
                this.RunScript($"Export-ModuleMember -Function {functionExports}");
            }
        }
    }
}
