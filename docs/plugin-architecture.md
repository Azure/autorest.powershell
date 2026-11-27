# AutoRest PowerShell Architecture 

### Notes

The generator requires the use of the `@autorest/remodeler` component that transforms the 
openapi source into a model that contains the model that the code is generated from.

### Configuration
The autorest plugin configuration for these are in the `autorest-extension.md` file.

### Process
The pipeline is configured to do the following:

1. AutoRest-core produces the Processed/Merged OpenAPI document ( `openapi-document/multi-api/identity` ) 
> outputs: `openapi-document`

2. `@autorest/core` - `new-transform` 
> inputs: `openapi-document`

> outputs: `openapi-document`

- An opportunity to process `transform` directives on the openapi doc. (provided in `@autorest/core`) -- see https://github.com/Azure/autorest/tree/master/Samples/3b-custom-transformations

3. `@autorest/remdeler` - `remodeler` 
> inputs: an `openapi-document`

> outputs: `codemodel-v3` 

- calls the `@autorest/remodeler` to produce an `codemodel-v3` document. 

4. `@autorest/remdeler` - `tweakcodemodel` 
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- makes modifications to the code model:
  - adds in a universal identity type for `ViaIdentity`  cmdlets
  - if an operation has a response that has a schema with string/binary we should make the response `application/octet-stream`
  - schemas that have parents and implement properties that are in the parent schemas will have the property dropped in the child schema
  - find responses that have header values, and add a property to the schemas that are returned with those values
  - if we have an operation with a body, and `content-type` is a `multipart/formdata` then we should go thru the parameters of the body and look for a string/binary parameters  and remember to add another parameter for the filename of the string/binary
  - identify models that are polymorphic in nature
  - identify parameters that are constants
  - identify properties that are constants
  - mark enums that shouldn't be generated

5. `@autorest/remdeler` - `tweakcodemodelazure` 
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

 - makes modifications to the code model:
   - identifies operations that support paging and tags them
   - identifies operations that support long-running-operations and tags them
 - tags `by-reference` models 
 - Api Version parameter handling for Azure.
   - moves models into namespaces

6. `create-commands`
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- walks thru the `operations` in the code model and makes `commands` based on what it finds.
- each `operation` can create one or more `command` instances
- each `command` has several important properties: 
    - subject: the thing that is being manipulated,
      subjectPrefix: usually the variant (aka the parameterset)
      verb: the action being performed
      name: the name 
      alias: any potential aliases 

7. `create-virtual-properties` 
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- walks thru the schemas in the model and creates virtual properties for each property
- handles inlining properties from schemas that reference other schemas
- handles parent relationships
- handles name collisions
- for cmdlets that have body parameters, creates virtual parameters for those operations based on the virtual parameter sets


8. `csnamer`
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- adds c# style names to the details for everything in the code model 

9. `psnamer`
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- adds c# style names for things powershell needs to the details for things in the code model 

10. `modifiers`
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- provides the ability to modify the names/parameter/etc of the commands and models.
- see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

After the modifiers step, the pipeline goes in two paths:

#### lowlevel-c#
1. `llcsharp` 
> inputs: `codemodel-v3` 

> outputs: `source-file-csharp` 

- this generates the low-level c# interface for the module.
- includes: 
  - classes for the enums
  - classes for the schemas (split into apiversion namespaces)
  - JSON serialization code for the schemas
  - one class for the API itself 
  - copies the runtime files out to the project (adjusts namespace on the fly)
  
2. `@autorest/core` - `text-transform`
> inputs: _any files_

> outputs: _files modfied_

- allows the developer to perform text transformations on the generated files before they are written to disk.

3. `emitter`
> inputs: _any files_

> outputs: writes files to disk

- writes files to disk.


#### powershell
1. `add-azure-completers`
> inputs: `codemodel-v3` 

> outputs: `codemodel-v3` 

- actually, not used at the moment.

2. `powershell` 
> inputs: `codemodel-v3` 

> outputs: lots of types of files

- generates files for the powershell module:
  - cmdlets
  - module.cs 
  - PowerShell type converters for all the schema classes
  - emits misc files: 
    - .psd1
    - .psm1
    - .csproj
    - .ps1 scripts (build/generate/etc)
    
3. `text-transform`
> inputs: _any files_

> outputs: _files modfied_

- allows the developer to perform text transformations on the generated files before they are written to disk.

4. `emitter`
> inputs: _any files_

> outputs: writes files to disk

- writes files to disk.
