using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void dublicate(string[] s, int n) // Method dublicate with 2 parameters
        {
            string[] doubled = new string[n * 2]; // String array
            for (int i = 0, j = 0; i < n; ++i)
            {
                doubled[j++] = s[i]; // Doubling
                doubled[j++] = s[i];
            }
            for (int i = 0; i < 2 * n; ++i)
                Console.Write(doubled[i] + " ");
        }
        static void Main(string[] args)
        {
             // reading first line and converting to int
            int n = int.Parse(Console.ReadLine());
            string[] numb = Console.ReadLine().Split(); // reading second line an array of string by split
            dublicate(numb, n); // Method thats dubplicate each of element
            Console.ReadKey();
        }
    }
}