using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Student
    {
        // Data members
        public int rollNo;
        public string name;
        public string className;
        public string semester;
        public string branch;
        public int[] marks = new int[5];

        // Constructor to initialize student details
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        // Method to set marks for all 5 subjects
        public void GetMarks(int[] subjectMarks)
        {
            if (subjectMarks.Length != 5)
            {
                Console.WriteLine("Invalid number of subjects.");
                return;
            }

            for (int i = 0; i < subjectMarks.Length; i++)
            {
                marks[i] = subjectMarks[i];
            }
        }

        // Method to calculate and display result
        public void DisplayResult()
        {
            double totalMarks = 0;

            // Calculate total marks and check if any subject has marks less than 35
            foreach (int mark in marks)
            {
                totalMarks += mark;
                if (mark < 35)
                {
                    Console.WriteLine("Result: Failed (Marks of at least one subject is less than 35)");
                    return;
                }
            }

            // Calculate average marks
            double averageMarks = totalMarks / marks.Length;

            // Check if average marks are less than 50
            if (averageMarks < 50)
            {
                Console.WriteLine("Result: Failed (Average marks are less than 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        // Method to display student data
        public void DisplayData()
        {
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + className);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }
        }

        // Main
        static void Main(string[] args)
        {
            // Get student details from user
            Console.WriteLine("Enter Roll No:");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Class:");
            string className = Console.ReadLine();

            Console.WriteLine("Enter Semester:");
            string semester = Console.ReadLine();

            Console.WriteLine("Enter Branch:");
            string branch = Console.ReadLine();

            // Create a new student object
            Student student = new Student(rollNo, name, className, semester, branch);

            // Get marks for 5 subjects from user input
            int[] subjectMarks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter marks for Subject " + (i + 1) + ":");
                subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
            }
            student.GetMarks(subjectMarks);

            // Display result and student data
            student.DisplayResult();
            student.DisplayData();

            Console.ReadLine();
        }
    }
}