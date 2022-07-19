using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                try
                {
                    if (value.Length > 3)
                    {
                        this.firstName = value;
                    }
                }
                catch (Exception)
                {

                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                try
                {
                    if (value.Length > 3)
                    {
                        this.lastName = value;
                    }
                }
                catch (Exception)
                {

                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                try
                {
                    if (age > 0)
                    {
                        this.age = value;
                    }
                }
                catch (Exception)
                {

                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get { return this.salary; }
            private set
            {
                try
                {
                    if (value > 650)
                    {
                        this.salary = value;

                    }

                }
                catch (Exception)
                {

                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}
