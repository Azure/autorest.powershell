using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ScriptCmdlet")]
    [OutputType(typeof(string[]))]
    [DoNotExport]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class GetScriptCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ScriptFolder { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(GetScriptCmdlets(this, ScriptFolder)
                .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
                .Select(fi => fi.Name), true);
        }
    }
}
