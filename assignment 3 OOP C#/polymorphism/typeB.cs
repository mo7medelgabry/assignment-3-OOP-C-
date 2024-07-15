using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_OOP_C_.polymorphism
{
    internal class typeB : typeA
    {
    
        
       public int B { get; set; }

        public typeB(int a, int b):base(a) { 
         
         B = b;
        
        }
        // 2 ways for override 
        // using new keyword 
        // using override keyword 
        public new void myfun01()
        {
            Console.WriteLine(" i'm derived (child)");
        }

        public override void myfun02()
        {
            Console.WriteLine($"typeA : A {A} typeB : B {B}");
        }

    }
}
