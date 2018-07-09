using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03._05._2018
{
    static class Program
    {
        static void Main()
        {
            #region методы
            //method's name
            SimpleMethod();
            //int methodResult = SimpleMethodInt();
            //int x = 5, y =7;
            //int methodResult2 = SimpleMethodWithParameters(x, y);
            //Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            //Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            //Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            //Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            //Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            //Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            //int x = 5;
            //int y = 7;
            //int methodResult = SimpleMethodWithParameters(x,y);
            //Console.WriteLine("Результат выполнения метода сохранен в переменную methodResult и равен" + methodResult);
            //вызываем метод, возвращающий значение, не сохраняя результат
            //SimpleMethodInt();
            //int sum1 = Sum(5, 10);
            //double sum2 = Sum(20.1, 17);
            //long sum3 = Sum(10000000000, 1);
            //int sum4 = Sum(1, 2, 3);
            //int sum5 = Sum();
            //int sum6 = Sum(1);
            //int sum7 = Sum(1, 2);
            //int Sum8 = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            int intRef = 1;

            //в реф должны инициализировать переменную чем-то
            //Console.WriteLine("intRef до вызова метода: " + intRef);
            //SimpleMethodRefParameter(ref intRef);
            //Console.WriteLine("intRef after вызова метода: " + intRef);

            ////out позволяет принять в метод неинициализированную переменную
            //int intOut;
            ////Console.WriteLine("intOut до вызова метода: " + intOut);
            //SimpleMethodOutParameter(out intOut);
            //Console.WriteLine("intOut after вызова метода: " + intOut);
            int input;
            Console.WriteLine("Enter num: ");
            string inputString = Console.ReadLine();
            //Нормальное преобразование строки к числу - TryParse
            bool parceResult = int.TryParse(inputString, out input);
            if (parceResult)
            {
                Console.WriteLine("Пользователь ввёл число" + input);
            }
            else
            {
                Console.WriteLine("Пользователь ввёл не число. переменная инпут равна" + input);
            }
            //Не удачное преобразование с падением проги
            input = int.Parse(inputString);
            Console.WriteLine("Пользователь ввёл число" + input);

            Console.ReadLine();

            #endregion
            #region Массивы
            //одномерные массивы
            //тип[] имя
            //int[] array;//massive reference
            ////инициализация массива
            //array = new int[5];
            ////другой вариант инициализации
            //int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
            ////one more variant - работает только при объявлении и инициализации в одной строке
            //int[] array3 = { 1, 2, 3, 4, 5 };


            //array[0] = 1;
            //int x = array[0];


            //Console.WriteLine("a[0]= " + x);
            //Console.WriteLine("Длина массива Array: " + array.Length);
            //for(int i=0;i<array.Length;i++)
            //{
            //    array[i] = i;
            //    Console.WriteLine(array[i])
            //}


            //Двумерные массивы
            int[,] twoDimensionalArray = new int[3, 3];
            for(int i=0;i<twoDimensionalArray.GetLength(0);i++)
            { for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = i + j;
                    Console.Write(twoDimensionalArray[i,j]+" ");
                }
                Console.WriteLine();
                }
            Console.WriteLine("Количесво элементов массива" + twoDimensionalArray.Length);
            Console.WriteLine("Размерность массива" + twoDimensionalArray.Rank);
            //многомерный массив
            int[,,,] strangeArray = new int[2, 4, 6, 8];

            //генерация случайных значений
            Random rand = new Random();
            rand.Next(0, 10);

            //рваный массив
            int[][] jaggedArray = new int[5][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[rand.Next(0, 10)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rand.Next(0, 10);
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }












            Console.ReadLine();
            #endregion
        }
        //Сигнатура метода - void SimpleMethod()
        static void SimpleMethod()
        {
            Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            return;
        }
        //Сигнатура метода - int SimpleMethodInt()
        //Тип озвращаемого значения 
        static int SimpleMethodInt()
        {
            int a = 5;
            int b = 7;
            int c = a + b;
            return c;
        }
        //Параметры методов
        static int SimpleMethodWithParameters(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //перегрузка метода
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static long Sum(long a, long b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        //params - только к последнему параметру метода
        static int Sum(params int[] intParams)
        {
            int result = 0;
            for(int i=0; i<intParams.Length;i++)
            {
                result += intParams[i];
            }
            return result;
        }
        //ref
        static void SimpleMethodRefParameter(ref int a)
        {
            a = 100;

        }
        //out
        static void SimpleMethodOutParameter(out int a)
        {
            a = 100;

        }
    }
}
