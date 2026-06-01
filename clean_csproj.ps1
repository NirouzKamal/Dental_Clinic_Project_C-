$projPath = "DentalClinicProject.csproj"
[xml]$proj = Get-Content $projPath
$ns = New-Object System.Xml.XmlNamespaceManager($proj.NameTable)
$ns.AddNamespace("msb", "http://schemas.microsoft.com/developer/msbuild/2003")

$nodesToRemove = @()

foreach ($item in $proj.SelectNodes("//msb:Project/msb:ItemGroup/*[@Include]", $ns)) {
    $includePath = $item.GetAttribute("Include")
    
    # MSBuild uses backslashes, so we just check if the file exists
    # We should also handle wildcards or conditions if they exist, but typical winforms proj is explicit.
    
    # We only care about Compile, EmbeddedResource, None, etc.
    if (-not (Test-Path $includePath)) {
        Write-Host "Removing missing file reference: $includePath"
        $nodesToRemove += $item
    }
}

foreach ($node in $nodesToRemove) {
    $node.ParentNode.RemoveChild($node) | Out-Null
}

$proj.Save((Get-Item $projPath).FullName)
Write-Host "CSPROJ cleaned successfully!"
