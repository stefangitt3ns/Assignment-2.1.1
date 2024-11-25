using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment 2.1.1";
            Student Stefan = new Student (12345, "Stefan", "Gittens", 'A');
            Console.WriteLine(Stefan); 
            Console.ReadKey();

        }

        private class Student
        {
            public int StudentId;
            public string StudentFname;
            public string StudentLname;
            public char StudentGrade;

            public Student (int studentId, string studentFname, string studentLname, char studentGrade)
            {
                this.StudentId = studentId;
                this.StudentFname = studentFname;
                this.StudentLname = studentLname;
                this.StudentGrade = studentGrade;
            }

            public override string ToString()
            {
                return $"The student's name is {StudentFname} {StudentLname}, \ntheir StudentID is {StudentId}, \ntheir current grade is = {StudentGrade}";
            }

        }





    }

}
