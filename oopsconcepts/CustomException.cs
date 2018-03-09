using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace oopsconcepts
{

    //    --Custom Exception
    //1.Create a class that derives from System.Exception class.As a convention, end
    //the class name twith Exception suffix.All .net exceptions end with, exception suffix.
    //2.Provide a public constructor , that takes in a string parameter.this constructor
    //simply passes the string parameter, to the base exception class constructor
    //3.Using Innerexceptions, you can also track back the original exception. If you want to 
    //provide this capability for your custom exception class,then overload the constructor
    //accordingly.
    //4.If you want your exception class object to work across application domains, then
    //the object must be serializable. To make your exception class serializable mark it with
    //seriablizable attribute and provide a constructor that invokes the base exception class
    //constructor that takes in serialization info and streamingContext object as parameters.

    //Note: It is also possible to provide your own custoom serializtion, which will discuss in a 
    //later session

    public class CustomException
    {
        public static void Main()
        {
            try
            {
                throw new CustomEx("this is Custom Exception");
            }
            catch (CustomEx ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    public class CustomEx : Exception
    {
        public string Message = " this is Custom Exception";

        public CustomEx()
            : base()
        {
        }
        public CustomEx(string message)
            : base(message)
        {
        }


    }






}
