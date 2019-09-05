### Autorest plugin configuration
- Please don't edit this section unless you're re-configuring how the powershell extension plugs in to AutoRest
AutoRest needs the below config to pick this up as a plug-in - see https://github.com/Azure/autorest/blob/master/docs/developer/architecture/AutoRest-extension.md


> Values
``` yaml
module-version: 0.1.0
skip-model-cmdlets: false
help-link-prefix: https://docs.microsoft.com/en-us/powershell/module/
metadata:
  authors: ''
  owners: ''
  requireLicenseAcceptance: false
  description: ''
  copyright: ''
  tags: ''
  companyName: ''
  licenseUri: ''
  projectUri: ''
```

> Names
``` yaml
prefix: ''
subject-prefix: ''
module-name: $(service-name)
dll-name: $(module-name).private
```

> Folders
``` yaml
use-namespace-folders: false
current-folder: .
module-folder: $(current-folder)/generated
cmdlet-folder: $(module-folder)/cmdlets
model-cmdlet-folder: $(module-folder)/model-cmdlets
custom-cmdlet-folder: $(current-folder)/custom
internal-cmdlet-folder: $(current-folder)/internal
test-folder: $(current-folder)/test
runtime-folder: $(module-folder)/runtime
api-folder: $(module-folder)/api
bin-folder: $(current-folder)/bin
obj-folder: $(current-folder)/obj
exports-folder: $(current-folder)/exports
docs-folder: $(current-folder)/docs
dependency-module-folder: $(module-folder)/modules
examples-folder: $(current-folder)/examples
resources-folder: $(current-folder)/resources
```

> File Paths
``` yaml
csproj: $(current-folder)/$(module-name).csproj
dll: $(bin-folder)/$(dll-name).dll
psd1: $(current-folder)/$(module-name).psd1
psm1: $(current-folder)/$(module-name).psm1
psm1-custom: $(custom-cmdlet-folder)/$(module-name).custom.psm1
psm1-internal: $(internal-cmdlet-folder)/$(module-name).internal.psm1
format-ps1xml: $(current-folder)/$(module-name).format.ps1xml
nuspec: $(current-folder)/$(module-name).nuspec
```

``` yaml
declare-directive:
  no-inline: >-
    (() => {
      return {
        from: "code-model-v3", 
        where: (Array.isArray($) ? $ : [$]).map( each => `$.schemas[?(/^${each}$/i.exec(@.details.default.name))]`),
        transform: "$.details.default['skip-inline'] = true;"
      };
    })()
```

# Pipeline Configuration
``` yaml
pipeline:
# --- extension remodeler ---

  # "Shake the tree", and normalize the model
  remodeler:
    input: openapi-document/multi-api/identity     # the plugin where we get inputs from
  
  # allow developer to do transformations on the code model. 
  remodeler/new-transform: 
    input: remodeler 

  # Make some interpretations about what some things in the model mean
  tweakcodemodel:
    input: remodeler/new-transform

  # Specific things for Azure
  tweakcodemodelazure:
    input: tweakcodemodel

# --- extension powershell ---

  # creates high-level commands
  create-commands:
    input: tweakcodemodelazure # brings the code-model-v3 with it.

  create-virtual-properties:
    input: create-commands
    
  # Choose names for everything in c#
  csnamer:
    input: create-virtual-properties # and the generated c# files

  # ensures that names/descriptions are properly set for powershell
  psnamer:
    input: csnamer 

  modifiers:
    input: psnamer

  add-azure-completers:
    input: modifiers

  # creates powershell cmdlets for high-level commands. (leverages llc# code)
  powershell:
    input: add-azure-completers # and the generated c# files

# --- extension llcsharp  --- 
  # generates c# files for http-operations
  llcsharp:
    input: modifiers

  llcsharp/text-transform:
    input: llcsharp
    scope: scope-here

  powershell/text-transform:
    input:  powershell
    scope: scope-here

  llcsharp/emitter:
    input: text-transform
    scope: scope-here
    output-artifact: source-file-csharp

  powershell/emitter:
    input: text-transform
    scope: scope-here
    output-artifact: source-file-csharp

scope-here:
  is-object: false
  output-artifact:
    - source-file-csharp
    - source-file-csproj
    - source-file-powershell
    - source-file-other
    - binary-file
    - preserved-files


# Specific Settings for cm emitting - selects the file types and format that cmv2-emitter will spit out.
code-model-emitter-settings:
  input-artifact: code-model-v3
  is-object: true
  output-uri-expr: |
    "code-model-v3"

# testing:  ask for the files we need
output-artifact:
  - source-file-csharp
  - source-file-csproj
  - source-file-powershell
  - source-file-other
  - binary-file
  - preserved-files  
  
directive: 
  - reason: FixFromXML
    from: source-file-csharp
    where: $
    transform: return $.replace( /FromXml/g , 'FromJson');


```

