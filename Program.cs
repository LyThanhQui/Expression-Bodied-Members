﻿using System;

namespace Expression_Bodied_Members
{
    //1. Method
    /*public class Employee
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
    */
    //2. Contrutors & Detructors
    /* public class Location
      {
          private string locationName;
          public Location(string name) => locationName = name;
          ~Location() => Console.WriteLine($"Location{ locationName }is destructor");
          public string Name
          {
              get => locationName;
              set => locationName = value;
          }
      }
      class Program
      {
          static void Main()
          {
              Location location = new Location("Qui");
              Console.WriteLine(location.Name = "Thanh Qui");  
              Console.WriteLine("Press any key to exists");
              Console.ReadKey();
          }
      }
      */
    //3. Property get
    /*  public class Location
      {
          private string locationName;
          public Location(string name) => locationName = name;
          public string Name
          {
              get => locationName;
              set => locationName = value;
          }
      }
      class Program
      {
          static void Main()
          {
              Location location = new Location("Qui");
              Console.WriteLine(location.Name);
              Console.WriteLine("Press any key to exists");
              Console.ReadKey();
          }


      }
      */
    //Read-only properties that use an expression body definition
    public class Location
    {
        private string locationName;
        public Location(string name) => locationName = name;
        public string Name => locationName;
    }
    class Program
    {
        static void Main()
        {
            Location location = new Location("Mumbai");
            Console.WriteLine(location.Name);
            Console.WriteLine("Press any key to exists");
            Console.ReadKey();
        }
    }
}