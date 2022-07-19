using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private int age;
        private string gender;
        private string name;
        protected Animal(string name, int age, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;

        }
        public int Age 
        {
            get
            {
                return this.age;    
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException(nameof(this.Age), "Age is negative nimber");
                }
                this.age = value;
            }
        }
        public string Name 
        {
            get
            {
                return this.name;
            }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Name), "Invalid name");
                }
                this.name = value;
            } 
        }
        public string Gender 
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Gender), "Invalid gender");
                }
                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.
                AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .AppendLine($"{this.ProduceSound()}");

            return sb.ToString(); 
        }
    }
}
