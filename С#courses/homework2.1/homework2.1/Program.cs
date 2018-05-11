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
            const int b = 10; int s = 0, rep = 0;
            int qua = 0;
            #region array initialisation
            int[] arr = new int[b] { 1, 3, 4, 3, 6, 7, 8, 9, 3, 2 };
            Console.Write("array: ");
            for (int i = 0; i != b; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] arr1 = new int[b] { 7, 3, 4, 3, 1, 2, 6, 8, 9, 3 };
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
                for (int j = i + 1; j < b; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        rep = arr[i];
                        break;
                    }
                }
            }
            for (int i = 0; i < b; i++)
            {
                if (arr[i] == rep)
                {
                    qua++;
                }
            }

            #endregion

            #region checking arrays' equivalence
            if (qua > 1)
            {
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (arr[i] == arr1[j])
                        {
                            s++;

                        }
                    }

                }
                s = s - ((qua * qua) - qua);
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (arr[i] == arr1[j])
                        {
                            s++;

                        }
                    }

                }
            }
            #endregion

            if (s == b)
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
            int b; int m = 0;
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
                for (int j = i + 1; j < b; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        rep = true;
                        m = arr[i];
                        break;
                    }
                }
            }
            if (rep == true)
            {
                Console.WriteLine("Array has at least one doubled element" + m);
            }
            else
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
    }

}
