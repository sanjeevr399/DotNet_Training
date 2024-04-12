create database Employeemanagement;
use Employeemanagement;

create table Employee_Details (
    Empno int PRIMARY KEY,
    EmpName varchar(50) not null, 
    Emp_sal numeric(10,2) check(Emp_sal >=25000), 
	Emptype char(1) check(Emptype in ('p','c'))
);

select * from Employee_Details;

create procedure AddEmployee
    @EmpName varchar(50),
    @Emp_sal numeric(10,2),
    @Emptype char(1)
as
begin
    declare @NewEmpno int;

    -- Generate Empno
    select @NewEmpno = isnull(max(Empno), 0) + 1 from Employee_Details;

    -- Insert into Employee_Details
    insert into Employee_Details (Empno, EmpName, Emp_sal, Emptype)
    values (@NewEmpno, @EmpName, @Emp_sal, @Emptype);
end;

--// 2----------------
EXEC sp_helptext 'AddEmployee';

