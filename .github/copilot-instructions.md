# AutoRest PowerShell Generator

AutoRest PowerShell is a monorepo containing generators that create PowerShell cmdlets from OpenAPI specifications. The repository uses Rush.js for monorepo management and contains multiple packages including the core AutoRest PowerShell generator and TypeSpec PowerShell tools.

**Always reference these instructions first and fallback to search or bash commands only when you encounter unexpected information that does not match the info here.**

## Working Effectively

### Initial Setup and Dependencies
- Install Node.js LTS (20.19.5 recommended): `curl -fsSL https://nodejs.org/dist/v20.19.5/node-v20.19.5-linux-x64.tar.xz | tar -xJ -C /usr/local --strip-components=1`
- Install Rush.js globally: `npm install -g @microsoft/rush@5.112.2`
- Install AutoRest globally: `npm install -g autorest@latest`
- Verify PowerShell is available (6.0+ required): `pwsh -version`
- Verify .NET SDK is available (2.0+ required): `dotnet --version`

### Bootstrap and Build Process
- Sync package versions: `rush sync-versions` -- takes 1 second. Always run first.
- Install dependencies: `rush update` -- takes 20 seconds. NEVER CANCEL.
- Build all projects: `rush rebuild` -- takes 8 seconds. NEVER CANCEL.

### Testing and Validation
- Run unit tests: `cd powershell && npm test` -- takes 1 second. Should show 3 passing tests.
- Run linting: `cd powershell && npm run eslint` -- instant. Must pass without errors.
- **CRITICAL**: Run comprehensive SDK validation: `cd tests-upgrade/tests-sdk1-support && pwsh ./AutoRestSupportSdkTest.ps1 -AllowList -SkipCsharp` -- takes 4 minutes. NEVER CANCEL. Set timeout to 10+ minutes. Should show 52 test cases all passing with "Equal" status.

### Development Workflow
- Always run the bootstrap steps first before making changes
- Build incrementally: `cd powershell && npm run build` for quick iteration
- Watch mode for continuous compilation: `cd powershell && npm run watch`
- Test local generator: `autorest --use:./powershell --powershell --input-file:./samples/Xkcd/xkcd.yaml --output-folder:/tmp/test-output` -- takes 4 seconds. Should generate 180 files.

## Validation

**CRITICAL**: Always run the following validation sequence after making changes:

1. **Build validation**: `rush rebuild` -- must complete without errors
2. **Unit test validation**: `cd powershell && npm test` -- all 3 tests must pass
3. **Code quality validation**: `cd powershell && npm run eslint` -- must pass without warnings
4. **Generator functionality validation**: Test local AutoRest generation as shown above
5. **Comprehensive SDK validation**: Run the full SDK support test as shown above -- all 52 test cases must pass

**MANUAL VALIDATION REQUIREMENT**: After building, you MUST test actual functionality:
- Generate a PowerShell module from a sample OpenAPI spec
- Verify the generated module contains expected cmdlets and functions
- Check that generated PowerShell files are syntactically correct
- Ensure the module can be imported successfully with `Import-Module`

### Key Validation Scenarios
- **Login/Authentication Flow**: Generate a module with authentication and test cmdlet parameter binding
- **CRUD Operations**: Generate a module with GET/POST/PUT/DELETE operations and verify all cmdlets are created
- **Complex Models**: Test with specifications containing nested objects and arrays
- **Error Handling**: Verify generated cmdlets handle API errors appropriately

## Common Tasks

### Repository Structure
```
.
├── .github/workflows/          # CI/CD pipelines  
├── .scripts/                   # PowerShell automation scripts
├── docs/                       # Documentation
├── packages/
│   └── typespec-powershell/    # TypeSpec PowerShell tools
├── powershell/                 # Main AutoRest PowerShell generator
├── samples/                    # Example OpenAPI specifications
├── tests/                      # Legacy test specifications
├── tests-upgrade/              # Current test suites
│   └── tests-sdk1-support/     # Comprehensive SDK validation tests
├── package.json               # Root package configuration
├── rush.json                  # Rush monorepo configuration
└── tsconfig.json              # TypeScript configuration
```

### Key Projects
- **@autorest/powershell**: Main PowerShell cmdlet generator (./powershell/)
- **@azure-tools/typespec-powershell**: TypeSpec to PowerShell tools (./packages/typespec-powershell/)
- **emitter-test**: Test project for emitter functionality (./tests-upgrade/tests-emitter/)

### Important Files and Directories
- `./powershell/main.ts` - Entry point for AutoRest PowerShell generator
- `./powershell/generators/` - Core generation logic
- `./powershell/cmdlets/` - Cmdlet generation templates
- `./tests-upgrade/tests-sdk1-support/` - Comprehensive test suite with 52 test cases
- `./.scripts/` - PowerShell scripts for testing and validation
- `./docs/development.md` - Developer setup instructions

### CI/CD Pipeline Requirements
- All builds must pass: `rush rebuild`
- All unit tests must pass: `npm test`
- ESLint must pass: `npm run eslint`
- SDK support test must pass: All 52 test cases in tests-sdk1-support
- Generated PowerShell modules must be syntactically valid

### Debugging
- Use VS Code with the provided configuration (`.vscode/launch.json`)
- Debug AutoRest generation: `autorest --use:./powershell --powershell.debugger --input-file:<spec>`
- Debug with Node.js: `node --inspect-brk ./powershell/dist/main.js`
- Monitor Rush operations: `rush rebuild --verbose`

### Common Commands Reference
```bash
# Essential setup
rush sync-versions && rush update && rush rebuild

# Development cycle  
cd powershell && npm run build && npm test && npm run eslint

# Test local generator
autorest --use:./powershell --powershell --input-file:./samples/Xkcd/xkcd.yaml --output-folder:/tmp/test-output

# Comprehensive validation
cd tests-upgrade/tests-sdk1-support && pwsh ./AutoRestSupportSdkTest.ps1 -AllowList -SkipCsharp

# Watch mode for development
cd powershell && npm run watch
```

### Timing Expectations
- **NEVER CANCEL**: rush update takes 20 seconds
- **NEVER CANCEL**: rush rebuild takes 8 seconds  
- **NEVER CANCEL**: SDK support test takes 4 minutes
- **NEVER CANCEL**: Any command taking longer than expected should be allowed to complete
- npm test: 1 second
- npm run eslint: instant
- AutoRest generation: 4 seconds

## CRITICAL REMINDERS
- **ALWAYS** run `rush sync-versions && rush update && rush rebuild` before starting work
- **ALWAYS** validate changes with the full SDK support test - it catches integration issues
- **NEVER CANCEL** long-running commands - builds and tests need time to complete
- **DO NOT** use `rush test` - it has configuration issues, use specific test commands instead  
- **ALWAYS** test generated PowerShell modules manually to ensure they work correctly
- **ALWAYS** run ESLint before committing - the CI pipeline will fail otherwise
