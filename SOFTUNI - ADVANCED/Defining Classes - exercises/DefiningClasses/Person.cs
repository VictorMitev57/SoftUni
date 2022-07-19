﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <properties //and //parameters>
        /// //////////////////////////////////////
        /// </constructors>
        
        
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(int age)
        {
            this.Name = "No name";
            this.Age = age;
        }
    }
}
