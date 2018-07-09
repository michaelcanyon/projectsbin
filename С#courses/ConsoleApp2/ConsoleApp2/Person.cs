using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person

    {

        public string Name { get; set; }
        protected int Age { get; set; }


    }
    class Student : Person
    {
        public string[] Subject { get; set; }

        void DoSomething()
        {
        }
    }
    class StudentWithGrant : Student
    {
        public int Grant { get; set; }
    }



    abstract class Vehicle//абстрактный класс - это такой класс, экземпляр которого невозможно создать
    {
        void Move()
        { }

    }

    class Car : Vehicle
    { }

    class PassengerCar : Car
    { }

    class Truck : Car
    { }
}
