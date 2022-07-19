using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {

            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
