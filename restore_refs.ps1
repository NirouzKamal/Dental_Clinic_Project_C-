$projPath = "DentalClinicProject.csproj"
[xml]$proj = Get-Content $projPath
$ns = New-Object System.Xml.XmlNamespaceManager($proj.NameTable)
$ns.AddNamespace("msb", "http://schemas.microsoft.com/developer/msbuild/2003")

$refs = @(
    "System",
    "System.Core",
    "System.Xml.Linq",
    "System.Data.DataSetExtensions",
    "Microsoft.CSharp",
    "System.Data",
    "System.Deployment",
    "System.Drawing",
    "System.Net.Http",
    "System.Windows.Forms",
    "System.Xml"
)

$refGroup = $proj.SelectSingleNode("//msb:Project/msb:ItemGroup[msb:Reference]", $ns)
if ($refGroup -eq $null) {
    $refGroup = $proj.CreateElement("ItemGroup", "http://schemas.microsoft.com/developer/msbuild/2003")
    $proj.DocumentElement.InsertBefore($refGroup, $proj.DocumentElement.ChildNodes[1])
}

foreach ($r in $refs) {
    $refNode = $proj.CreateElement("Reference", "http://schemas.microsoft.com/developer/msbuild/2003")
    $refNode.SetAttribute("Include", $r)
    if ($r -eq "System.Net.Http" -or $r -eq "System.Data.DataSetExtensions" -or $r -eq "System.Xml.Linq" -or $r -eq "Microsoft.CSharp") {
        # these don't strictly need SpecificVersion or anything in most generic setups
    }
    $refGroup.AppendChild($refNode)
}

$proj.Save((Get-Item $projPath).FullName)
Write-Host "References restored!"
