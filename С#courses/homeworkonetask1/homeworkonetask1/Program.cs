using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkonetask1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int j;
            Console.WriteLine("Enter any numbersyou want to sum. 0 will be a signal to stop: ");
            double num = Convert.ToDouble(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("You haven't entered any number. ");
                    Console.ReadLine();
                    break;
                default:

                    for (j = 0; num != 0; j++)//отсчёт с нуля, т.к не учитываю введенный ноль
                    {
                        sum += num;
                        num = Convert.ToDouble(Console.ReadLine());


                    }
                    double mar = sum / j;
                    Console.WriteLine("Quantity of numbers without 0: " + j);
                    Console.WriteLine("Sum equals " + sum);
                    Console.WriteLine("Average equals" + mar);

                    Console.ReadLine();
                    break;

            }
        }
    }
}
