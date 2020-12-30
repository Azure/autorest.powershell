# AutoRest PowerShell Developer Notes

## Building

### Required Tools

Development of this project requires the following:

- [Visual Studio Code](https://code.visualstudio.com/) and the [ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint) plugin
- [NodeJS LTS](https://nodejs.org) (currently 10.16.0) <br> I recommend that you use a tool like [nvs](https://github.com/jasongin/nvs) so that you can switch between versions of node without pain <br>&nbsp;
- [AutoRest](https://aka.ms/autorest) v3 <br> `npm install -g autorest ` <br>&nbsp;
- [RushJS](https://rushjs.io/) manages multiple nodejs projects in a single repository. <br> `npm install -g @microsoft/rush` <br>&nbsp;
- PowerShell 6.0+ - If you dont have it installed, you can use the cross-platform npm package <br> `npm install -g pwsh` <br>&nbsp;
- Dotnet SDK 2 or greater - If you dont have it installed, you can use the cross-platform npm package <br> `npm install -g dotnet-sdk-2.1 ` <br>&nbsp;

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


## ADO - Validation and Publishing

There are three ADO CI tasks set up currently:
- **Validate PR** - runs the `.scripts/verify-pull-request.yaml` job -- (does a rush update/rebuild/test)

- **Regenerate and build `azure-powershell` modules ** -- uses the changes in the PR to rebuild the `azure-powershell` modules to act as a smoke test before publishing.

- **Publish on commit** - builds and publishes the `@autorest/powershell` module when a commit is made to the `master` branch.

