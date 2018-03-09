using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    public class Methodoverloading
    {

        //Method overloading allows a class to have multiple methods with the same name but with a different signature.
        //So, In C# functions can be overloaded based on the number,type(int, float etc) and kind 
        //(value, Ref or Out) of parameters
        //The signature of a method consists of the name of the method and 
        //the type, kind (value, reference, or output) and the number of its formal parameters.
        //The signature of a method does not include the return type and the params modifier.
        //So, it is not possible to overload a function, just based on the return type or params 
        //modifier.

        public static void Main()
        {
            //number of parameters
            add(20, 30);
            add(20, 30, 40);
            //Kind of parameters
            mul(20, 30.5f);
            //Type of parameters
            int sum = 0;
            add(20, 30, ref sum);
            //sum
            added(10,20,out sum);

            Console.ReadKey();
        }

        /// <summary>
        /// Number of parameters 
        /// </summary>
        public static void add(int i, int j)
        {

            Console.WriteLine("sum of Two numbers is " + (i + j));
        }
        public static void add(int i, int j, int k)
        {
            Console.WriteLine("sum of Three numbers is " + (i + j + k));
        }

        /// <summary>
        /// Kind of Parameters
        /// </summary>
        public static void mul(int i, float j)
        {
            Console.WriteLine("Kind of Parameters Multiplication of two numbers " + i * j);
        }

        /// <summary>
        /// Type of Parameters
        /// </summary>

        public static void add(int i, int j, ref int k)
        {
            Console.WriteLine("Reference sum of Two numbers is " + (i + j));
            k = (i + j);
        }

        public static void added(int i,int j,out int k)
        {
            
            Console.WriteLine("Reference sum of Two numbers is " + (i + j));
            k = 20;
        }

    }
}
