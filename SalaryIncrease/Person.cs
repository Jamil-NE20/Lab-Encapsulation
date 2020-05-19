using System;
using System.Collections.Generic;
using System.Text;


namespace SalaryIncrease
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary; 


        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public decimal Salary
        {
            get { return this.salary; }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary} dollars.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age >= 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
    }
}
