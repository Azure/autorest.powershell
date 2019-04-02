# Docs
This directory contains the documentation of the cmdlets for the `${$project.moduleName}` module. This documentation is created by [platyPS](https://www.powershellgallery.com/packages/platyPS), the unofficial standard for producing documentation from cmdlets. To run documentation generation, use the `generate-help.ps1` script at the root module folder.

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

## Details
The process of documentation generation loads `${$project.moduleName}` and analyzes the exported cmdlets from the module. It notices the [help comments](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_comment_based_help) that are generated into the scripts in the `${$lib.path.relative($project.docsFolder, $project.exportsFolder)}` folder. Additionally, when writing custom cmdlets in the `${$lib.path.relative($project.docsFolder, $project.customFolder)}` folder, you can use the help comments syntax, which decorate the exported scripts at build-time.