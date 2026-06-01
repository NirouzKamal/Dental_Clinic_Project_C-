[xml]$proj = Get-Content "DentalClinicProject.csproj"
$ns = New-Object System.Xml.XmlNamespaceManager($proj.NameTable)
$ns.AddNamespace("msb", "http://schemas.microsoft.com/developer/msbuild/2003")

$compileItemGroup = $proj.SelectSingleNode("//msb:Project/msb:ItemGroup[msb:Compile]", $ns)
$embedItemGroup = $proj.SelectSingleNode("//msb:Project/msb:ItemGroup[msb:EmbeddedResource]", $ns)

$items = @("MainShellFormUI", "DashboardControlUI", "DoctorDashboardControlUI", "AppointmentsControlUI", "PatientRecordsControlUI", "RevenuesControlUI", "StaffManagementControlUI", "AddPatientFormUI", "AddAppointmentFormUI", "AddStaffFormUI", "AssignPatientFormUI", "PendingInvoicesFormUI", "MyPatientsFormUI", "InvoicePaymentFormUI", "PayrollManagementFormUI", "DoctorServiceFormUI", "CaseCreationFormUI")

foreach ($item in $items) {
    # Is it a UserControl or a Form?
    $subType = if ($item -like "*Control*") { "UserControl" } else { "Form" }
    
    # 1. Compile CS
    $comp = $proj.CreateElement("Compile", "http://schemas.microsoft.com/developer/msbuild/2003")
    $comp.SetAttribute("Include", "UI\$item.cs")
    $st = $proj.CreateElement("SubType", "http://schemas.microsoft.com/developer/msbuild/2003")
    $st.InnerText = $subType
    $comp.AppendChild($st)
    $compileItemGroup.AppendChild($comp)
    
    # 2. Compile Designer.cs
    $compDes = $proj.CreateElement("Compile", "http://schemas.microsoft.com/developer/msbuild/2003")
    $compDes.SetAttribute("Include", "UI\$item.Designer.cs")
    $dep1 = $proj.CreateElement("DependentUpon", "http://schemas.microsoft.com/developer/msbuild/2003")
    $dep1.InnerText = "$item.cs"
    $compDes.AppendChild($dep1)
    $compileItemGroup.AppendChild($compDes)
    
    # 3. EmbeddedResource resx
    $embed = $proj.CreateElement("EmbeddedResource", "http://schemas.microsoft.com/developer/msbuild/2003")
    $embed.SetAttribute("Include", "UI\$item.resx")
    $dep2 = $proj.CreateElement("DependentUpon", "http://schemas.microsoft.com/developer/msbuild/2003")
    $dep2.InnerText = "$item.cs"
    $embed.AppendChild($dep2)
    $embedItemGroup.AppendChild($embed)
}

$proj.Save("C:\Users\Abdurahman\Desktop\lastMidtermUpdate\DentalClinicProject\DentalClinicProject\DentalClinicProject\DentalClinicProject.csproj")
Write-Host "CSPROJ updated successfully!"
