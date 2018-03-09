using System.Data;
using System;



//Simple Class Declaration

namespace oopsconcepts
{
    public delegate void samp();

    partial class Example
    {
        public void method1()
        {
            Console.WriteLine("Hello method1");

        }
        public void method3()
        {
            Console.WriteLine("Hello method3");

        }
    }




    partial class Example
    {
        //Declare Variables
        //Declare Methods
        public void method2()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            //Creating Object for Example Class

            Example objEx = new Example();

            samp del = new samp(objEx.method3);
            //      del += objEx.method2;
            del();
            Console.ReadLine();

        }
    }

}
