using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 157;
            //Int32 myInt32 = 999;
            //double myDouble = 5.7;
            //bool myFlag = true;
            //char myChar = 'q';
            //string myString = "Fucking string";
            //String Astring;


            //object myObject= 123;
            //myObject = "Строка - объект":
            //myObject = false;
            ////myobject includes int 157
            //myObject = myInt32;
            //int myInt2 = (int)myObject;
            //Console.WriteLine("Значение переменной myobject");
            //Console.WriteLine(myObject);
            //Console.WriteLine("Значение переменной myInt");
            //Console.WriteLine(myInt2);

            //byte myByte = 12;
            //myObject = myByte;
            //int myInt3 = (int)myObject;
            //Console.Write("Вывод текста как есть.");

            //Console.WriteLine("Enter text");
            //string inputString = Console.ReadLine();
            //Console.WriteLine(" You've entered text: ");
            //Console.WriteLine(inputString);

            //Console.WriteLine("Enter num");
            //int inputNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(" You've enterednum: ");
            //Console.WriteLine(inputNumber);

            //const int x = 15;

            //MyEnum myEnum = MyEnum.First;
            //Console.WriteLine((int)myEnum);
            //Console.WriteLine((int)MyEnum.Second);
            //Console.WriteLine((int)MyEnum.Third);



            //Console.WriteLine(DayOfWeek.Monday);
            //Console.WriteLine(DayOfWeek.Sunday);
            //Console.WriteLine((int)DayOfWeek.Thursday);

            DateTime datetime = DateTime.Now ;
            DateTime datetime2 = new DateTime();
            DateTime datetime3 = new DateTime(2018, 5, 6);
            Console.WriteLine(datetime);
            Console.WriteLine(datetime2);
            Console.WriteLine(datetime3);



            //Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
        enum MyEnum
        {
            First = 777,
            Second=157,
            Third

        }
    }
}
