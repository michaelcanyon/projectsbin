using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._05._2018
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            FourteenTask();
        }
        static void FourteenTask()
        {
            int[,] matrix;
        int size = 0;
        Console.WriteLine("Введите размерность матрицы");
            size = int.Parse(Console.ReadLine());
            matrix = new int[size, size];
            //заполнение элементов массива случайными значениями
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            int determinant = 0;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                //matrix[0, i]*|minor(matrix[0,i])|
            }

            Console.ReadLine();

        }
        static int[,] GetMinor(int[,] matrix, int x , int y)
        {
            int[,] minor = new int[matrix.GetLength(0)-1, matrix.GetLength(0) - 1];
            //счётчики
            int a = 0, b = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

            if(i==x)
                {
                    continue;
                }
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                    if (j == y)
                    { continue;
                        minor[a, b] = matrix[i, j];
                        b++;
                    }
            }
                a++;
                b = 0;
            return minor;
        }
        static int  GetDeterminant(int[,] minor)
            {
                if(matrix.GetLength(0)==2)
                {
                    return matrix[0, 0]*matrix[1,1]-matrix[1,0]*matrix[0,1];
                }
            }

    }
}
