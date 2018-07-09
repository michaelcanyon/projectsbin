using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.Age = 18;
            student.Name = "Some student";
            Console.WriteLine(student.Name);
            StudentWithGrant studentwithgrant = new StudentWithGrant();
            studentwithgrant.Grant = 500;
            Person person = student;
            person.Name = "Any name";
            Console.WriteLine(person.Name);
            Student newStudent = (Student)person;//в скобочках - преобразование типовв


            PassengerCar passengerCar = new PassengerCar();
            Vehicle vehicle = PassengerCar;
            Console.WriteLine(newStudent.Name);



            //int[] array = new int[5];
            ////наследование - это механизм, который позволяет определить один объект на основе уже существующего

            //array[0] = 5;
            //array.SetValue(5, 0);


            //int x = array[0];
            //x = (int)array.GetValue(0);

          Console.ReadLine();
        }
    }
}
