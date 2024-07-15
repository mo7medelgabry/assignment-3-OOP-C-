using assignment_3_OOP_C_.binding;
using assignment_3_OOP_C_.polymorphism;
using System;

namespace assignment_3_OOP_C_
{
    internal class Program
    {
        public static void ProcessEmployee(Employee  employee)
        {
            if(employee != null)
            {
                employee.GetEmployeeType();
                employee.GetEmpoyeeData();
            }
        }
      


        #region over loading
        public static int sum(int x, int y)
        {
        return x + y; 
               }
        public static int sum(int x, int y, int z)
        {

        return x + y + z; }

        public static double sum(double x, double y) { 
         return x + y;
           }

        public static double sum(double x, int y)
        {

        return x + y; }
        #endregion


        static void Main(string[] args)
        {

            #region polymorphism overloading
            int result = sum(1, 2);
            Console.WriteLine(result);

            result = sum(1, 2, 3);
            Console.WriteLine(result);
            double result02 = sum(1.2, 2.3);
             Console.WriteLine(result02);

            #endregion

            #region polymorohism overriding 
           // suported with class only 
           // function over riding must be with relationships [inheritance]
            
            typeA typeA = new typeA(1);
           
            typeA.A = 10;
            typeA.myfun01(); // i'm base
            typeA.myfun02(); // typeA : A = 10
            
            typeB typeB = new typeB(1,2);
            typeB.A = 10;
            typeB.B = 20;

            typeB.myfun01();
            typeB.myfun02();
            #endregion


            #region binding
            // ref from parent => obj from child 

            typeA refBase;
            refBase = new typeB(1,2);
            refBase.A = 10;
            refBase.myfun01();
            refBase.myfun02();
            #endregion

            #region not binding 

            //typeA TypeA = new typeA(1);

            // typeB typeB1= (typeB)typeA; // explicit casting 

            typeA TypeA = new typeB(1, 2);
            typeB TypeB = (typeB) TypeA;
            Console.WriteLine(TypeB.A);
            Console.WriteLine(TypeB.B);



            #endregion


            #region employee EX 

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Mohamed", 25, 10000);
            ProcessEmployee(fullTimeEmployee);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Id=20,
                Name="Ahmed",
                Age=35,
                HourRate=2.5M,
                CountOfHours=30,
            };
             ProcessEmployee(partTimeEmployee);

            #endregion

        }
    }
}
 