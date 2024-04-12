using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO_Assesment
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            InsertData();
            SelectData();
            Console.Read();
        }
        // connection to sql
        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("data source = ICS-LT-7M2LQ73;initial catalog = Employeemanagement;" +
                "integrated security = true");
            con.Open();
            return con;

        }



        // method for selecting data from table
        public static void SelectData()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from Employee_Details");
            cmd.Connection = con;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Empno : " + dr[0]);
                Console.WriteLine("EmpName : " + dr[1]);
                Console.WriteLine("Emp_sal : " + dr[2]);
                Console.WriteLine("Emptype : " + dr[3]);
            }
        }

        //method for inserting a row
        public static void InsertData()
        {
            con = GetConnection();
            int Empno;
            string EmpName;
            int Emp_sal;
            char Emptype;

            try
            {
                Console.Write("Enter employee no: ");
                Empno = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee Name: ");
                EmpName = Console.ReadLine();

                Console.Write("Enter employee salary: ");
                Emp_sal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee type ('P' for Permanent, 'C' for Contract): ");
                Emptype = char.ToUpper(Console.ReadKey().KeyChar);



                // Add Rows
                cmd = new SqlCommand("inserted into Employee_Details values(@Eno,@Ename,@Esal,@Etype)", con);

                cmd.Parameters.AddWithValue("@Eno", Empno);
                cmd.Parameters.AddWithValue("@Ename", EmpName);
                cmd.Parameters.AddWithValue("@Esal", Emp_sal);
                cmd.Parameters.AddWithValue("@Etype", Emptype);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    //Console.Read();

                    Console.WriteLine("\nEmployee added successfully!");
            }
            catch
            {
                //Console.WriteLine("Some error found");
            }
        }
        //-------------------------------------------------------------------
    }
}