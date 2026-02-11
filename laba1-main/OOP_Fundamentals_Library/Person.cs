using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals_Library
{
    public abstract class Person
    {
        
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            protected set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым");
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("Некорректный возраст");
                _age = value;
            }
        }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        
        public abstract void PrintInfo();
    }
}
