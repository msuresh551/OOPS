using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace oopsconcepts
{

    //---Exception Handling
    //  An exception is an unforeseen error that occurs when a program is running.
    // Examples: 
    //    Trying to read from a file that does not exist, throws FileNotFoundException.
    //    Trying to read from a database table that does not exist, throws a SqlException.

    // Showing actual unhandled exceptions to the end user is bad for two reasons.
    //1.Users will be annoyed as they are cryptic and does not make much sense to one users.
    //2.Exceptions contain information, that can be used for hacking into your application

    //   An exception is actually a class that derives from System.Exception class.
    //the System.Exception class has several useful properties, that provide valuable
    //information about the exception.

    //Message: Gets a message that describes that current exception.
    //Stack Trace: Provides the call stack to the line number in the method where the 
    //exception occurred.

    //Releasing System Resources

    //We use try,catch and finally blocks for exception handling
    //Try- The Code that can possibly cause an exception will be in the try block.
    //catch- Handles the Exception
    //finally -Clean and free resources that the class was holding onto during 
    //the program execution. Finally block is optional.
    // Note: it is a Good Proctice to always release resources in the finally block, 
    //because finally block is guauranteed to exceute, irrespective of the whether
    //there is an exception or not.

    //  Specific exceptions will be caught before the base generalexception, So
    //specific exception blocks should always be on top of the base exception block
    //Otherwise, You will encounter a compiler error.
    public class Exceptionalhandling
    {
        public static void Main()
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"C:\Users\SURESH\Desktop\C#-tex.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                Console.ReadLine();
            }

            catch (FileNotFoundException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
