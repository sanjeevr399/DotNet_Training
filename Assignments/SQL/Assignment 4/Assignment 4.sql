
-- 1.Write a T-SQL Program to find the factorial of a given number.

declare @no int
declare @res int

set @no = 6
set @res = 1

while @no > 1
begin
	set @res = @res * @no
	set @no = @no -1
end

select @res as factorial;
begin
	print 'factorial of  '+cast('6' as varchar(20)) + ' is  '+' '+cast(@res as varchar(30))
end;

-- 2.Create a stored procedure to generate multiplication tables up to a given number.

create procedure Multi_Table @table int
as 
begin
	declare @i int
	declare @j int
 if @table <= 0
    begin
	print 'Invalid Input Please Input A Positive Integer'
	return
    end
	set @i = 8
	while @i <= @table 
    begin 
	print 'Multiplication Table For ' + cast(@i as varchar(10)) + ':'
	set @j = 1
 while @j<=10
    begin
	print cast(@i as varchar(10)) + ' * ' + cast(@j as varchar(10)) + ' = ' + cast(@i * @j as varchar(10))
	set @j = @j+1
    end
	print ''
	set @i = @j + 1
    end
end

execute Multi_Table @table = 10;

-- 3.Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc

	--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation
	
create Database Assignment_4
use Assignment_4

--Creating table
create Table Holiday(
holiday_date Date primary key,
holiday_name varchar(20)
);

--Insert holiday details
Insert into Holiday(holiday_date, holiday_name)
values
	('2024-03-24', 'Holi'),
	('2024-08-16', 'Rakshabandhan'),
	('2024-10-15', 'Diwali'),
	('2025-01-01', 'New year')

select * from Holiday

--Trigger
create or alter trigger pre_holiday_manipulation
on holiday
after insert, update, delete
as
begin
    declare @holiday_message varchar(40);
    declare @error_message varchar(50); 
    
    if exists (select 1 from holiday where holiday_date in (select holiday_date from inserted)) begin
        select @holiday_message = holiday_name from holiday where holiday_date in (select holiday_date from inserted);
        select @error_message = 'Due to ' + @holiday_message + ' you cannot manipulate data';
        rollback;
        raiserror(@error_message, 16, 1);
    end;
end;

update Holiday set holiday_name = 'Diwali' where holiday_date='2024-10-15';