---
external help file:
Module Name: Az.AppComplianceAutomation
online version: https://learn.microsoft.com/powershell/module/az.appcomplianceautomation/invoke-azappcomplianceautomationdownloadevidence
schema: 2.0.0
---

# Invoke-AzAppComplianceAutomationDownloadEvidence

## SYNOPSIS
Download evidence file.

## SYNTAX

### DownloadExpanded (Default)
```
Invoke-AzAppComplianceAutomationDownloadEvidence -EvidenceName <String> -ReportName <String>
 [-OfferGuid <String>] [-ReportCreatorTenantId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Download
```
Invoke-AzAppComplianceAutomationDownloadEvidence -EvidenceName <String> -ReportName <String>
 -Body <IEvidenceFileDownloadRequest> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaIdentity
```
Invoke-AzAppComplianceAutomationDownloadEvidence -InputObject <IAppComplianceAutomationIdentity>
 -Body <IEvidenceFileDownloadRequest> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaIdentityExpanded
```
Invoke-AzAppComplianceAutomationDownloadEvidence -InputObject <IAppComplianceAutomationIdentity>
 [-OfferGuid <String>] [-ReportCreatorTenantId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DownloadViaIdentityReport
```
Invoke-AzAppComplianceAutomationDownloadEvidence -EvidenceName <String>
 -ReportInputObject <IAppComplianceAutomationIdentity> -Body <IEvidenceFileDownloadRequest>
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaIdentityReportExpanded
```
Invoke-AzAppComplianceAutomationDownloadEvidence -EvidenceName <String>
 -ReportInputObject <IAppComplianceAutomationIdentity> [-OfferGuid <String>] [-ReportCreatorTenantId <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaJsonFilePath
```
Invoke-AzAppComplianceAutomationDownloadEvidence -EvidenceName <String> -ReportName <String>
 -JsonFilePath <String> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DownloadViaJsonString
```
Invoke-AzAppComplianceAutomationDownloadEvidence -EvidenceName <String> -ReportName <String>
 -JsonString <String> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Download evidence file.

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

### -Body
Evidence file's download request.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadRequest
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

### -EvidenceName
The evidence name.

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

### Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadRequest

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IEvidenceFileDownloadResponse

## NOTES

## RELATED LINKS

