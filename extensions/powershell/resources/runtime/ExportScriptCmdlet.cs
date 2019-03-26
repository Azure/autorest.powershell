using System;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ScriptCmdlet")]
    [OutputType(typeof(string[]))]
    [DoNotExport]
    public class GetScriptCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ScriptFolder { get; set; }

        //[Parameter(Mandatory = true)]
        //[ValidateNotNullOrEmpty]
        //public EngineIntrinsics EngineIntrinsics { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(GetScriptCmdlets(this, ScriptFolder)
                .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
                .Select(fi => fi.Name), true);
            //var functionExports = GetScriptCmdlets(this, ScriptFolder)
            //    .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
            //    .Select(fi => fi.Name).ToPsList();

            ////var command = "Write-Information 'No script cmdlets to export';";
            //if (!String.IsNullOrEmpty(functionExports))
            //{
            //    //Console.WriteLine(functionExports);
            //    //command = GetScriptCmdletsCommand(ScriptFolder) + $"{Environment.NewLine}Export-ModuleMember -Function {functionExports};";

            //    //this.RunScript($"Export-ModuleMember -Function {functionExports}");
            //    EngineIntrinsics.RunScript($"Export-ModuleMember -Function {functionExports}");
            //}
            ////WriteObject(command);
        }
    }
}
