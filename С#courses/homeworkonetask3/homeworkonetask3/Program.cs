using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkonetask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = -1, z, c, b, h, i;
            Console.Write("Enter triangle's height: ");
            h = Convert.ToInt32(Console.ReadLine());
            switch (h)
            {
                case 0:
                Console.WriteLine("height equals 0. Triangle doesn't exist");
                Console.ReadLine();
                break;
                default:
            if (h < 0)//пользователь ввёл отрицательное число. Берем его по модулю
            {
                h = h * (-1);
            }
            int[] arr = new int[h];
            for (i = 0; i < h; i++)//количество строк
            {
                m = m + 2;
                arr[i] = m;//количество символов '^' в каждой строке

            }
            Console.WriteLine("triangle: ");
            for (i = 0; i < h; i++)
            {
                z = (m - arr[i]) / 2;//z - количество пробелов до начала выведения '^'
                c = z + arr[i];// c - граница конца выведения '^'
                for (b = 0; b <= c; b++)//печать треугольника
                {
                    if (b == z)
                    {
                        for (b = z + 1; b <= c; b++)
                        {
                            Console.Write("^");
                        }
                    }
                    Console.Write(" ");//печать пробелов до символов '^'
                }
                Console.WriteLine();//перевод строки
            }

            Console.ReadLine();
                break;
            }
        }
    }
}
