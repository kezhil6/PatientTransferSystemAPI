--create database HospitalDB
--use HospitalDB

--create table Patients
--(
--	PatientId int primary key,
--	Name varchar(50),
--	Age int
--	);

--create table Facilities(
--	FacilityId int primary key,
--	FacilityName varchar(100)
--	);

--create table Transfers(
--	TransferId int primary key,
--	PatientId int,
--	FromFacilityId int,
--	ToFacilityId int,
--	TransferDate datetime
--);

--INSERT INTO Patients (PatientId, Name, Age)
--VALUES
--(1, 'Ezhil', 35),
--(2, 'Kannan', 42);

--INSERT INTO Facilities (FacilityId, FacilityName)
--VALUES
--(1, 'Ganga Hospital'),
--(2, 'CMC'),
--(3, 'KMCH');

--INSERT INTO Transfers
--(TransferId, PatientId, FromFacilityId, ToFacilityId, TransferDate)
--VALUES
--(1, 1, 1, 2, GETDATE()),
--(2, 2, 2, 3, GETDATE());

-- select t.TransferId, p.Name, p.Age, f1.FacilityName as FromFacility, f2.FacilityName as ToFacility, t.TransferDate from Transfers t inner join Patients p on t.PatientId = p.PatientId inner join Facilities f1 on t.FromFacilityId = f1.FacilityId inner join Facilities f2 on t.ToFacilityId = f2.FacilityId where t.TransferDate between '2026-01-01' and '2026-12-31' order by t.TransferDate desc