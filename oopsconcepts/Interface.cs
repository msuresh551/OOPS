using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{

    //Creating an Interface
    /// <summary>
    //    we create interface  using interface keyword. Just like classes interfaces also contains properties
    //methods,Delegates or events, but only declarations and no implementations.
    //It is a compile time error to provide implementations for any interface member.
    //Interface members are public by default, and they do not allow explicit access modifiers.
    //Interfaces cannot contain fields
    //If a class or a struct inheirts from an interface, it must provide implementation for all interface
    //members, Otherwise,we get a compiler error.
    //A class or a struct can  inherit from more then one interface at the same time,but where as,
    //a class can not inherit from more than once class at the same time.
    //Interfaces can inherit from other interfaces.A class that inherits this interface must provide
    //implementation for all interface members in the entire interface inheritance chain.
    //we can not create an instance of an interface, but an interface referece variable can point
    //to a derived class object.
    //Interface Naming Convention: interface names are prefixed with capital I.
    /// </summary>
    interface IEmployee
    {
        void Empdetails();

    }
    public class sample : IEmployee, Iarth, Iarthametic, Idefault
    {
        //when we did not specify any explicit interface it will call default interface
        public void add()
        {
            Console.WriteLine("this is Default Interface");
        }

        //Access modifiers are not allowed on explicitly implemented
        void Iarth.add()
        {
            Console.WriteLine("this is arth interface");
        }
        //Access modifiers are not allowed on explicitly implemented
        void Iarthametic.add()
        {
            Console.WriteLine(" This is I arthametic Interface");
        }

        public void Empdetails()
        {
            Console.WriteLine("Employee Name is Suresh, Sal :30000,  Age:24 and Employee ID:");
        }
        static void Main(string[] args)
        {
            IEmployee obj = new sample();
            obj.Empdetails();

            //If we declare as Obj.add() there is a ambiguti which interface method will be call first.
            ((Iarth)obj).add();
            ((Iarthametic)obj).add();
            //or you can do following too
            Iarthametic Iartmetid = new sample();
            Iartmetid.add();
            Iarth Iart = new sample();
            Iart.add();
            sample smapleobj = new sample();
            smapleobj.add();
            Console.ReadLine();
        }
    }


    //    Question : A class inherits from 2 interfaces and both the interfaces have the same
    //method name. How should the class implement the method for both the Interface ?
    // We are using Explici Interface Implemention technique to solve this Problem.
    //Note: when a class explicitly implements, an interface member, the interface member can
    //    //no longer be accessed through class reference variable, but only truought the interface reference variable
    //    If you want to make one of the interface method, The Default, then Implement that method
    //normally and the other interface method explicitly. this makes the default method to be accessible thrue class instatce
    interface Iarth
    {
        void add();
    }
    interface Iarthametic
    {
        void add();
    }
    interface Idefault
    {
        void add();
    }
}
