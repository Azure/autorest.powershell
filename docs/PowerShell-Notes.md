# Delivery in two distinct stages:
- **Earth-orbit-rendezvous** -- getting enough code generation in play to **drastically** reduce the effort to ship an RP's cmdlets. 
- **Moonshot**  -- finishing JB's graph solving to automatically generate complex cmdlets from just inputs and outputs. 

# "Earth-orbit-rendezvous Goals
- generate direct operation cmdlets from swagger (ie, a 1:1 generation of a cmdlet based on the swagger)

### [Checkpoint]

- easily tweak configuration to alter generation easily.  (modify the inferred cmdlets to tweak generation)
- generate 90% of multi-step operation cmdlets and have developers fill in a single ProcessRecordAsync method. 
  (ie, all parameters and structure code should be there, will require a user to orchestrate the order of the calls thru the API)
- automatically generate integration cmdlets to unify parameterset variants into a single public exposed cmdlet (ie, new-vm_withXYZ, new-vm_withABC, new-vm_withWhatever => new-vm )

# "Moonshot" goals
- automagically infer the whole execution chain for a given operation (given inputs/outputs) and generate whole cmdlets 

# Tennets: 
- Good Generated code is clear and efficient, not clever, and not unnecessarily terse.
- Provide behavior extensibility points (ie, partial class/method declarations and execution insertion opportunities). Support IEventListener 
- Attempt to have no differences between NetStandard and Desktop implementation. If absolutely required (i.e. interactive desktop auth), see if this can be enabled at runtime by specifically loading an additional assembly for desktop support (and/or can this be restricted to the authentication module? )
- Aim for zero reflection if possible. Use generation time knowledge to do the right thing.
- Async everywhere - do not introduce any unnecessary sync steps or wrappers. Ideally, `ProcessRecord` should directly manage `ProcessRecordAsync` and there **should** be no other case necessary
- minimize/eliminate inheritance as possible. Common functionality should be in runtime library, not base classes (reduces tracing complexity, and increases end-developer flexibility)
- minimize exceptions -- prefer to write out errors and halt processing. 
- Ideally end up with a cmdlet that doesn't radically alter the standard cmdlet design. (ie, how do you override stuff...) -- `AsyncCommandRuntime`/`ProcessRecordAsync` should be the extent of deviation.
- Avoid reliance on extension methods in generated code; explictly use code from libraries. 

