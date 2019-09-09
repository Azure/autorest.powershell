
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
- `cmdlets/` - code for creating the cmdlet classes
- `enums/` - code for creating extensions on the enum types
- `file-formats/` - classes to assist generating simple file formats
- `generators/` - generators to create specific output types (project files, psm1,psd1,etc)
- `internal/` - internal classes for creating powershell code 
- `llcsharp/` - all the code for generating the low-level c# code
- `models/` - code that extends the lowlevel c# models
- `module/` - code that creates the main module class
- `plugins/` - the autorest plugins that are implemented in this repository.
- `resources/` - the static files that are copied to the generated folder
- `test/` - unit test files

- `main.ts` - the entrypoint for this extension.


#### AutoRest configuration files 
- `autorest-configuration.md` - the detailed configuration file
- `readme.md` - contains just the stubs for the configuration.

### TypeScript Project files 
- `package.json` - NPM Package info
- `tsconfig.json` -  typescript configuration 
- `.eslintrc.yaml` - eslint linter configuration
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



    