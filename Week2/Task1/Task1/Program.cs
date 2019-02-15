using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = File.ReadAllText(@"C:\Users\Сырым\Downloads\github\PP2\Week2\Task1\Task1\input.txt");
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            string s = new string(b);
            if (s == a)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}
