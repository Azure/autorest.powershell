$testServer = get-command "$(resolve-path $PSScriptRoot/..)/powershell/node_modules/.bin/start-autorest-express"

& $testServer --verbose --show-messages --interactive