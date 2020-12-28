using System;
using Newtonsoft.Json;
//A1,3
namespace Rextester
{
    
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int birthdate_timestamp { get; set; }
        public bool is_overseer { get; set; }
      
    }
    
    public class Unit
    {
        public string Title { get; set; }
        public Employee[] Employees { get; set; }
        public Unit[] Subordinate_units { get; set; }
    }
    
    
    public class Company
    {
        public string Title { get; set; }
        public Unit[] Subordinate_units { get; set; }

        
    }
   
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee trainee = new Employee
            {
                Name = "Ekaterina",
                Surname = "Smirnova",
                birthdate_timestamp = 13012000,
                is_overseer = false
            };
            
            Employee teamlead = new Employee
            {
                Name = "Aleksey",
                Surname = "Malkov",
                birthdate_timestamp = 00215502,
                is_overseer = true
            };
            
            Unit java_backendrs = new Unit
            {
                Title = "java_backenders",
                Employees = new Employee[] {trainee, teamlead},
                    Subordinate_units = new Unit[] {}
            };
            
            Company greenatom = new Company
            {
                Title = "bruh_company",
                Subordinate_units = new Unit[] {java_backenders}
            };
            
            string result = JsonConvert.SerializeObject(greenatom);
            Console.WriteLine(result);
        }
    }
}
