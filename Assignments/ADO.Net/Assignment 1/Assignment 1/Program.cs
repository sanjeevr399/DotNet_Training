using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment_1
{
    class Employee
    {
        public static DataTable GetTbl()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpID", typeof(int));
            dt.Columns.Add("F_Name", typeof(string));
            dt.Columns.Add("L_Name", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("DOB", typeof(DateTime));
            dt.Columns.Add("DOJ", typeof(DateTime));
            dt.Columns.Add("City", typeof(string));
            return dt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataTable Emp = Employee.GetTbl();

            Emp.Rows.Add(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai");
            Emp.Rows.Add(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai");
            Emp.Rows.Add(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune");
            Emp.Rows.Add(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune");
            Emp.Rows.Add(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai");
            Emp.Rows.Add(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai");
            Emp.Rows.Add(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai");
            Emp.Rows.Add(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai");
            Emp.Rows.Add(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai");
            Emp.Rows.Add(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune");





           // 1.Display a list of all the employee who have joined before 1 / 1 / 2015
            Console.WriteLine("1.Employees who joined before 1/1/2015:");
            var Before2015 = Emp.AsEnumerable().Where(row => row.Field<DateTime>("DOJ") < new DateTime(2015, 1, 1));

            foreach (var employee in Before2015)
            {
                Console.WriteLine($"{employee["EmpID"]} - {employee["F_Name"]} {employee["L_Name"]}({employee["CITY"]})");
            }


            //***********************************************************************************************************************************

            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990.
            Console.WriteLine("\n 2. List of all the employee whose date of birth is after 1 / 1 / 1990 :  ");
            var After_DOB = Emp.AsEnumerable().Where(row => row.Field<DateTime>("DOB") < new DateTime(1990, 1, 1));
            foreach (var employee in After_DOB)
            {
                Console.WriteLine($"{employee["F_Name"]} {employee["L_Name"]} ");
            }

            //*************************************************************************************************************************************

            //3.Display a list of all the employee whose designation is Consultant and Associate.
            Console.WriteLine("\n 3. List of all employees whose designation is Consultant and Associate:  ");
            var Designation = Emp.AsEnumerable().Where(row => row.Field<string>("Title") == "Associate" || row.Field<string>("Title") == "Consultant");

            foreach (var employee in Designation)
            {
                Console.WriteLine($"{employee["F_Name"]} {employee["L_Name"]}");
            }

            //**************************************************************************************************************************************

            //4.Display total number of employees
            int Total = Emp.AsEnumerable().Count();
            Console.WriteLine($"\n4.Total number of employees: {Total}");

            //**************************************************************************************************************************************

            //5.Display total number of employees belonging to “Chennai”

            int TotalNoChennai = Emp.AsEnumerable().Count(row => row.Field<string>("City") == "Chennai");
            Console.WriteLine($"\n5.Total number of employees belonging to Chennai : {TotalNoChennai}");

            //***************************************************************************************************************************************

            //6.Display highest employee id from the list


            int maxID = Emp.AsEnumerable().Max(row => row.Field<int>("EmpId"));
            Console.WriteLine($"\n6.Highest Emp Id : {maxID}");

            //***************************************************************************************************************************************

            //7.Display total number of employee who have joined after 1 / 1 / 2015.
            int After2015 = Emp.AsEnumerable().Count(row => row.Field<DateTime>("DOJ") < new DateTime(2015, 1, 1));
            Console.WriteLine($"\n7.Total number of joined after 1/1/2015 : {After2015}");

            //****************************************************************************************************************************************

            //8.Display total number of employee whose designation is not “Associate”.

            int NotAssociate = Emp.AsEnumerable().Count(row => row.Field<string>("Title") != "Associate");
            Console.WriteLine($"\n8.Total number of employees designation not Associate : {NotAssociate}");

            //****************************************************************************************************************************************

            //9. Display total number of employee based on City.
            var EmployeeCity = Emp.AsEnumerable().GroupBy(row => row.Field<string>("City"));
            Console.WriteLine("\n9. Total number of employees based on City:");
            foreach (var cityGroup in EmployeeCity)
            {
                string city = cityGroup.Key;  //group.key refers to the key of each group,
                int count = cityGroup.Count();
                Console.WriteLine($"{city}: {count}");
            }

            //****************************************************************************************************************************************

            // 10. Display total number of employees based on city and title.
            var EmpWithTitleCounts = Emp.AsEnumerable().GroupBy(row => new { City = row.Field<string>("City"), Title = row.Field<string>("Title") })
                                          .Select(group => $"{group.Key.City} - {group.Key.Title}: {group.Count()}");

            Console.WriteLine("\n10.Total number of employees based on city and title");
            foreach (var count in EmpWithTitleCounts)
            {
                Console.WriteLine(count);
            }

            //****************************************************************************************************************************************

            // 11. Display total number of employee who is youngest in the list
            var GetDOB = Emp.AsEnumerable().Min(row => row.Field<DateTime>("DOB"));
            var YoungEmployee = Emp.AsEnumerable().Where(row => row.Field<DateTime>("DOB") == GetDOB); //count of emp

            int TotCount = Emp.AsEnumerable().Count(row => row.Field<DateTime>("DOB") == GetDOB);// emp

            Console.WriteLine($"\n11. Total number of employees who are youngest in the list: {TotCount}");
            foreach (var employee in YoungEmployee)
            {
                Console.WriteLine($"{employee["F_Name"]} {employee["L_Name"]}");
            }

            Console.WriteLine("*********************************************************************************");

            Console.Read();


        }
    }
}

//****************************************************************************************************************************************