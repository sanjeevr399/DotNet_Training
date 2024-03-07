using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_3
    {

        class Doctor
        {
            private int RegnNo;
            private string Name;
            private double FeesCharged;

            // Method
            public void SetValues(int regnNo, string name, double feesCharged)
            {
                RegnNo = regnNo;
                Name = name;
                FeesCharged = feesCharged;
            }

            // display doctor details
            public void Display()
            {
                Console.WriteLine("Doctor Registration Number: " + RegnNo);
                Console.WriteLine("Doctor Name: " + Name);
                Console.WriteLine("Doctor Fees Charged: " + FeesCharged);
            }
        }

        class Doc
        {
            static void Main(string[] args)
            {
                //instance of the Doctor class
                Doctor doctor = new Doctor();

                Console.WriteLine("Enter Doctor Registration Number:");
                int regnNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Doctor Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Doctor Fees Charged:");
                double feesCharged = double.Parse(Console.ReadLine());

                // Set the valuse
                doctor.SetValues(regnNo, name, feesCharged);

                Console.WriteLine("\nDoctor Details:");
                doctor.Display();
                Console.ReadLine();
            }
        }
}