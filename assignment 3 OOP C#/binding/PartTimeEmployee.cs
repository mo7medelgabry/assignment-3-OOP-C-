using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_OOP_C_.binding
{
    internal class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate {  get; set; }
        
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Partime Employee");
        }

        public override void GetEmpoyeeData()
        {
            Console.WriteLine($"PartTimeEmployee : Id={Id}, Name={Name}, Age={Age}, HourRate={HourRate} , countofhour = {HourRate}");
        
            
        
        }

    }
}
