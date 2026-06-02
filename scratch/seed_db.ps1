$sql = [System.IO.File]::ReadAllText("C:\Users\Kamal\Downloads\Telegram Desktop\DentalClinicProject (7)\DentalClinicProject\DentalClinicProject\scratch\seed.sql", [System.Text.Encoding]::UTF8)
$conn = New-Object System.Data.SqlClient.SqlConnection("Server=(local);Database=DentalClinicDB;Integrated Security=True;TrustServerCertificate=True;")
$conn.Open()
$cmd = $conn.CreateCommand()
$cmd.CommandText = $sql
$cmd.ExecuteNonQuery()
Write-Output "Database seeded successfully from seed.sql!"
$conn.Close()
