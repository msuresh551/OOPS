using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{

    interface IA
    {
        void A();
    }
    class AClass : IA
    {
        public void A()
        {
            Console.WriteLine("this is A class method");
        }
    }
    interface IB
    {
        void B();

    }
    class BClass : IB
    {
        public void B()
        {
            Console.WriteLine("this is B class Method");
        }
    }

    /// <summary>
    /// Once you have implemented Interfaces you should specify the Interface methods inside the classs .
    /// </summary>
    public class MultipleClassesInheritabceUsingInterfaces : IA, IB
    {

        AClass a = new AClass();
        BClass b = new BClass();
        public void A()
        {
            a.A();
        }
        public void B()
        {
            b.B();
        }

        public static void Main()
        {
            MultipleClassesInheritabceUsingInterfaces mi = new MultipleClassesInheritabceUsingInterfaces();
            mi.A();
            mi.B();
            Console.ReadLine();

        }

    }



}
