using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Customer          // ---------> define member variables. (Properties)
    {
        public int CustomerId;
        public string Name;
        public string Address;

        Customer()          // --------> define constructor.
        {
            CustomerId = 12345;
            Name = "Shivam";
            Address = "Delhi";
        }

        public void displayData()           // -------> define display method.
        {
            Console.WriteLine("Customer ID: " + CustomerId);
            Console.WriteLine("Customer Name: {0}", Name);
            Console.WriteLine("Customer Address: {0}", Address);
        }
    
        static void Main(string[] args)
        {
            Customer obj = new Customer();          // --------> Object instantiation.
            obj.displayData();              // --------> invoke the displayData Method.


            demo obj1 = new demo();
            obj1.addition();        // --------> invoke the addition Method.


            Console.ReadLine();
        }
    }
    // ---------------- Multiple Class Declaration ----------------------------- (1)
    class demo          // ---------> define 2nd class in same namespace
    {
        int x = 12, y = 14, z;          //------> define members and variable.

        public void addition()          //---------> define addition method.
        {
            z = x + y;
            Console.WriteLine("Other class in namespace");
            Console.WriteLine("Sum of given number is: {0}", z);
        }
    }

    


}
