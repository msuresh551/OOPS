using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace oopsconcepts
{

//    ---Inner Exception

//  The InnerException property returns the exception instance that caused the current
//exception.
//To retain the original exception pass it as a parameter to the constructor,
//of the current exception.
//Always check if inner exception is not null before accessing any property of the inner
//exception object ,else,you may get Null reference exception
//To get the type of inner exception use GetType() method

    class InnerException
    {


        public static void Main()
        {

            try
            {


                try
                {
                    Console.Write("Please enter First Number: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int j = Convert.ToInt32(Console.ReadLine());
                    int k = i / j;
                    Console.WriteLine("Result:{0} ", k);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    string filepath = @"C:\Users\SURESH\Desktop\Exce.txt";

                    if (File.Exists(filepath))
                    {
                        StreamWriter wr = new StreamWriter(filepath);
                        wr.Write(ex.Message);
                        wr.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException("File  not found", ex);
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("this is inner exception: {0}",exception.InnerException.Message);
                Console.WriteLine("this is Catch block exception: {0}", exception.Message);
                Console.ReadKey();
            }








        }
    }
}