The following verb-mapping is used as an aid to infer cmdlet-verbs. Every entry maps an operationId-method to a PowerShell cmdlet-verb. The operationId-method is the identifier that comes after the underscore in the operationId. For example:
- In MyResource_List, the method is List.
- In SomeAPI_CheckNameAvailability, the method is CheckNameAvailability.

Note: It is not necessary to have an entry for every method because AutoRest will still be able to infer a verb by examining the operationId. However, if an entry is added in the configuration, it is guaranteed that the cmdlet created will get the cmdlet-verb from the operationId-method -> cmdlet verb mapping.

``` yaml
verb-mapping:
  Access: Get
  Acquire: Get
  Activate: Initialize
  Add: Add
  Allocate: New
  Analyze: Test
  Append: Add
  Apply: Add
  Approve: Approve
  Assert: Assert
  Assign: Set
  Associate: Join
  Attach: Add
  Authorize: Grant
  Backup: Backup
  Block: Block
  Build: Build
  Bypass: Skip
  Cancel: Stop
  Capture: Export
  Cat: Get
  Change: Rename
  Check: Test
  Checkpoint: Checkpoint
  Clear: Clear
  Clone: Copy
  Close: Close
  Combine: Join
  Compare: Compare
  Compile: Build
  Complete: Complete
  Compress: Compress
  Concatenate: Add
  Configure: Set
  Confirm: Confirm
  Connect: Connect
  Convert: Convert
  ConvertFrom: ConvertFrom
  ConvertTo: ConvertTo
  Copy: Copy
  Create: New
  Cut: Remove
  Debug: Debug
  Delete: Remove
  Deny: Deny
  Deploy: Deploy
  Dir: Get
  Disable: Disable
  Discard: Remove
  Disconnect: Disconnect
  Discover: Find
  Dismount: Dismount
  Display: Show
  Dispose: Remove
  Dump: Get
  Duplicate: Copy
  Edit: Edit
  Enable: Enable
  End: Stop
  Enter: Enter
  Erase: Clear
  Evaluate: Test
  Examine: Get
  Execute: Invoke
  Exit: Exit
  Expand: Expand
  Export: Export
  Failover: Set
  Find: Find
  Finish: Complete
  Flush: Clear
  ForceReboot: Restart
  Format: Format
  Generalize: Reset
  Generate: New
  Get: Get
  Grant: Grant
  Group: Group
  Hide: Hide
  Import: Import
  Initialize: Initialize
  Insert: Add
  Install: Install
  Into: Enter
  Invoke: Invoke
  Is: Test
  Join: Join
  Jump: Skip
  Limit: Limit
  List: Get
  Load: Import
  Locate: Find
  Lock: Lock
  Make: New
  Measure: Measure
  Merge: Merge
  Migrate: Move
  Mount: Mount
  Move: Move
  Name: Move
  New: New
  Notify: Send
  Nullify: Clear
  Obtain: Get
  Open: Open
  Optimize: Optimize
  Out: Out
  Patch: Update
  Pause: Suspend
  Perform: Invoke
  Ping: Ping
  Pop: Pop
  Post: Invoke
  Power: Start
  PowerOff: Stop
  PowerOn: Start
  Produce: Show
  Protect: Protect
  Provision: New
  Publish: Publish
  Purge: Clear
  Push: Push
  Put: Set
  Read: Read
  Reassociate: Move
  Reboot: Restart
  Receive: Receive
  Recover: Restore
  Redo: Redo
  Refresh: Update
  Regenerate: New
  Register: Register
  Reimage: Update
  Release: Publish
  Remove: Remove
  Rename: Rename
  Repair: Repair
  Replace: Update
  Replicate: Copy
  Reprocess: Update
  Request: Request
  Reset: Reset
  Resize: Resize
  Resolve: Resolve
  Restart: Restart
  Restore: Restore
  Restrict: Lock
  Resubmit: Submit
  Resume: Resume
  Retarget: Update
  Retrieve: Get
  Revoke: Revoke
  Run: Start
  Save: Save
  Search: Search
  Secure: Lock
  Select: Select
  Send: Send
  Separate: Split
  Set: Set
  Show: Show
  Shutdown: Stop
  Skip: Skip
  Split: Split
  Start: Start
  Step: Step
  Stop: Stop
  Submit: Submit
  Suggest: Get
  Suspend: Suspend
  Swap: Switch
  Switch: Switch
  Sync: Sync
  Synch: Sync
  Synchronize: Sync
  Test: Test
  Trace: Trace
  Transfer: Move
  Trigger: Start
  Type: Get
  Unblock: Unblock
  Undelete: Restore
  Undo: Undo
  Uninstall: Uninstall
  Unite: Join
  Unlock: Unlock
  Unmark: Clear
  Unprotect: Unprotect
  Unpublish: Unpublish
  Unregister: Unregister
  Unrestrict: Unlock
  Unsecure: Unlock
  Unset: Clear
  Update: Update
  Upgrade: Update
  Use: Use
  Validate: Test
  Verify: Test
  Wait: Wait
  Watch: Watch
  Wipe: Clear
  Write: Write
```
