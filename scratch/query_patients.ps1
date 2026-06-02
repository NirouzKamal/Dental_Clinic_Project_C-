$conn = New-Object System.Data.SqlClient.SqlConnection("Server=(local);Database=DentalClinicDB;Integrated Security=True;TrustServerCertificate=True;")
$conn.Open()
$cmd = $conn.CreateCommand()
$cmd.CommandText = "SELECT * FROM dbo.Patients"
$rdr = $cmd.ExecuteReader()
while ($rdr.Read()) {
    Write-Output ("PatientId: " + $rdr["PatientId"] + ", Name: " + $rdr["FirstName"] + " " + $rdr["LastName"] + ", Gender: " + $rdr["Gender"])
}
$conn.Close()
