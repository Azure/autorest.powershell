
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
  Access: 
    verb: Get
    category: Common
  Acquire: 
    verb: Get
    category: Common
  Activate: 
    verb: Initialize
    category: Data
  Allocate: 
    verb: New
    category: Common
  Analyze: 
    verb: Test
    category: Diagnostic
  Append: 
    verb: Add
    category: Common
  Apply: 
    verb: Add
    category: Common
  Assign: 
    verb: Set
    category: Common
  Associate: 
    verb: Join
    category: Common
  Attach: 
    verb: Add
    category: Common
  Authorize: 
    verb: Grant
    category: Security
  Build: 
    verb: Build
  Bypass: 
    verb: Skip
    category: Common
  Cancel: 
    verb: Stop
    category: Lifecycle
  Capture: 
    verb: Export
    category: Data
  Cat: 
    verb: Get
    category: Common
  Change: 
    verb: Rename
    category: Common
  Check: 
    verb: Test
    category: Diagnostic
  Clone: 
    verb: Copy
    category: Common
  Combine: 
    verb: Join
    category: Common
  Compile: 
    verb: Build
  Concatenate: 
    verb: Add
    category: Common
  Configure: 
    verb: Set
    category: Common
  Create: 
    verb: New
    category: Common
  Cut: 
    verb: Remove
    category: Common
  Delete: 
    verb: Remove
    category: Common
  Deploy: 
    verb: Deploy
  Dir: 
    verb: Get
    category: Common
  Discard: 
    verb: Remove
    category: Common
  Discover: 
    verb: Find
    category: Common
  Display: 
    verb: Show
    category: Common
  Dispose: 
    verb: Remove
    category: Common
  Dump: 
    verb: Get
    category: Common
  Duplicate: 
    verb: Copy
    category: Common
  End: 
    verb: Stop
    category: Lifecycle
  Erase: 
    verb: Clear
    category: Common
  Evaluate: 
    verb: Test
    category: Diagnostic
  Examine: 
    verb: Get
    category: Common
  Execute: 
    verb: Invoke
    category: Lifecycle
  Failover: 
    verb: Set
    category: Common
  Finish: 
    verb: Complete
    category: Lifecycle
  Flush: 
    verb: Clear
    category: Common
  ForceReboot: 
    verb: Restart
    category: Lifecycle
  Generalize: 
    verb: Reset
    category: Common
  Generate: 
    verb: New
    category: Common
  Get: 
    verb: Get
    category: Common
  Insert: 
    verb: Add
    category: Common
  Into: 
    verb: Enter
    category: Common
  Is: 
    verb: Test
    category: Diagnostic
  Jump: 
    verb: Skip
    category: Common
  List: 
    verb: Get
    category: Common
  Load: 
    verb: Import
    category: Data
  Locate: 
    verb: Find
    category: Common
  Make: 
    verb: New
    category: Common
  Migrate: 
    verb: Move
    category: Common
  Name: 
    verb: Move
    category: Common
  Notify: 
    verb: Send
    category: Communications
  Nullify: 
    verb: Clear
    category: Common
  Obtain: 
    verb: Get
    category: Common
  Patch: 
    verb: Update
    category: Data
  Pause: 
    verb: Suspend
    category: Lifecycle
  Perform: 
    verb: Invoke
    category: Lifecycle
  Post: 
    verb: Invoke
    category: Lifecycle
  Power: 
    verb: Start
    category: Lifecycle
  PowerOff: 
    verb: Stop
    category: Lifecycle
  PowerOn: 
    verb: Start
    category: Lifecycle
  Produce: 
    verb: Show
    category: Common
  Provision: 
    verb: New
    category: Common
  Purge: 
    verb: Clear
    category: Common
  Put: 
    verb: Set
    category: Common
  Reassociate: 
    verb: Move
    category: Common
  Reboot: 
    verb: Restart
    category: Lifecycle
  Recover: 
    verb: Restore
    category: Data
  Refresh: 
    verb: Update
    category: Data
  Regenerate: 
    verb: New
    category: Common
  Reimage: 
    verb: Update
    category: Data
  Release: 
    verb: Publish
    category: Data
  Replace: 
    verb: Update
    category: Data
  Replicate: 
    verb: Copy
    category: Common
  Reprocess: 
    verb: Update
    category: Data
  Restrict: 
    verb: Lock
    category: Common
  Resubmit: 
    verb: Submit
    category: Lifecycle
  Retarget: 
    verb: Update
    category: Data
  Retrieve: 
    verb: Get
    category: Common
  Run: 
    verb: Start
    category: Lifecycle
  Secure: 
    verb: Lock
    category: Common
  Separate: 
    verb: Split
    category: Common
  Shutdown: 
    verb: Stop
    category: Lifecycle
  Suggest: 
    verb: Get
    category: Common
  Swap: 
    verb: Switch
    category: Common
  Synch: 
    verb: Sync
    category: Data
  Synchronize: 
    verb: Sync
    category: Data
  Transfer: 
    verb: Move
    category: Common
  Trigger: 
    verb: Start
    category: Lifecycle
  Type: 
    verb: Get
    category: Common
  Undelete: 
    verb: Restore
    category: Data
  Unite: 
    verb: Join
    category: Common
  Unmark: 
    verb: Clear
    category: Common
  Unrestrict: 
    verb: Unlock
    category: Common
  Unsecure: 
    verb: Unlock
    category: Common
  Unset: 
    verb: Clear
    category: Common
  Upgrade: 
    verb: Update
    category: Data
  Validate: 
    verb: Test
    category: Diagnostic
  Verify: 
    verb: Test
    category: Diagnostic
  Wipe: 
    verb: Clear
    category: Common
```