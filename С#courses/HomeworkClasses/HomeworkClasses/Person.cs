﻿using System;
namespace HomeworkClasses
{
    abstract class Person
    {
        // TODO: создать конструктор для переменных данного класса+
        private int _age;
        private string _name;
        protected Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("Empty name field"); }
                _name = value;
            }
        }// TODO: сделать проверку на пустоту имени+
        public int Age
        {
            get{return _age;}
            set
            {
                if (value < 14 || value > 120)
                {
                    throw new ArgumentException("Person is too young or old for work");
                }
                _age = value;
            }
        }
    }
}
