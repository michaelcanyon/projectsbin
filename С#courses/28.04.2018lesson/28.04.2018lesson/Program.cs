using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using space2.Subnamespace;

namespace _28._04._2018lesson
{
    class Program
    {
        static bool someBool;
        //правило: внутри класса объявлять переменные с большой буквы
        //underlineLowerCamelCase
        static int _lowerCamecase = -1;
        //Lowercamecase
        static int lowerCamecase = 1;
        //UpperCameCase
        static int Height = 157;
        const int SOME_CONST = 5;
        static void Main(string[] args)
        {

            //SomeClass exampleClass = new SomeClass();
            //examplexlass.Number = 10;// обращение к классу
            //space2.Subnamespace.examplexlass.Number = 10;//полное обращение к классу
            ////TODO: енто напоминалка туду оператор напоминалки в комантариях


            //int x = 157;
            //Console.WriteLine("x = " + x);
            //{
            //    int y = 23;


            //}

            //преобразования типов
            byte b = 25;
            //byte to 255 and can't contain no more
            Console.WriteLine("b = " + b);
            int x = b + 5;
            Console.WriteLine("x = " + x);
            /*byte newByte = (byte)x;*/// byte will be overloaded by int 26

            //Явное преобразование инт к байту


            //byte newByte = (byte)x;
            //Console.WriteLine("newByte = " + newByte);
            //int newInt = (int)9.6;
            //Console.WriteLine("newInt = " + newInt);
            //int newInt2 = Convert.ToInt32(-127.7);
            //Console.WriteLine("newInt2 = " + newInt2);

            //арифметические операции
            //+ - * / % есть бинарные операции
            //// Унарные операции ++ и --
            //int a = 5 + 7;
            //Console.WriteLine("a = " + a);
            ////a++;//postfix
            //Console.WriteLine("a = " + a++);
            ////++a;//prefix
            //Console.WriteLine("a = " + ++a);
            ////long sum
            //a = a + 10;
            ////short equivalent
            //a += 10;

            //Logical operations
            //bool trueBool = true;
            //bool falseBool;
            //Console.WriteLine(trueBool);
            ////declared in main 
            //Console.WriteLine(someBool);
            //// logical and
            //bool first = true && true;
            //bool second = true || false;
            //Console.WriteLine(first);
            //Console.WriteLine(second);
            //bool third = true ^ true;//xor Взаимоисключающее или
            //Console.WriteLine(third);
            //third = true ^ false;
            //Console.WriteLine(third);
            //third = false ^ false;
            //Console.WriteLine(third);
            ////выражение высчитывается целиком, если ставим одинарный оператор (пр. |)
            //bool result = true | false && (true && false) || (trueBool ^ (true || false));
            //bool result2 = false && true | true;

            ////сравнение > < == >= =<
            ////ветвление
            //int input;
            //Console.Write("enter num");
            //input = Convert.ToInt32(Console.ReadLine());

            ////bool greaterThenZero = 10 > 0;
            ////if (input>0)

            ////{
            ////    Console.WriteLine("иф выполнился");

            ////}
            ////else if(input==0)
            ////{

            ////}
            ////else
            ////{
            ////    Console.WriteLine("else выполнился");

            ////}



            //if (input > 0)

            //{
            //    Console.WriteLine("иф выполнился");
            //    Console.ReadLine();
            //    return;
            //}
            //else if (input == 0)
            //{

            //}
            ////если пишем return, то элс необязателен, т.к выходим из метода

            //{
            //    Console.WriteLine("else выполнился");
            //    return;
            //}
            ////switchcase operator
            int input3;
            Console.WriteLine("Enter Week day: ");
            input3 = Convert.ToInt32(Console.ReadLine()) % 7;
            DayOfWeek day = (DayOfWeek)input3;
            switch (day)
            {

                case DayOfWeek.Monday:
                    Console.WriteLine("Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine(" ne Monday");
                    break;
                default:
                    Console.WriteLine("Tyt kakoy to translit po defoltu");
                    break;
            }
            //тернарный оператор 
            string somevalue = (day == DayOfWeek.Sunday) ? "It's Sunday!" : "It's not a Sunday";// через двоеточие варианты выполнения-вывода
            

            //циклы
            //while
            while(false)
            {
                Console.WriteLine("AAAA");

            }
            //do while
            do
            {
                Console.WriteLine("one iteration");

            }
            while (false);
            //for cycle
            int i= 0;
           for(;i<10;i++)
            {
                if(i%2 !=0)
                { continue; }
                Console.WriteLine("Interation " + i);
                //if (i>5)
                //{ break; }
                for (int j = 0; j < length; j++)
                {

                }
            }






            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }
    }
}
namespace space2.Subnamespace
{
    class examplexlass
    {
        public static int Number = 157;
    }

}
