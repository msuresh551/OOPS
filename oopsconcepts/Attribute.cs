using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{



    //  Attribute
    //Attributes allow you to add declareative information to your program.
    //this information can be queried at runtime using reflection.
    //there are several Pre-Defined attributes provided by .NET.It is also Possible to create, your own Custom attributes.
    //A few pre-defined attributes with in the .NET framework:
    //Obsolute  -Marks types and type members outdated
    //WebMethod -To expose a method as an XML web service method
    //Serializable- Indiccates that a class can be serialized.
    //It is possible to customize the attribute using parameters.An attribute is a class that inherits from System.Attribute base class.

    class Attribute
    {
        public static void Main()
        {
            //you can not be used this method
            Calculater.add(10, 20);
            int i = Calculater.add(new List<int>() { 10, 20, 30, 40, 50 });
            Console.WriteLine("adding tion of two numbers are: " + i);
        }
    }
    public class Calculater
    {
        [Obsolete("Use Add(List<int> li) Method")]
        public static int add(int i, int j)
        {
            return i + j;
        }
        public static int add(List<int> li)
        {
            int sum = 0;
            foreach (int value in li)
            {
                sum = sum + value;
            }
            return sum;
        }
    }
}
