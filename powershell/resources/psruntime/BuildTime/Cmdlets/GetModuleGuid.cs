/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
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
      try
      {
        WriteObject(ReadGuidFromPsd1(Psd1Path));
      }
      catch (System.Exception ee)
      {
        System.Console.WriteLine($"${ee.GetType().Name}/{ee.StackTrace}");
        throw ee;
      }
    }
  }
}
