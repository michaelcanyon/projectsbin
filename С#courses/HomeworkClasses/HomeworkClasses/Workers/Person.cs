using System;
namespace Workers
{
    abstract class Person
    {
        private int _age;
        private string _name;

        /// <summary>
        /// Конструктор человека. Используется в классах-наследниках
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        protected Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Empty name field");
                _name = value;
            }
        }

        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 14 || value > 120)
                    throw new ArgumentException("Person is too young or old for work");
                _age = value;
            }
        }
    }
}
