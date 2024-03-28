create database My_birthdate
use My_birthdate

--Create birthdate table
create table My_birthdate (
    name varchar(20),
	age int,
    birthdate date
);

--inser data into Books table
insert into MY_birthdate(name,age,birthdate)
values
    ('Sanjeev',23,'2001/04/05');

select * from My_birthdate;

-- 1. Write a query to display your birthday( day of week)
select birthdate , format(birthdate,N'dddd","dd MMMM yyyy', 'en-US') as day_of_week
from My_birthdate
where name = 'Sanjeev';

-------------------------------------------------------------------------------------------------------------------------------

-- 2. Write a query to display your age in days
select name , birthdate , datediff(day,birthdate,getdate())
as curr_age_in_days
from My_birthdate
where name = 'Sanjeev';

---------------------------------------------------------------------------------------------------------------------------------

--3. Write a query to display all employees information those who joined before 5 years in the current month
 
	--(Hint : If required update some HireDates in your EMP table of the assignment)
	use Assignment_2
		update EMP set HireDate = '2019-03-27' where Empno in (7934);
		update EMP set HireDate = '2015-02-15' where Empno in (7839);
		update EMP set HireDate = '2012-10-02' where Empno in (7654);
		select*from EMP

	-- To disply output
	select * from EMP
		where dateadd(year, -5, getdate()) >= HireDate
				and month(HireDate) = month(getdate())


----------------------------------------------------------------------------------------------------------------------------------

--4. Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction

create table Empl
(
    Emp_no int primary key,
    E_name varchar(20),
    E_sal int,
    E_doj date
);

select * from empl;

begin tran;

	--a. First insert 3 rows 
		insert into empl (Emp_no, E_name, E_sal, E_doj)
		values (1, 'Shubham', 30000, '2024-02-15'),
			   (2, 'Ram', 25000, '2020-04-20'),
			   (3, 'Shivansh', 15000, '2019-01-02');

		commit tran;

	--b. Update the second row sal with 15% increment  
		begin transaction;
		update Empl set E_sal = E_sal * 0.15 where Emp_no = 2;
		commit transaction;

	--c. Delete first row.
		begin tran;
		delete from Empl where Emp_no = 1;
		commit tran;

-----------------------------------------------------------------------------------------------------------------------------------

-- 5. Create a user defined function calculate Bonus for all employees of a  given job using following conditions
		--a.For Deptno 10 employees 15% of sal as bonus.
		--b.For Deptno 20 employees  20% of sal as bonus
		--c.For Others employees 5%of sal as bonus

use Assignment_2

-- create function
create function cal_bonus (@deptno int, @salary float)
returns float
as
begin
    declare @bonus float;

    --calculate bonus
    if @deptno = 10
        set @bonus = @salary * 0.15;

    else if @deptno = 20
        set @bonus = @salary * 0.2;

    else
        set @bonus = @salary * 0.05;

    return @bonus;
end;

-- output
select Empno, Ename, Sal, deptno, dbo.cal_bonus(deptno, sal) as bonus
from Emp;

--------------------------------------------------------------------------------------------------------------------------
