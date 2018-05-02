using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkonetask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            int q;
            string surname;
            int age;
            int average;
            int max=0;
            int min=120;
            int sum = 0;
            string maxsurname = "You haven't entered any names", minsurname = "You haven't entered any names";


            Console.WriteLine("Enter the quantity of visitors: ");
            q = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<q;i++)
            {
                Console.WriteLine("Visitor " + (i+1));
                Console.Write("surname: ");
                surname =  Convert.ToString(Console.ReadLine());
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<min)
                {
                    min = age;
                    minsurname = surname;


                }
                if(age>max)
                {
                    max = age;
                    maxsurname = surname;
                }
                sum = sum + age;


            }
            Console.WriteLine("the oldest visitor is " + maxsurname + "  It's age:" + max);
            Console.WriteLine("the youngest visitor is " + minsurname + "  It's age:" + min);
            average = sum / q;
            Console.WriteLine("Average age is " + average);
            Console.ReadLine();



        }
    }
}
