using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkonetask2
{
    class Program
    {
        static void Main(string[] args)
        {


            int sum = 0;
            Console.Write("enter borders of your span: ");
            Console.Write("from ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("to ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("span [" + a + "," + b + "]");
            if (a == b)//т.к в тз нужно обозначить отрезок, необходимо учесть, что в сумме при нечетном числе в отрезке будет лежать одно значение
            {
                int k = a % 2;
                switch (k)
                {
                    case 0:
                        Console.WriteLine("a=b. Span doesen't contain any nubers. ");
                        break;
                    default:
                        Console.WriteLine("a=b. Span doesen't contain any nubers. Sum contains one meaning ");
                        break;
                }

            }
            if (b < a)
            {
                int temp;
                temp = b;
                b = a;
                a = temp;
                Console.WriteLine("Calculations will be completed in [" + a + "," + b + "] span");
            }
            for(int i=a;i<=b;i++)
            {
                if(i%2!=0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of odd numbers equals " + sum);
            Console.ReadLine();
        }
    }
}
