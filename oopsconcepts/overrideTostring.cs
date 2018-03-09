using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    class overrideTostring
    {

        public static void Main()
        {
            overrideclass oc = new overrideclass();
            oc.Fname = "Suresh";
            oc.Lname = "Mogudlala";
            //returns the oopsconcept.overrideclass before overriding the ToString() method
            Console.WriteLine(oc.ToString());
          //  Console.WriteLine( Convert.ToString(oc));
           
            
            Console.ReadLine();
        }

    }
    class overrideclass
    {
        public string Fname;
        public string Lname;
        public override string ToString()
        {
            return Fname + " " + Lname;
        }

    }
}
