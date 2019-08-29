/* eslint-disable no-useless-escape */
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../project';
import { serialize, indent, setIndentation, applyOverrides, pascalCase } from '@azure/codegen';
import { items, values, keys, Dictionary, length } from '@azure/linq';
import { State } from '../state';

import { dotnet, System } from '@azure/codegen-csharp';
import { PSScriptFile } from '../file-formats/psscript-file';
import { ClientRuntime } from '@azure/autorest.csharp-v2';

interface ScenarioParameter extends Dictionary<any> {
  type: string;
  description: string;
  required?: boolean;
}

interface ScenarioCommand extends Dictionary<any> {
  action: string;
  subject: string;
  variant: string;
  description: string;
  output?: string;
  link?: string;
  writeable?: boolean;
  'as-job'?: boolean;

  parameters?: Dictionary<ScenarioParameter>;
}

function getType(type: string) {
  if (type) {
    switch (type.toLowerCase()) {
      case 'string':
        return 'System.String';
      case 'int':
      case 'number':
        return 'System.Int';
      case 'boolean':
      case 'bool':
      case 'switch':
        return 'System.Management.Automation.SwitchParameter';
      case 'object':
        return 'System.Object';
    }
  }
  return type;
}

export async function generateScriptCmdlets(project: Project) {
  const commands = await project.state.getValue<Array<ScenarioCommand>>('command', []);
  for (const command of values(commands)) {
    if (!command.action) {
      await project.state.error(`Scenario command is missing 'action' : ${serialize(command)}`, []);
      continue;
    }
    if (!command.subject) {
      await project.state.error(`Scenario command is missing 'subject' : ${serialize(command)}`, []);
      continue;
    }

    const verbMap = await project.state.getValue('verb-mapping', new Dictionary<string>());
    command.verb = verbMap[command.action] || command.action.capitalize();
    command.variant = command.variant ? `_${pascalCase(command.variant)}` : '';
    command.subject = pascalCase(command.subject);

    const filename = `${project.customFolder}/${command.verb}-${command.subject}${command.variant}.ps1`;
    const content = await project.state.readFile(filename);

    if (content) {
      project.state.writeFile(filename, content, undefined, 'source-file-powershell');
    } else {
      setIndentation(2);
      const script = new PSScriptFile();
      script.add(function* () {
        yield `<#
.Synopsis
${command.description || ''}
.Description
${command.description || ''}
.Link
${command.link || ''}
#>`;

        yield `function ${command.verb}-${command.subject}${command.variant} {`;
        if (command.output) {
          yield `[OutputType('${getType(command.output)}')]`;
        }
        yield command.writeable ? '[CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact=\'Medium\')]' : '[CmdletBinding(PositionalBinding=$false)]';
        yield 'param(';

        if (command.parameters) {
          for (const { key: name, value: parameter } of items(command.parameters)) {
            yield indent(`[Parameter(${parameter.required === false ? '' : 'Mandatory'})]`);
            yield indent(`[${getType(parameter.type)}]`);
            if (parameter.description) {
              yield indent(`# ${parameter.description}`);
            }
            yield indent(`$\{${pascalCase(name)}\},`);
            yield '';

          }
        }

        if (project.azure) {
          yield indent(`
[Parameter()]
[Alias('AzureRMContext', 'AzureCredential')]
[ValidateNotNull()]
[System.Management.Automation.PSObject]
# The credentials, account, tenant, and subscription used for communication with Azure.
$\{DefaultProfile\},`);
          yield '';
        }

        if (command['as-job']) {
          yield indent(`
[Parameter()]
[System.Management.Automation.SwitchParameter]
# Run the command as a job
$\{AsJob\},`);
          yield '';
        }


        yield indent(`
[Parameter(DontShow)]
[System.Management.Automation.SwitchParameter]
# Wait for .NET debugger to attach
$\{Break\},

[Parameter(DontShow)]
[ValidateNotNull()]
[${ClientRuntime.SendAsyncSteps}
# SendAsync Pipeline Steps to be appended to the front of the pipeline
$\{HttpPipelineAppend\},

[Parameter(DontShow)]
[ValidateNotNull()]
[${ClientRuntime.SendAsyncSteps}]
# SendAsync Pipeline Steps to be prepended to the front of the pipeline
$\{HttpPipelinePrepend\},

[Parameter(DontShow)]
[System.Uri]
# The URI for the proxy server to use
$\{Proxy\},

[Parameter(DontShow)]
[ValidateNotNull()]
[System.Management.Automation.PSCredential]
# Credentials for a proxy server to use for the remote call
$\{ProxyCredential\},

[Parameter(DontShow)]
[System.Management.Automation.SwitchParameter]
# Use the default credentials for the proxy
$\{ProxyUseDefaultCredentials\}
`);

        yield ')';
        yield indent(`process {
  try {
    # do something with your custom parameters
    # $PSBoundParameters.Add("Filter", "appId eq '$ApplicationId'") | Out-Null
    # $PSBoundParameters.Remove("ApplicationId") | Out-Null

    # Examples
    # To call a specific variant in the private module
    # ${project.prefix}${project.moduleName}.private\\${command.verb}-${command.subject}_SomeVariant @PSBoundParameters

    # To call back to the same public module (and call the exported cmdlet)
    # ${project.prefix}${project.moduleName}\\${command.verb}-${command.subject} @PSBoundParameters

    # To call something in the internal module
    # ${project.prefix}${project.moduleName}.internal\\${command.verb}-${command.subject} @PSBoundParameters

  } catch {
    throw
  }
}`);
        yield '}';

      });


      project.state.writeFile(filename, applyOverrides(`${script}`, project.overrides), undefined, 'source-file-powershell');
    }
  }
  /* 
  <#
  .Synopsis
  Export data from the redis cache to blobs in a container.
  .Description
  Export data from the redis cache to blobs in a container.
  .Link
  https://docs.microsoft.com/en-us/powershell/module/az.redis/export-azredisredisdata
  #>
  function Export-AzRedisRedisData {
  [OutputType('System.Boolean')]
  [CmdletBinding(DefaultParameterSetName='ExportSubscriptionIdViaHost', SupportsShouldProcess, ConfirmImpact='Medium')]
  param(
      [Parameter(Mandatory)]
      [System.String]
      # The name of the Redis cache.
      ${Name},
  
      [Parameter(Mandatory)]
      [System.String]
      # The name of the resource group.
      ${ResourceGroupName},
  
      [Parameter(ParameterSetName='Export', Mandatory)]
      [Parameter(ParameterSetName='ExportExpanded', Mandatory)]
      [System.String]
      # Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
      ${SubscriptionId},
  
      [Parameter(ParameterSetName='Export', ValueFromPipeline)]
      [Parameter(ParameterSetName='ExportSubscriptionIdViaHost', ValueFromPipeline)]
      [Microsoft.Azure.PowerShell.Cmdlets.Redis.Models.Api20180301.IExportRdbParameters]
      # Parameters for Redis export operation.
      ${Parameters},
  
      [Parameter()]
      [System.Management.Automation.SwitchParameter]
      # When specified, PassThru will force the cmdlet return a 'bool' given that there isn't a return type by default.
      ${PassThru},
  
      [Parameter(ParameterSetName='ExportExpanded', Mandatory)]
      [Parameter(ParameterSetName='ExportSubscriptionIdViaHostExpanded', Mandatory)]
      [System.String]
      # Container name to export to.
      ${Container},
  
      [Parameter(ParameterSetName='ExportExpanded')]
      [Parameter(ParameterSetName='ExportSubscriptionIdViaHostExpanded')]
      [System.String]
      # File format.
      ${Format},
  
      [Parameter(ParameterSetName='ExportExpanded', Mandatory)]
      [Parameter(ParameterSetName='ExportSubscriptionIdViaHostExpanded', Mandatory)]
      [System.String]
      # Prefix to use for exported files.
      ${Prefix},
  
      [Parameter()]
      [Alias('AzureRMContext', 'AzureCredential')]
      [ValidateNotNull()]
      [System.Management.Automation.PSObject]
      # The credentials, account, tenant, and subscription used for communication with Azure.
      ${DefaultProfile},
  
      [Parameter()]
      [System.Management.Automation.SwitchParameter]
      # Run the command as a job
      ${AsJob},
  
      [Parameter(DontShow)]
      [System.Management.Automation.SwitchParameter]
      # Wait for .NET debugger to attach
      ${Break},
  
      [Parameter(DontShow)]
      [ValidateNotNull()]
      [Microsoft.Azure.PowerShell.Cmdlets.Redis.Runtime.SendAsyncStep[]]
      # SendAsync Pipeline Steps to be appended to the front of the pipeline
      ${HttpPipelineAppend},
  
      [Parameter(DontShow)]
      [ValidateNotNull()]
      [Microsoft.Azure.PowerShell.Cmdlets.Redis.Runtime.SendAsyncStep[]]
      # SendAsync Pipeline Steps to be prepended to the front of the pipeline
      ${HttpPipelinePrepend},
  
      [Parameter(DontShow)]
      [System.Uri]
      # The URI for the proxy server to use
      ${Proxy},
  
      [Parameter(DontShow)]
      [ValidateNotNull()]
      [System.Management.Automation.PSCredential]
      # Credentials for a proxy server to use for the remote call
      ${ProxyCredential},
  
      [Parameter(DontShow)]
      [System.Management.Automation.SwitchParameter]
      # Use the default credentials for the proxy
      ${ProxyUseDefaultCredentials}
  )
  
  begin {
      try {
          $outBuffer = $null
          if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
              $PSBoundParameters['OutBuffer'] = 1
          }
          $parameterSet = $PsCmdlet.ParameterSetName
          $mapping = @{
              Export = 'Az.Redis.private\Export-AzRedisRedisData_Export';
              ExportExpanded = 'Az.Redis.private\Export-AzRedisRedisData_ExportExpanded';
              ExportSubscriptionIdViaHost = 'Az.Redis.private\Export-AzRedisRedisData_ExportSubscriptionIdViaHost';
              ExportSubscriptionIdViaHostExpanded = 'Az.Redis.private\Export-AzRedisRedisData_ExportSubscriptionIdViaHostExpanded';
          }
          $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
          $scriptCmd = {& $wrappedCmd @PSBoundParameters}
          $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
          $steppablePipeline.Begin($PSCmdlet)
      } catch {
          throw
      }
  }
  
  process {
      try {
          $steppablePipeline.Process($_)
      } catch {
          throw
      }
  }
  
  end {
      try {
          $steppablePipeline.End()
      } catch {
          throw
      }
  }
  }
  
  */
}