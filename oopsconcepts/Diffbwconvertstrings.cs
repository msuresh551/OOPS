using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    class Diffbwconvertstrings
    {
        // Convert.Tostring() handles NULL, while ToString() doesn't, 
        // Difference between == verifies the reference where as equal method verifies the values
        public static void Main()
        {

            equaldiff obj1 = new equaldiff();
            obj1.Firstname = "suresh";
            obj1.LastName = "Mogudala";
            equaldiff obj2 = obj1;
            if (obj2 == obj1)
            {
                Console.WriteLine("obj1 is equal to Obj2");
            }
            equaldiff obj3 = new equaldiff();
            obj3.Firstname = "suresh";
            obj3.LastName = "Mogudala12";
            if (obj1.Equals(obj3))
            {
                Console.WriteLine("obj1 is equal to obj3");
            }

            if (obj1 != obj3)
            {
                Console.WriteLine("obj1 is not equal for == symbol");
            }
            Console.ReadLine();
        }
    }
    class equaldiff
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            equaldiff objtemp = (equaldiff)obj;
            return (Firstname == objtemp.Firstname) && (LastName == objtemp.LastName);
        }
    }
}
