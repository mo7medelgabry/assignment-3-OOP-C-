using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_OOP_C_.binding
{
    internal class FullTimeEmployee :Employee
    {
        public FullTimeEmployee(int id, string name , int age ,decimal salary):base(id,name,age)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }

        public new  void GetEmployeeType()
        {
            Console.WriteLine("I'm Full time Employee");
        }
        public override void GetEmpoyeeData()
        {
            Console.WriteLine($"Full time employe Id= {Id}, Name={Name}, Age={Age}, Salary={Salary}");
        }


    }
}
