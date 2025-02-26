$folders = Get-ChildItem -Directory

foreach ($folder in $folders) {
    # 源文件夹路径：generated\generated
    $source = Join-Path $folder.FullName "generated\generated\runtime\BuildTime"
    
    # 目标文件夹路径：target\generated
    $destination = Join-Path $folder.FullName "target\generated\runtime\BuildTime"

    if (Test-Path $source) {
        Write-Host "Copying $source to $destination..."
        
        # 确保目标文件夹存在
        if (!(Test-Path $destination)) {
            New-Item -ItemType Directory -Path $destination -Force | Out-Null
        }

        # 复制 generated\generated 到 target\generated（强制覆盖）
        Copy-Item -Path $source\* -Destination $destination -Recurse -Force
    }
}