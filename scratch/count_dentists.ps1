$conn = New-Object System.Data.SqlClient.SqlConnection("Server=(local);Database=DentalClinicDB;Integrated Security=True;TrustServerCertificate=True;")
$conn.Open()
$cmd = $conn.CreateCommand()
$cmd.CommandText = "SELECT COUNT(*) FROM dbo.Dentist"
Write-Output ("Dentist Count: " + $cmd.ExecuteScalar())
$conn.Close()
