use Assignment_2
select * from EMP;

-- Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

  -- a) HRA as 10% of Salary
   --b) DA as 20% of Salary
   --c) PF as 8% of Salary
   --d) IT as 5% of Salary
   --e) Deductions as sum of PF and IT
   --f) Gross Salary as sum of Salary,HRA,DA
   --g) Net Salary as Gross Salary - Deductions

create or alter proc Cal_Payslip
	-- input param
    @EmployeeID int,
    @Sal int
as
begin
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @Deduct int
    declare @GrossSal int
    declare @NetSal int

    --Calculation of given 'HRA,DA,PF and IT
    set @HRA = 0.1 * @Sal;
    set @DA = 0.2 * @Sal;
    set @PF = 0.08 * @Sal;
    set @IT = 0.05 * @Sal;
    -- Calculating deduct,gross_sal,net_sal
    set @Deduct = @PF + @IT;
    set @GrossSal = @Sal + @HRA + @DA;
    set @NetSal = @GrossSal - @Deduct;

	
    select 
		@Sal as Emp_sal,
		@HRA as HRA,
		@DA as DA,
		@PF as PF,
		@IT as IT,
		@Deduct as Deduct,
		@GrossSal as Gross_Sal,
		@NetSal as Net_Sal;
end

Cal_Payslip 7839,30000;


--Output

--Emp_sal   HRA   DA    PF     IT     Deduct   Gross_sal   Net_sal
--30000     3000  6000  2400   1500   3900     39000       35100