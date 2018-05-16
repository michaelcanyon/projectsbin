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
            //arrprint();
            //average();
            //elshift();
            //palindrom();
            //switchedel();
            //doubleel();
            //arraydec();
            //objarr();
            //looknumm();
            //lookarrmax();
            //averagearr();
            //task12();
            //task13();
            //task15();
            //recurcearr();
            //fact();

            Console.ReadLine();

        }

        #region arrprint
        static void arrprint()
        {
            int b;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            Console.Write("array: ");
            for (int i = 0; i != b; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("inverted array: ");
            for (int i = b - 1; i != 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
        #endregion

        #region average
        static void average()
        {
            int b;
            int min = 100, mi = 0, max = 0, mai = 0, average = 0, length;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            Console.Write("array: ");
            for (int i = 0; i != b; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");
                if (arr[i] < min)
                {
                    min = arr[i];
                    mi = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    mai = i;
                }
            }
            if (mi > mai)
            {
                int temp = mi;
                mi = mai;
                mai = temp;
            }
            length = (mai - mi) + 1;
            for (int i = mi; i <= mai; i++)
            {
                average += arr[i];
            }
            average /= length;
            Console.WriteLine("Average between " + min + " " + max + " equals " + average);

        }
        #endregion

        #region element shifting
        static void elshift()
        {
            int b, i;
            int temp;
            Console.WriteLine("Enter array dimension");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            Console.Write("array: ");
            for (i = 0; i != b; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Enter the number of shifted elements: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i != n; i++)
            {
                for (int j = b - 1; j != 0; j--)
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;

                }
            }

            Console.Write("Array shifted on " + n + " elements: ");
            for (i = 0; i != b; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }
        #endregion

        #region palindrom
        static void palindrom()
        {
            int i, j;
            bool flag = true;
            const int b = 7, c = 6;
            int[] test1 = new int[b] { 1, 2, 3, 4, 3, 2, 1 };
            int[] test2 = new int[c] { 1, 2, 3, 3, 2, 1 };
            int[] test3 = new int[c] { 1, 2, 3, 4, 2, 1 };

            Console.Write("array: ");
            for (i = 0; i != c; i++)
            {
                Console.Write(test3[i] + " ");

            }
            for (i = 0, j = c - 1; i != c; i++, j--)
            {

                if (test3[i] != test3[j])
                {
                    flag = false;
                }


            }
            if (flag == false)
            {
                Console.WriteLine("Array is not polindrom ");
            }
            else
            {
                Console.WriteLine("Array is polindrom ");
            }
        }
        #endregion

        #region 2 arrays with switched elements
        static void switchedel()
        {
            const int b = 10; int s = 0, rep = 0; int nmax = 9999;
            int qua = 0;
            #region array initialisation
            int[] arr = new int[b] { 1, 3, 4, 3, 6, 7, 2, 9, 3, 2 };
            Console.Write("array: ");
            for (int i = 0; i != b; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] arr1 = new int[b] { 7, 3, 4, 3, 1, 2, 6, 2, 9, 3 };
            Console.Write("array2: ");
            for (int i = 0; i != b; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            #endregion

            #region check for equal elements in array
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
            #endregion
            if (qua == b)
            {
                Console.WriteLine("Elements of the second array are transfered elements of the first array ");
            }
            else
            {
                Console.WriteLine("Array one is not similar to the second array");
            }
        }

        #endregion

        #region looking for doubled elements
        static void doubleel()
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
                if (i == b - 1)
                {
                    continue;
                }
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

        #region looking for minimal element
        static void arraydec()
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
            for (i = 0; i <= b; i++)
            {
                if (i == b)
                {
                    Console.Write("array: ");
                    for (int j = 0; j != b; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }
                    Console.WriteLine();
                    i = 0;
                    arr[i]--;
                    continue;
                }
                if (arr[i] == 0)
                {
                    Console.WriteLine("Element number " + i + " equals " + arr[i]);
                    break;
                }
                arr[i]--;

            }
        }
        #endregion

        #region looking for round int
        static void objarr()
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

                    int g = Convert.ToInt32(arr[i]);
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

        #region checking unique matrix
        static void looknumm()
        {
            const int size = 3;
            bool flag = true;
            bool flag2 = true;
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
                    if ((matr[i, j] != 0) || (matr[k, m] != 0))
                    {
                        Console.WriteLine("Matrix contains numbers in wrong positions.It can't be unique.");
                        flag = false;

                    }

                }
            }
            if (flag == true)
            {
                int elem = matr[0, 0];
                for (int i = 0; i < size; i++)
                {
                    if (matr[i, i] != elem)
                    {
                        flag2 = false;
                    }
                }
                if (flag2 == false)
                { Console.WriteLine("Matrix diagonal elements is not equal. It's not the result of num multiplicity to unique matrix"); }
                if (flag2 == true)
                { Console.WriteLine("This matrix is the result of " + elem + " multiplicity to unique matrix " + size + "*" + size); }
            }

        }
        #endregion

        #region looking max matrix element
        static void lookarrmax()
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
            int[] arr = new int[a];
            fillingarr(arr, a, b, matrix, max);





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
        static void fillingarr(int[] ar, int a, int b, int[,] matrix, int max)
        {
            Console.WriteLine("array of maximal string numbers: ");
            for (int i = 0; i < a; i++)
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
        #endregion

        #region average array
        static void averagearr()
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


                if ((i + 1) != b)
                {
                    avr = (arr[i] + arr[i + 1]) / 2;
                }
                else
                {
                    avr = (arr[i] + arr[0]) / 2;
                }
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
                    Console.Write(" ");
                }
                Console.Write(matr[i, i]);
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
            char[] del = new char[size];
            for (int i = 0; i < str.Length; i++)
            {
                del[i] = str[i];

            }
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
        static void recurcearr()
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
            recu(del, size-1);

        }
        static int recu(char[] del, int b)
        {
            if (b == 0)
            {
                Console.Write(del[b]);
                return 0;
            }
            else
            {
                Console.Write(del[b]);
                return recu(del ,b-1);
            }


        }
        #endregion

        #region task17
        static void fact()
        {
            int x = 0;
            Console.WriteLine("Enter any number ");
            int b = Convert.ToInt32(Console.ReadLine());
            x=calculation(b);
            Console.WriteLine("Factorial equals " + x);

        }
        static int calculation(int b)
        {

            if (b == 0)
            {
                return 1;
               
            }
            else
            {

                return b *calculation(b-1) ;
                
            }

        }
        #endregion
    }

}
