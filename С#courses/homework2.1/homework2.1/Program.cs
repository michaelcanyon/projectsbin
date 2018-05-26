using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._1
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {

            int u;
            Console.WriteLine("enter task number: ");
            u = Convert.ToInt32(Console.ReadLine());
            switch (u)
            {

                case 1:
                    Task1();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    Task9();
                    break;
                case 10:
                    Task10();
                    break;
                case 11:
                    Task11();
                    break;
                case 12:
                    task12();
                    break;
                case 13:
                    task13();
                    break;
                case 15:
                    task15();
                    break;
                case 16:
                    Task16();
                    break;
                case 17:
                    Task17();
                    break;
            }
            Console.ReadLine();

        }

    #region Task 1
        static void Task1()
        {
            int b;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            FeelingInArray(arr);
            Printarray(arr);
            Console.WriteLine("inverted array: ");
            for (int i = b - 1; i != 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
        #endregion
        static void Printarray(int[] arr)
        {
            Console.Write("array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void FeelingInArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
        }

    #region Task 2
        static void Task2()
        {
            int b;
            int min = 100, mi = 0, max = 0, mai = 0, average = 0, length;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            Console.Write("array: ");
            Printarray(arr);
            FeelingInArray(arr);
            for (int i = 0; i != b; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            average = (min + max) / 2;
            Console.WriteLine("Average between " + min + " " + max + " equals " + average);

        }
        #endregion

    #region Task 3
        static void Task3()
        {
            int b, i;
            int temp;
            Console.WriteLine("Enter array length");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            FeelingInArray(arr);
            Printarray(arr);
            Console.WriteLine();
            Console.WriteLine("Enter the number of shifted elements: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            n %= arr.Length;
            for (i = 0; i < n; i++)
            {
                for (int j = arr.Length - 1; j != 0; j--)
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
            Console.Write("Array shifted on " + n + " elements: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        #endregion

    #region Task 4
        static void Task4()
        {
            int i;
            bool flag = true;
            const int b = 7, c = 6;
            int[] test1 = new int[b] { 1, 2, 3, 4, 3, 2, 1 };
            int[] test2 = new int[c] { 1, 2, 3, 3, 2, 1 };
            int[] test3 = new int[c] { 1, 2, 3, 4, 2, 1 };
            Printarray(test3);
            for (i = 0; i != test3.Length; i++)
            {
                if (test3[i] != test3.Length - 1 - i)
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(!flag ? "Array is not polindrom " : "Array is polindrom ");
        }
        #endregion

    #region Task 5
        static void Task5()
        {
            const int b = 10; int nmax = int.MaxValue;
            int qua = 0;
            #region array initialisation
            int[] arr = new int[b] { 1, 3, 4, 3, 6, 7, 2, 9, 3, 2 };
            Printarray(arr);
            int[] arr1 = new int[b] { 7, 3, 4, 3, 1, 2, 6, 2, 9, 3 };
            Printarray(arr1);
            #endregion
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        arr1[j] = nmax;
                        qua++;
                        break;
                    }
                }
            }
            Console.WriteLine(qua == b ? "Elements of the second array are transfered elements of the first array " : "Array one is not similar to the second array");
        }
        #endregion

    #region Task 6
        static void Task6()
        {
            int b = 4; int m = 0;
            bool rep = false;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            Console.Write("array: ");
            for (int i = 0; i != b; i++)
            {
                arr[i] = rand.Next(1, 100);
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < b; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    rep = true;
                    m = arr[i];
                    Console.WriteLine("Doubled element: " + m);
                }
            }
            if (rep == false)
            {
                Console.WriteLine("Array has no doubled elements");
            }
        }
        #endregion

    #region Task 7
        static void Task7()
        {
            int i;
            int b;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            Console.Write("array: ");
            for (i = 0; i != b; i++)
            {
                arr[i] = rand.Next(5, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            i = 0;
            while (--arr[i] != 0)
            {
                if (i++ == arr.Length - 1)
                {
                    i = 0;
                }
                Console.Write("array: ");
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

    #region Task 8
        static void Task8()
        {
            const int b = 7;
            int i;
            bool flag = false;
            object[] arr = new object[b] { "Mai", 30, 75, "c", "$%#$", 70, 98.110 };
            Console.Write("Array: ");
            for (i = 0; i < b; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            for (i = 0; i < b; i++)
            {
                if (arr[i] is int)
                {
                    int g;
                    // TODO: int.tryParce
                    bool result = int.TryParse(arr[i].ToString(), out g);
                    g %= 10;
                    if (g == 0)
                    {
                        Console.WriteLine("round number :" + arr[i]);
                        flag = true;
                    }
                }

            }
            if (flag == false)
            {
                Console.WriteLine("Array has no round numbers");
            }


        }
        #endregion

    #region Task 9
        static void Task9()
        {
            const int size = 3;
            int[,] matr = new int[size, size] { { 15, 0, 0 }, { 0, 15, 0 }, { 0, 0, 15 } };
            Console.WriteLine("matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matr[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0, k = size - 1; i < size && k != 0; i++, k--)
            {
                for (int j = i + 1, m = k - 1; j < size && m != 0; j++, m--)
                {
                    if (i != j && matr[i, j] != 0 || i == j && matr[i, j] != matr[0, 0])
                    {
                        Console.WriteLine("Matrix contains numbers in wrong positions.It can't be unique.");
                        return;
                    }
                }
            }
            Console.WriteLine("This matrix is the result of  multiplicity to unique matrix " + size + "*" + size);
        }
    #endregion

    #region Task 10
    static void Task10()
    {
        int a;
        int b;
        int max = 0;
        Console.WriteLine("enter matrix dimension ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("*");
        b = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[a, b];
        randmatrdir(a, b, matrix);
        int[] ar = new int[a];
            Console.WriteLine("array of maximal string numbers: ");
            for (int i = 0; i < a; i++)//!a
            {
                max = matrix[i, 0];
                for (int j = 0; j < b; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                ar[i] = max;
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            max = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }

            }
            Console.WriteLine("Maximal element from found is " + max);
        }
    static void randmatrdir(int a, int b, int[,] matrix)
    {
        Console.WriteLine("Matrix: ");
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matrix[i, j] = rand.Next(2, 20);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Task11
    static void Task11()
    {

        int b;
        Console.WriteLine("Enter array dimension");
        b = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[b];
        int[] average = new int[b];
        int avr;
        Console.Write("array: ");
        for (int i = 0; i != b; i++)
        {
            arr[i] = rand.Next(0, 100);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Average array:");
        for (int i = 0; i < b; i++)
        {

                avr = ((i + 1) != b ? (arr[i] + arr[i + 1]) / 2 : (arr[i] + arr[0]) / 2);
            Console.Write(avr + " ");
        }
        Console.WriteLine();
    }
    #endregion

    #region task12
    static void task12()

    {
        int size;
        Console.WriteLine("Enter matrix dimension: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[,] matr = new int[size, size];
        Console.WriteLine("matrix: ");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matr[i, j] = rand.Next(1, 9);
                Console.Write(matr[i, j] + " ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
        maindiag(matr);
        lowtriang(matr, size);
        hightriang(matr, size);
        chess(matr, size);
    }
        static void maindiag(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matr[i, i]);
                    }
                    else
                    {
                        Console.Write(matr[i, i]);
                    }
                }
                Console.WriteLine();
            }
        }
    static void lowtriang(int[,] matr, int size)
    {
        Console.WriteLine("Low triangle: ");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(matr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void hightriang(int[,] matr, int size)
    {
        Console.WriteLine("High triangle: ");
        for (int i = 0; i < size; i++)
        {
            for (int k = 0; k < i; k++)
            {
                Console.Write("  ");
            }
            for (int j = i + 1; j < size; j++)
            {

                Console.Write(matr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void chess(int[,] matr, int size)
    {
        Console.WriteLine("Chess: ");
        for (int i = 0; i < size; i++)
        {
            if ((i % 2) == 0)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j % 2) == 0)
                    {
                        Console.Write(matr[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

            }
            else
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j % 2) == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(matr[i, j] + " ");
                    }

                }

            }
            Console.WriteLine();
        }
    }
    #endregion

    #region task13
    static void task13()
    {
        int size;
        size = rand.Next(4, 15);
        int b;
        int[,] matr = new int[size, size];
        Console.WriteLine("matrix: ");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matr[i, j] = rand.Next(1, 9);
                Console.Write(matr[i, j] + " ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Enter string and column number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("changed matrix: ");
        for (int i = 0; i < size; i++)
        {
            if (i == b)
            {
                continue;
            }
            for (int j = 0; j < size; j++)
            {
                if (j == b)
                {
                    continue;
                }
                Console.Write(matr[i, j] + " ");

            }
            Console.WriteLine();
        }
    }
    #endregion

    #region task15
    static void task15()
    {
        char ch;
        int qua = 1;
        Console.WriteLine("enter any string: ");
        string str = Console.ReadLine();
        int size = str.Length;
        char[] del =str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            if (del[i] == '$')
            {
                continue;
            }
            ch = del[i];
            for (int j = i + 1; j < str.Length; j++)
            {
                if (del[i] == del[j])
                {
                    qua++;
                    ch = del[j];
                    del[j] = '$';

                }

            }
            Console.WriteLine("The symbol " + ch + " appears " + qua + "-ce");
            qua = 1;
        }

    }
    #endregion

    #region Task16
    static void Task16()
    {
        Console.WriteLine("enter any string: ");
        string str = Console.ReadLine();
        int size = str.Length;
        char[] del = new char[size];
        for (int i = 0; i < str.Length; i++)
        {
            del[i] = str[i];
        }
        Console.Write("iversed string: ");
        recu(del, size - 1);

    }
    static int recu(char[] del, int b)
    {
            Console.Write(del[b]);
            return b == 0 ? 0 : recu(del, b - 1);

        }
    #endregion

    #region task17
    static void Task17()
    {
        int x = 0;
        Console.WriteLine("Enter any number ");
        int b = Convert.ToInt32(Console.ReadLine());
        x = calculation(b);
        Console.WriteLine("Factorial equals " + x);

    }
    static int calculation(int b)
    {
           return (b==0? 1:b * calculation(b - 1));
    }
    #endregion
}

}
