using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ModuleGuid")]
    [DoNotExport]
    public class GetModuleGuid : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Psd1Path { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(ReadGuidFromPsd1(Psd1Path));
        }
    }
}
