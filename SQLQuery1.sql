create database dbHospital

use dbHospital

create table tblDoctor(Id int identity(100,1) primary key, Name varchar(20), phoneNumber char(10), Email varchar(20), Address varchar(30), Gender varchar(10), yearsExperience int)

create table Doctorlog(logID int identity(100,1),cid int,operation nvarchar(20),updateddate Datetime)

create trigger DoctorInsertTrigger
on tblDoctor
for insert
as
insert into Doctorlog(logID,operation,updateddate)
select Id,'Data Inserted', GETDATE() from inserted


create table tblPatient(Id int identity(1000,1) primary key, Name varchar(20), phoneNumber char(10), Email varchar(20), Address varchar(30), Gender varchar(10), Age int, Concern varchar(40));

create table Patientlog(logID int identity(100,1),cid int,operation nvarchar(20),updateddate Datetime)

create trigger PatientInsertTrigger
on tblPatient
for insert
as
insert into Patientlog(logID,operation,updateddate)
select Id,'Data Inserted', GETDATE() from inserted

select * from tblPatient

create table booking(BedId int identity(2000,1) primary key, PatientId int FOREIGN KEY REFERENCES tblPatient(Id), AppointmentTime datetime, DoctorId int FOREIGN KEY REFERENCES tblDoctor(Id));



/*Stored procedure to Display booking related information*/

create procedure sp_booking_detail
as
begin
select booking.Id as Booking_Bed_Id, tblPatient.Name as Patient_Name , tblPatient.Age as Patient_Age, tblPatient.Concern as Symptoms, booking.AppointmentTime, tblDoctor.Name as Doctor_Name, tblDoctor.yearsExperience as Experience from booking,tblDoctor,tblPatient
end

exec sp_booking_detail


/*registration trigger*/
create table registrationlog(logid numeric identity(500,1),patid int, constraint fk_reg_pat foreign key(patid) references tblPatient(Id),operation nvarchar(20),updatedate datetime)

create trigger ins_reg
on tblPatient
for insert
as
insert into registrationlog(patid,operation,updatedate)
select logid,'Data inserted',GETDATE()
from inserted

insert into tblPatient values('Alex','alex@gmail.com',40,205)

select * from registration