### Can we narrow/eliminate some behavior without sacrifice?
- elminate `ISerializable` support from libraries and generated code (all relavent classes should support ToJson/FromJson/Clone ) ?
- 100% of user interactivity should take place **before** `ProcessRecordAsync`; this eliminates the necessity to block/replay interactivity from jobs.
- New common libraries should not have to support Hyak or current PS/Legacy support. Those cmdlets can rely on the existing support and should not conflict with the new model.
- in the new common libraries can we just support the 'consumption' side of the behavior? ie: if authentication is actually handled by other cmdlets, and sets the current profile data, is it possible to just leveage the data and not have to support the auth work in the new common libraries? (this would let the auth work be done in a module that was specifically designed to support desktop auth, but the new generation of cmdlets doesn't need to know that? ) -- this infers that while the cmdlet has no code shared with the common module, it does depend on it being there to do the right thing.
- can we reduce the interface/abstraction complexity? (ie, abstract class `AzureSession` implements `IAzureSession`, and `AdalSession` is the only thing that implements `AzureSession`. 

### Ephiphany: division of control 
 - LRO implementation can be handled in the LLC# code - notions like progress and status can be implemented as events from a given call. (IE, LRO operations just feel like they take longer time, but can spit back events)
 - Paging needs to be partially handled at the higher level -- the reponse parsing and means to take the next page can be in the low-level implementation, but accessing the next pages are better off being controlled by the high-level.(Ie, paging feels like multiple calls);

### Clarification : Preserving Backward Compatibility ongoing
 - We can use configuration modifiers (in readme.powershell.md) to generate back-compat properties that would otherwise be dropped when a property gets dropped.  (and/or using model partial classes in the cmdlet project)
 - We may have to do some work in the future to detect when this happens, unless cmdlet testing picks it up?

### Clarification : How exactly are profiles intended to be supported?
 - Are profiles just the use of IAzureEnvironment? 

### Question: Handling Validation
 - LLC# generates client-validations as events and can gather all the validations for a given call before proceeding to the actual wire call.
 
 - We now have the choice:
   
   - option 1: call the API validation, and report validation failures in the warning channel, but still make the call.  (hmmm  API call Validation is specific to the model class and parameter implementation (which makes it possible that the PowerShell cmdlet could have an alternate name for a given parameter ))

   - option 2: since we want to do all interactivity before hand, we *could* generate code to make the initial call, and stop after validation to provide assurance that what we have will succeed. or let the user say "sure, go ahead?"

   - option 3: don't bother outputting validations and let the service response yell at the user.(hmm, not likely)

   - option 4: generate additional validation code in the cmdlet (and still, halt or allow to proceed with `-force`? ) -- this may be the best bet, given that we'll have to validate before each remote call (in the case of cmdlets that make more than one call, this would for certain happen in `ProcessRecordAsync` ...)
    
   
### Bonus Points
- Because the ISendAsync implementation is applied to a **clone** of the pipeline at call time, we never are actually mutating the basic connection (like we would have with DelegatingHandlers) -- and multiple concurrent calls can't interfere with the HTTPClient state of the others. (yay!)

### Misc QOS/Perf thoughts: 
 - QOS events -- I noticed that the timer is paused during iteractivity -- It would appear that timer is started in `BeginProcessing` via a call to `InitializeQosEvent()`. 
   In the new generated cmdlet, it would be possible to start the timer after the end of interactivity (ie, in `ProcessRecord` but before we actually call (or start work in) `ProcessRecordAsync` ). It'd be far less likely that we'd ever have to pause for interactivity at that point. Hmm. If the we did it inside ProcessRecordAsync, then the `MetricHelper` wouldn't even be needed until we're committed to execution. I like that.
 - Given that we can add arbitrary events into the LLC# code, we could totally add in perf data to the `EventData` in the event (which would give us the option of having fine-grained perf info thru the REST call. ) 
 - 
 
### Where knowledge is kept: 
 - Per-User (auth/profiles/global settings)
 - Module Level (reusable/cloneable http pipeline instance)
 - cmdlet instance (per-call data)
  
# Tasks:

## Detector 
- x-ms-enums should add tabcompleter



## P0/Critical
- READONLY PROPERTIES: DO NOT SERIALIZE, make setter private (or remove?). 
  (but still has to clone them/dump them) 
  
- Header deserialization: 
   - add properties to the model classes where they found

- LLC#: URI Path population (and support the other endpoints?) + Parameterized Hosts ( is this sufficient? (can I make those just 'super' path parameters? ) )
- LLC#: Finish new deserialization 

- PS/Inferrer - integration - infer (direct) operation cmdlets from swagger (uses JB's PSInferrer)
- PS/Configuration - manually declare (multi-step) operation cmdlets in configuration

- PS/C# - flattening (easy) 
- PS/C# - extending models (calculated properties) -- where/how do we declare this. configuration?
- PS/C# - extending models (additional properties that are filled with other commands.) -- where/how do we declare this. configuration?

- CS/ClientRuntime - build/test

- PS - create code model (operations) for things we already have/know 
- PS/ClientRuntime - build/test

- PS/Generator : - cmdlet Generator
-   early interactivity (before Async) 

- PS "ClientRuntime" Library work:
  Microsoft.Azure.Commands.Common [Hard Fork - harvest/rewrite]
    harvest reusable code from PSCmdlet/AzurePSCmdlet/AzureRMCmdlet/ClientRuntimeFeatures/MetricHelper etc...
-   add AsyncCommandRuntime
-   add AsyncJob
-   classes to support Logging/tracing/QOS/Telemetry/Events 

  Microsoft.Azure.Commands.Common.Authentication/Microsoft.Azure.Commands.Common.Authentication.Abstractions [Hard fork/harvest] 
  - harvest what we need
  - can we shake the legacy out of this?

- Not sure: how do we integrate the Endpoint URL handling/API version/Environments stuff into the generated llc# client?
  (ie, should we be making the llC# client take the Base URL as a parameter too? Is that just the "base" URL ? How do we set parameters on that? and just What is the suffix stuff I see here? )

## P1/Important
- PS/Additional - manually declare additional cmdlet operations in configuration
- PS - generate cmdlet tests? (Pester tests, with record/playback modes?)

- LLC#: Header deserialization
- LLC#: security/auth ISendAsync implementations
- LLC#: streams 

## P1/tangential
  llc# - INotifyPropertyChanged/ChangeTracking
  llc# - GetHashCode/Equals/IEquatable
  llc# - diff tracking.
  llc# - undefined vs null (unset vs null?) - need a pattern.

  interpretation: readonly properties
  interpretation: nullable values
  model constructors? (required fields?)
  non json payloads (xml, formdata, multipart-mime)

## P1 - followup
  Adding explicit serializers for objects in PS: https://github.com/PowerShell/PowerShell/issues/3173  


## P2/Pickup
- Take PSInferrer/GraphSovler up where JB left off
- generate a CMV2 for PS/C# Client Runtimes/Strategies

## P2/eventually
  shape deserialization
  anyOf/oneOf

// client runtime

## Potentially Useful:
 - Generate a CMV2 for some c# code (or .NET assembly?)




# Implementation Notes:
 - Split out validation into seperate method call that can be called independently before making an actual wire call.

 - LRO Calls should be generated so that the LRO 201/202 sets up the task to make the followup calls, while spitting out events to indicate that it's working.
   (must be implemented as a while() call to make this work right. )
 - follow-up paging calls should be easy to make; (should the response type have a 'next page' method built in?  ) -- 