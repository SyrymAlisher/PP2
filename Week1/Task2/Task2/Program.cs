using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    // new class name of the class
    public class Student
    {
        // variables in the class student
        string name;
        string id;
        int year;
        // constructor 
        public Student(string Name, string ID, int Year)
        {
            // variables in constructor write to the class 
            name = Name;
            id = ID;
            year = Year;
        }

        public void print() // to the output 
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Year:" + year);
        }

    }
    class Program
    {
        // a function to increase a year of the study
        static int inc(int year)
        {
            // add +1 to the year of study

            return year + 1;
        }
        static void Main(string[] args)
        {   
            string s = Console.ReadLine(); // input the name

           
            string i = Console.ReadLine();   // input the id

           
            int y = int.Parse(Console.ReadLine());  // input the year of the study, then convert to the int

            
            y = inc(y);   // use a function inc
            // create a new object in the class student, and add variables 
            Student A = new Student(s, i, y);
            // use method to the object A
            A.print();
            Console.WriteLine();
            // input the second name
            string s1 = Console.ReadLine();
            // input the second id
            string i1 = Console.ReadLine();
            // input the second year of the study, then converts to the int
            int y1 = int.Parse(Console.ReadLine());
            // create a new student B
            y1 = inc(y1);
            Student B = new Student(s1, i1, y1);
            // output the dates of student B
            B.print();
            Console.ReadKey();
        }
    }
}