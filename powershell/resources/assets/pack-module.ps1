Write-Host -ForegroundColor Green 'Packing module...'
dotnet pack $PSScriptRoot --no-build /nologo
Write-Host -ForegroundColor Green '-------------Done-------------'