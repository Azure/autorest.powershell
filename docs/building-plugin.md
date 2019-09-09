# AutoRest PowerShell Developer Notes

## Building

### Required Tools
- Visual Studio Code 
  - Install the **ESLint** extension to get typescript linting support.
  
- NodeJS 10.16.x 
- PowerShell Core 
- Dotnet core 2.+
- Rush (`npm install -g "@microsoft/rush" `)

### Cloning the repository

Clone the repository as normal, no need to use `--recurse` any more.

> `git clone https://github.com/azure/autorest.powershell` 

Next, you need to restore the packages from NPM for building the code:

> `rush update` 


### Compiling the code 

Compile the module with the rush command:

> `rush rebuild`

If you are editing files, and want it to recompile on save, you can use 
the command to watch the files:

> `rush watch`

### Other useful `rush` commands

Run the TypeScript linter and reports errors
> `rush lint` 

Run the TypeScript linter in `fix` mode and will correct any automatically fixable issues.
> `rush fix`

Run the unit tests.
> `rush test`


## ADO - Validationa and Publishing

There are three ADO CI tasks set up currently:
- **Validate PR** - runs the `.scripts/verify-pull-request.yaml` job -- (does a rush update/rebuild/test)

- **Regenerate and build `azure-powershell` modules ** -- uses the changes in the PR to rebuild the `azure-powershell` modules to act as a smoke test before publishing.

- **Publish on commit** - builds and publishes the `@autorest/powershell` module when a commit is made to the `master` branch.


