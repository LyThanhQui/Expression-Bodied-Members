using System;
using System.Collections.Generic;

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
    /* public class Location
     {
         private string locationName;
         public Location(string name) => locationName = name;
         public string Name => locationName;
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
     }*/
    //Indexers

    /* public class Sports
     {
         private string[] types = {"Cricket", "Baseball", "Basketball", "Football",
                               "Hockey", "Soccer", "Tennis","Volleyball" };
         public string this[int i]
         {
             get => types[i];
             set => types[i] = value;
         }
     }
     class Program
     {
         static void Main()
         {
             Sports sports = new Sports();
             Console.WriteLine(sports[4]);
             Console.WriteLine(sports[2]);
             Console.WriteLine("Press any key to exists");
             Console.ReadKey();
         }
     }*/
    //Expression bodied Members in C#: getters  and setters
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new ExprBodiedGettersnSetters();
            obj.EmpBasicSalaryList.Add(101, 1000);
            obj.EmpBasicSalaryList.Add(102, 1400);
            obj.EmpId = 101;
            Console.WriteLine($"The basic salary of EmpId {obj.EmpId} is: {obj.EmpBasicSalary}");
            obj.EmpId = 102;
           obj.EmpBasicSalary = 1600;
            Console.WriteLine($"The updated basic salary of EmpId {obj.EmpId} is: {obj.EmpBasicSalary}");
           
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
    class ExprBodiedGettersnSetters
    {
        public Dictionary<int, double> EmpBasicSalaryList = new Dictionary<int, double>();
        public int EmpId { get; set; }
        public double EmpBasicSalary
        {
            ///Expression Bodied Getter  
            get => EmpBasicSalaryList[EmpId];
            ///Expression Bodied Setter  
            set => EmpBasicSalaryList[EmpId] = value;
        }
    }
}