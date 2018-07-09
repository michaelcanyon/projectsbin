using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_05_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int factorial = Factorial(5);
        }

        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
