DELETE FROM dbo.DentistSchedule;
DELETE FROM dbo.Dentist;
DELETE FROM dbo.Users;

INSERT INTO dbo.Users (UserId, FullName, UserName, PasswordHash, IsActive, Phone, Gender, HireDate)
VALUES 
('ADM_2026_001', N'ريم سعيد الطبيب', N'ريم', 'iPnlop0Df4pCw1feVviUkyWhUIvR/DEwH+KkEuzP1VU=', 1, '0912345678', 'Female', GETDATE()),
('REC_2026_001', N'نيروز كمال حشاد', N'نيروز', '0jaf6hqj7/zhHcY6Y+gRptpF+d8BP9+09ZpgcVW7sHw=', 1, '0912242178', 'Female', GETDATE()),
('DOC_2026_001', N'أحمد علي', N'د. أحمد علي', 'psqeLerOutcVHF+xDzemx2NE/6dl/6nFaECSxyU4QHM=', 1, '0915543624', 'Male', GETDATE());

INSERT INTO dbo.Dentist (DentistId, UserId, Speciality, RoomNumber, DoctorPercentage, LicenseNumber, YearsExperience)
VALUES 
('DOC_2026_001', 'DOC_2026_001', N'طبيب أسنان عام', N'عيادة 101', 40.00, 'LIC-1001', 5);
