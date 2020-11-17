create database dbADOExample

use dbADOExample

Create table tblStudent
(id int identity(1,1) primary key,
name varchar(20),
age int)

--sp_rename 'tblStudent.sage','age','COLUMN'

--sp_help tblStudent

insert into tblStudent(name,age) 
values('Rame',21),('Somu',22)

insert into tblStudent(name,age) 
values('Ramu',24)

create proc proc_UpdateStudnetName(@sid int,@sname varchar(20))
as
begin 
  update tblStudent set name = @sname where id = @sid
end

select * from tblStudent

select min(age) from tblStudent

insert into tblStudent(name,age) 
values('Komu',null)

create proc proc_DeleteStudnet(@sid int)
as
begin 
  delete from tblStudent where id = @sid
end

create table tblCourse
(id int identity(101,1) primary key,
name varchar(20),
fees float)

create proc proc_InsertCourse(@cname varchar(20),@cfees float)
as
begin
  Insert into tblCourse(name,fees) values(@cname,@cfees)
end

proc_InsertCourse 'Java',10000
proc_InsertCourse 'Dotnet',10000
proc_InsertCourse 'SQL',5000

create proc proc_GetAllCourse
as
begin
   select * from tblCourse
end

proc_GetAllCourse

