//We have an Employee Model, now we need to add another class, which will communicate with Entity Framework to retrieve and save the data
//As you can see ‘EmpDBContext’ is derived from an EF class known as ‘DbContext’. In this class, we have one property with the name DbSet, 
//which basically represents the entity which you want to query and save

using System;
using System.Data.Entity;

namespace MVCScaffoldingDemo.Models{
   public class Employee{
      public int ID { get; set; }
      public string Name { get; set; }
      public DateTime JoiningDate { get; set; }
      public int Age { get; set; }
   }
	
   public class EmpDBContext : DbContext{
      public DbSet<Employee> Employees { get; set; }
   }
}
