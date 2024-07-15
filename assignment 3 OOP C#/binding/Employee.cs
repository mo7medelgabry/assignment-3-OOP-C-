using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_OOP_C_.binding
{
    internal class Employee
    {
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Employee()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");

        } 
        public virtual void GetEmpoyeeData()
        {
            Console.WriteLine($"Employee : Id {Id} , Name :{Name}, Age: {Age}");
        }


    }
}
