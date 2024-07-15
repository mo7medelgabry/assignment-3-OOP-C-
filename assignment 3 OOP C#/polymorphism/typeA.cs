using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_OOP_C_.polymorphism
{
    internal class typeA
    {

        public int A { get; set; }
        //auto property 
        // compiler will generate hidden private att [ backing field ] 


        public typeA(int a)
        {
            A = a;
        }

        public void myfun01() {
            Console.WriteLine("i am base {parent}");
        }
        public virtual void myfun02()
        {
            Console.WriteLine($"TypeA :A= {A}");
        }

    }
}
