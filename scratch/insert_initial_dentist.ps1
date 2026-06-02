$conn = New-Object System.Data.SqlClient.SqlConnection("Server=(local);Database=DentalClinicDB;Integrated Security=True;TrustServerCertificate=True;")
$conn.Open()
$cmd = $conn.CreateCommand()

# Check if dentist record for DOC_2026_001 exists
$cmd.CommandText = "SELECT COUNT(*) FROM dbo.Dentist WHERE UserId = 'DOC_2026_001'"
$count = $cmd.ExecuteScalar()

if ($count -eq 0) {
    $cmd.CommandText = "INSERT INTO dbo.Dentist (DentistId, UserId, Speciality, RoomNumber, DoctorPercentage, LicenseNumber, YearsExperience) VALUES ('DOC_2026_001', 'DOC_2026_001', N'طبيب أسنان عام', N'عيادة 101', 40.00, 'LIC-1001', 5)"
    $cmd.ExecuteNonQuery()
    Write-Output "Successfully inserted initial dentist record!"
} else {
    Write-Output "Initial dentist record already exists."
}
$conn.Close()
