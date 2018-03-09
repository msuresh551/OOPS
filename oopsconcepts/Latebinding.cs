using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace oopsconcepts
{
    class Latebinding
    {

        public static void Main()
        {

            // OOPS Early binding Vs Late Binding
            //  1. Early binding can flag errors at compile time.With Late binding there is a risk of
            //run time exceptions.
            //  2.Early binding is much better for performance and should always be preferred over 
            //Late binding.Use late binding only when working with an objects that are not 
            //available at compile time.
            // 3.Late binding is complecated.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type employeeType = executingAssembly.GetType("oopsconcepts.earlybind");
            object employeeInstance = Activator.CreateInstance(employeeType);
            MethodInfo mi = employeeType.GetMethod("getEmployeename");
            string[] param = new string[1];
            param[0] = "Suresh m";
            String fullname = (string)mi.Invoke(employeeInstance, param);
            Console.WriteLine("Fullname " + fullname);
            // earlybind eb = new earlybind();
            //string employeename=eb.getEmployeename("Employee");
            //Console.Write("Employee Full Name" + employeename);
            Console.ReadKey();

        }

    }
    //class earlybind
    //{
    //    public string getEmployeename(String s)
    //    {
    //        return s;
    //    }
    //}
}
