using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2
{
    class Task2
    {
        static bool isPrime(int x) //function to chech is number prime
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); ++i)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText(@"C:\Users\Сырым\Downloads\github\PP2\Week2\Task2\Task2\input.txt").Split();
            using (StreamWriter file = new StreamWriter(@"C:\Users\Сырым\Downloads\github\PP2\Week2\Task2\Task2\output.txt"))
            {
                foreach (string number in text)
                {
                    int x = Convert.ToInt32(number);//convert to int
                    if (isPrime(x))//checking for prime
                        file.Write(number + " ");//print prime numbers with space
                }
            }
        }
    }
}
