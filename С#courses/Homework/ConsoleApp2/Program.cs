using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            short age = short.Parse(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.Write("Your name's ");
            Console.WriteLine(name);
            Console.Write("Your age's ");
            Console.WriteLine(age);
            Console.Write("Today is  ");
            Console.WriteLine(date);
            Console.ReadLine();






        }
    }
}
