---
external help file:
Module Name: Az.AppComplianceAutomation
online version: https://learn.microsoft.com/powershell/module/az.appcomplianceautomation/invoke-azappcomplianceautomationdownloadsnapshot
schema: 2.0.0
---

# Invoke-AzAppComplianceAutomationDownloadSnapshot

## SYNOPSIS
Download compliance needs from snapshot, like: Compliance Report, Resource List.

## SYNTAX

### DownloadExpanded (Default)
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -ReportName <String> -SnapshotName <String>
 -DownloadType <String> [-OfferGuid <String>] [-ReportCreatorTenantId <String>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Download
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -ReportName <String> -SnapshotName <String>
 -Body <ISnapshotDownloadRequest> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DownloadViaIdentity
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -InputObject <IAppComplianceAutomationIdentity>
 -Body <ISnapshotDownloadRequest> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DownloadViaIdentityExpanded
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -InputObject <IAppComplianceAutomationIdentity>
 -DownloadType <String> [-OfferGuid <String>] [-ReportCreatorTenantId <String>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaIdentityReport
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -ReportInputObject <IAppComplianceAutomationIdentity>
 -SnapshotName <String> -Body <ISnapshotDownloadRequest> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaIdentityReportExpanded
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -ReportInputObject <IAppComplianceAutomationIdentity>
 -SnapshotName <String> -DownloadType <String> [-OfferGuid <String>] [-ReportCreatorTenantId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaJsonFilePath
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -ReportName <String> -SnapshotName <String>
 -JsonFilePath <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DownloadViaJsonString
```
Invoke-AzAppComplianceAutomationDownloadSnapshot -ReportName <String> -SnapshotName <String>
 -JsonString <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Download compliance needs from snapshot, like: Compliance Report, Resource List.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Snapshot's download request.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotDownloadRequest
Parameter Sets: Download, DownloadViaIdentity, DownloadViaIdentityReport
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DownloadType
Indicates the download type.

```yaml
Type: System.String
Parameter Sets: DownloadExpanded, DownloadViaIdentityExpanded, DownloadViaIdentityReportExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IAppComplianceAutomationIdentity
Parameter Sets: DownloadViaIdentity, DownloadViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Download operation

```yaml
Type: System.String
Parameter Sets: DownloadViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Download operation

```yaml
Type: System.String
Parameter Sets: DownloadViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfferGuid
The offerGuid which mapping to the reports.

```yaml
Type: System.String
Parameter Sets: DownloadExpanded, DownloadViaIdentityExpanded, DownloadViaIdentityReportExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReportCreatorTenantId
Tenant id.

```yaml
Type: System.String
Parameter Sets: DownloadExpanded, DownloadViaIdentityExpanded, DownloadViaIdentityReportExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReportInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IAppComplianceAutomationIdentity
Parameter Sets: DownloadViaIdentityReport, DownloadViaIdentityReportExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ReportName
Report Name.

```yaml
Type: System.String
Parameter Sets: Download, DownloadExpanded, DownloadViaJsonFilePath, DownloadViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SnapshotName
Snapshot Name.

```yaml
Type: System.String
Parameter Sets: Download, DownloadExpanded, DownloadViaIdentityReport, DownloadViaIdentityReportExpanded, DownloadViaJsonFilePath, DownloadViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IAppComplianceAutomationIdentity

### Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotDownloadRequest

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse

## NOTES

## RELATED LINKS

