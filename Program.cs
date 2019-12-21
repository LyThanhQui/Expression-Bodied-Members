﻿using System;

namespace Expression_Bodied_Members
{
    public class Employee
    {
        private string FirstName;
        private string LastName;
        private int Age;
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }
          public string GetFullName() => $"{FirstName} {LastName} {Age}";
        //public string GetFullName()
       //{
        //    return FirstName + " " + LastName + " " + Age;
       // }
        public override string ToString() => $"{FirstName} {LastName} {Age}";
        public void DisplayName() => Console.WriteLine(GetFullName());
    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Qui", "Ly", 25);
            employee.DisplayName();
            Console.WriteLine(employee);
            Console.WriteLine("Press any key to exists");
            Console.ReadKey();
        }
    }
}