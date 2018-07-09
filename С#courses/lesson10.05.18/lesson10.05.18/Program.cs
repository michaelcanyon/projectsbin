using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10._05._18
{
    class Program
    {
        static string[] BookNames;
        static string[] BookAuthors;
        static int[] BookYear;
        static int[] BookCost;

        static void Main(string[] args)
        {
            //Book book1 = new Book();
            //book1.ShowInfo();
            //Book book2 = new Book(); ;
            //book2.Name = "Some name";
            //book2.Year = 1999;
            //Book book1 = new Book();
            //book book2;
            Program p = new Program();
            //p.

            int.Parse
            #region old
            //BookNames = new string[5];
            //BookAuthors = new string[5];
            //BookYear = new int[5];
            //BookCost = new int[5];

            //BookNames[0] = "Какое-то название";
            //BookAuthors[0] = "Какой-то автор";
            //BookYear[0] = 2000;
            //BookCost[0] = 150;
            //SHowBookInfo(BookNames[0], BookAuthors[0], BookYear[0], BookCost[0]);
            #endregion
            Console.ReadLine();

        }
        static void BuyBook(string bookName, int bookCost)
        {
            //Покупка книги покупателем
        }
        static void SHowBookInfo(string bookName, string bookAutjor, int bookYear, int bookCost)
        {
            Console.WriteLine("Книга '{0}'(author{1} came out ");
        }
    }
    struct Book
    {
        //поле структуры
        public string Name;
        string Author;
        private int Year;//по дефолту ставится к описательному элементу объекта
        int Cost;

        //Метод структуры
        public void ShowInfo()
        {
            Console.WriteLine("Book '{0}' (author{1} was printed at {2}, Цена {3}", Name, Author, Year, Cost);
        }
        

        //class Book
        //{ }

        //class Person
        //{ }
    }
    public Book()
    {
        //Че-то тут написано про конструктор
    }

    public Book(string name)
    {
        Name = Name;

    }
    