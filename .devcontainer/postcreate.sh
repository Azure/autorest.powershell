#!/bin/bash
set -e

echo "Dev container setup complete!"
echo ""
echo "Installed versions:"
echo "  Node: $(node -v 2>/dev/null || echo 'Run: source ~/.bashrc')"
echo "  npm: $(npm -v 2>/dev/null || echo 'Run: source ~/.bashrc')"
echo "  Rush: $(rush --version 2>/dev/null | head -n1 || echo 'Run: source ~/.bashrc')"
echo "  .NET: $(dotnet --version)"
echo "  PowerShell: $(pwsh -v)"
echo ""
echo "If node/npm/rush are not found, run: source ~/.bashrc"
echo ""
echo "Ready to build: rush sync-versions && rush update && rush rebuild"
