using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace oopsconcepts
{


    //--Reflection.
    // Reflectionn is the ability of inspecting an assembies metadata at runtime.It is used to 
    //find all types in an assembly and/or dynamically invoke methods in an assembly.

    //Uses of reflection:

    //  1.When you drag and drop a button on a win forms or an asp.net application. The
    //Properties window uses reflection to show all the properties of the button class.
    //So reflection is extensively used by IDE or a UI designers.

    // 2.Late binding can be achieved by using reflection. you can use reflection to
    //dynamically create an instance of a type, about which we don't have any information
    //at compile time.So,reflection enables you to use code that is not available at compile
    //time.

    //3.Consider an example where we have two alternate implementations of an interface.
    //you want to allow the user to pick on or the other using a config file.
    //with reflection, you can simply read instantiate an instance of that class.
    //this is another example for late binding using reflection.

    public class Reflection
    {
        public int i = 10;
        public int? j = null; 
        public void test()
        {
            
            Console.WriteLine("this is test method");
        }
        /// <summary>
        /// testing insnstructio
        /// </summary>
        public static void Main()
        {   

            Reflection_class obj = new Reflection_class();
            Type t = obj.GetType();
            // Type t = Type.GetType("oopsconcepts.Reflection_class");

            PropertyInfo[] properties = t.GetProperties();
            Console.WriteLine("Print number of Properties in Class Reflection");
            foreach (PropertyInfo Property in properties)
            {
                Console.Write("\nProperty Name  " + Property.Name + " \n Property type  " + Property.PropertyType);
            }

            MethodInfo[] methods = t.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.Write("\n method Name  " + method.Name + "return type" + method.ReturnType);
            }
            FieldInfo[] fieldinfo = t.GetFields();
            foreach (FieldInfo field in fieldinfo)
            {
                Console.WriteLine("\n Field Type  " + field.Name);
            }

            ConstructorInfo[] constructorinfo = t.GetConstructors();
            foreach (ConstructorInfo constructor in constructorinfo)
            {
                Console.WriteLine(constructor.Name);
            }

            //Console.WriteLine(  "Print J value"+j);
            //i = 30;
            //Console.WriteLine("Print after I value assigned j value  "+j);


            //Reference Types
            Reflection rf = new Reflection();
            rf.i = 10;
            rf.j = rf.i;
            Console.WriteLine("Present J value " + rf.j);
            rf.i = 20;
            Console.WriteLine("After changed the I value result is  " + rf.j);


            int k=10,m;
            string l="10", u;
            double n;
            m = Convert.ToInt32(l);



            Console.ReadLine();

        }
    }
    public class Reflection_class
    {
        public int i;

        public int _Id { get; set; }

        public Reflection_class()
        {
            Console.WriteLine("this is constructor class");
        }
        Reflection_class(int i)
        {
            Console.WriteLine("this is constructor class");
        }
        public void add()
        {
            Console.WriteLine("this is addition method");
        }


    }
}
