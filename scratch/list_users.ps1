$conn = New-Object System.Data.SqlClient.SqlConnection("Server=(local);Database=DentalClinicDB;Integrated Security=True;TrustServerCertificate=True;")
$conn.Open()
$cmd = $conn.CreateCommand()
$cmd.CommandText = "SELECT UserId, FullName, UserName FROM dbo.Users"
$rdr = $cmd.ExecuteReader()
while ($rdr.Read()) {
    Write-Output ("UserId: " + $rdr["UserId"] + ", FullName: " + $rdr["FullName"] + ", UserName: " + $rdr["UserName"])
}
$conn.Close()
