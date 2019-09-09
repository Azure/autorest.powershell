
## Repository Layout

This repository now contains just the PowerShell generator components, and none of the common parts that are shared between generators.

In this repository

 - `docs/` - folder containing developer documentation (currently, user docs are published in the autorest repo.)
 - `common/` - rush common configuration
 - `.vscode/` - vscode settings files
 - `.scripts/` - scripts for automating tasks with rush and ADO build YAML files
 - `rush.json` - the rush build configuration file
 - `powershell` - all the source code for the AutoRest.PowerShell extension.
 - `samples/` - a couple small non-azure examples to generate modules 
 - `tests/` - **WORK IN PROGRESS** scripts to generate some tests to validate the code generator.

### The `powershell` plugin
 
 - `generators/` - 
 - `file-formats/` - 
 - `namespaces/` -  
 - `llcsharp/` - 
 - `resources/` - 
 - `test/` - 

 - `main.ts` - entrypoint for this autorest extension
 - `autorest-extension.ts` - 

 - `cmdlet-parameter.ts` - 
 - `project.ts` - 
 - `powershell-declarations.ts` - 
 - `plugin-powershell.ts` -  
 - `plugin-add-azure-completers.ts` - 
 
 - `name-inferrer.ts` - 
 - `module-class.ts` - 
 - `model-cmdlet.ts` - 
 
 - `state.ts` - 
 - `verbs.ts` - 
 - `type-converter.ts` - 
 
 - `plugin-namer.ts` - 
 - `plugin-create-commands.ts` - 
 - `cmdlet-class.ts` - 
 - `modifiers.ts` - 

- `readme.md` - 
- `autorest-configuration.md` - 

- `tsconfig.json` - 
- `package.json` - 
- `.eslintrc.yaml` - 
- `.eslintignore` - 
- `dist/` - output folder for compiled typescript files (*.js)
### Dependencies

The generator relies on shared components from the [Azure Perks](https://github.com/azure/perks) project

    `@azure-tools/codegen` - common code generation functions
    `@azure-tools/codegen-csharp` - C# code dom classes for generating c# code
    `@azure-tools/codemodel-v3` - declarations for the AutoRest V3 code model
    `@azure-tools/autorest-extension-base` - base classes to handle implementation of the AutoRest JSON/RPC connector
    `@azure-tools/linq` - TypeScript implementation of some common LINQ patterns in from .NET
    `@azure-tools/tasks` - common code for handling async tasks
    `@azure-tools/async-io` - common code for handling async IO in typscript



    