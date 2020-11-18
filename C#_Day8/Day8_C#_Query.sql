select * from tblCourse
select * from tblStudent
select * from tblDummy

create table tblDummy
(f1 int primary key,
fe varchar(10))

grant select,Update on tblDummy to user1

Revoke Update on tblDummy to USer1

deny Update on tblDummy to USer1