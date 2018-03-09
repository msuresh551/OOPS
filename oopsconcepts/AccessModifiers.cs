using System;
using oopsconcepts;

namespace oopsconcepts
{

    
//--Access Modifiers

//in c# there are 5 different access modifiers:
//1.private
//2.protected
//3.internal
//4.protected internal
//5.public

//private members are available only with in the containing type, where as public members
//are available any where. there is no restriction.
//protected memberes are available, with in the containing type and to the types
//that derive from the containing type.

//access modifier			accessibility    
//private          only with in the containing class
//public           any where, no restrictions
//protected         with in the containing types and the types derived from the 
//                  containing type 
//--internal and protected internal
//  a member with internal access medifier is available any where with in the containing
//assembly, it's a comile time error to access,an internal member from outsite the 
//containing assembly.

// protected internal members can be accessed by any code in the assembly in which it
//is declared, or from within a derivved classs in another assembly.it is a combination of
//protected and internal.
//internal: anywhere with in the containing assembly.
//protected internal : anywhere with in the containing assembly. and from within a derived
//class in any another assembly.
//default access modifiers for the types(classes,delegates,abstract,interface,enums) -----internal
//default access modifier for the type members(methods,events,properties)----private

    public class Employee_AM
    {

        private int _id;
        public int ID;
        protected int Id;
        public void test()
        {
        }
        internal int intenal_ID;
        protected internal int Protected_internal_ID;
    }
    public class SuperEmployee_Am : Employee_AM
    {
        public void method()
        {
            Console.WriteLine("this is protected value " + Id);
        }

    }



    public class AccessModifiers
    {
        public static void Main()
        {

            SuperEmployee_Am s = new SuperEmployee_Am();
            s.method();
            Console.ReadKey();
        }
    }
}
