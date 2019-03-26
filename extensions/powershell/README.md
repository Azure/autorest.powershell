
# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.


### Autorest plugin configuration
- Please don't edit this section unless you're re-configuring how the powershell extension plugs in to AutoRest
AutoRest needs the below config to pick this up as a plug-in - see https://github.com/Azure/autorest/blob/master/docs/developer/architecture/AutoRest-extension.md

#### PowerShell

> Requires remodeler and csharpv2
``` yaml 
use-extension:
  "@microsoft.azure/autorest.remodeler": "beta"
  "@microsoft.azure/autorest.csharp-v2": "beta"
```

> forces multi-api mode 
``` yaml
enable-multi-api: true
load-priority: 1001
```

# Pipeline Configuration
``` yaml
use-namespace-folders: false

api-folder: generated/api
runtime-folder: generated/runtime

pipeline:
# --- extension remodeler --- 

  # "Shake the tree", and normalize the model
  remodeler:
    input: openapi-document/multi-api/identity     # the plugin where we get inputs from

  # Make some interpretations about what some things in the model mean
  tweakcodemodel:
    input: remodeler

  # Specific things for Azure
  tweakcodemodelazure:
    input: tweakcodemodel

  add-apiversion-constant:
    input: tweakcodemodelazure

# --- extension powershell --- 

  # creates high-level commands
  create-commands:
    input: add-apiversion-constant # brings the code-model-v3 with it.

  structural-modifier:
    input: create-commands

  create-virtual-properties:
    input: structural-modifier

  # Choose names for everything in c#
  csnamer:
    input: create-virtual-properties # and the generated c# files

  # ensures that names/descriptions are properly set for powershell
  psnamer:
    input: csnamer 

  cosmetic-modifier:
    input: psnamer  

  # creates powershell cmdlets for high-level commands. (leverages llc# code)
  powershell:
    input: cosmetic-modifier # and the generated c# files

# --- extension llcsharp  --- 
  # generates c# files for http-operations
  llcsharp:
    input: cosmetic-modifier

  # the default emitter will emit everything (no processing) from the inputs listed here.
  default/emitter:
    input:
     - llcsharp
     - powershell

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
```

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