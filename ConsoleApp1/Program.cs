using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String UserName = Console.ReadLine();
            Console.Write("What is your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("What is your height in meter: ");
            float Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0}, and you reply your age as {1} and you height {2}",UserName, Age.ToString(), Height);
            Console.ReadKey();
        }
    }
}
