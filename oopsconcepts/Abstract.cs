using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{



    // Abstract Classes
    // The abstract keyword is used to create abstract classes.
    // An abstract class is incomplete and hence can not be instantiated.
    // An abstract class can only be used as base class.
    // An abstract class can not be sealed.
    // an abstract class may contain abstract members(methods,Properties,indexers and events) but not mandatory.
    // A non-abstract class derived from an abstract class must provide implementations
    // for all inherited abstract members
    // If a class inherits an abstract class, there are 2 options available for that class
    //Option1: Provide implementation for all the abstract members inherited from the base abstract class
    //Option 2: if the class does not wish to provide implementation for all the abstract members
    //inherited from the abstract class, then the class has to be marked as abstract.

    public abstract class Abstract
    {
        //abstract method will only can declations can not have definations/implementation
        public abstract void display();
        public void addd()
        {
            Console.WriteLine("this is add method");
        }
    }
    //if you do not want to provide implementation for the abstract members to the derived class .
    // make derived class as abstract 
    public class Testabstract : Abstract
    {
        public override void display()
        {
            Console.WriteLine("Test abstrct method");
        }
        public static void Main()
        {
            //super class reference variable can point to the derived class object. viseversa not possible.
            Abstract ab = new Testabstract();
            ab.display();
            ab.addd();
            Console.ReadLine();
        }
    }

}
