# All-in-One Docker Image for Azure PowerShell Code Generation
Packages contained in the image.
* PowerShell 6.2.3
* NodeJS 10.16.0
* Latest @autorest/autorest
* Dotnet SDK 2.1

# How to Build the Image
`docker build -t autorest ./`

# Launch the Image
`docker run -it -v <path-to-your-source>:/src autorest`

# Code Generation vs Build vs Run
## Code Generation
`autorest-beta`
## Build
`pwsh build-module.ps1`
## Run
`pwsh run-module.ps1`
