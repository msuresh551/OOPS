using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{

    //Class

    //Have fields,Properties,Constructors,Interfaces and Methods
    //Have destrutors.
    //where as classes are stored on the heap.
    //Reference to an object in memory.
    //The Object is later Destroyed by garbage Collector.
    //when you copy a class into another class , we only get a copy of the reference variable. 
    //Both the reference variables point to the same object on the same heap.
    //So, operations on one variable will affect the values contained by the other reference variable.

    //Structure :
    //Have fields,Properties,Constructors,Interfaces and Methods.
    //Structures are not have Destructor.
    //structure are stored on the stack, 
    //Have fields,Properties,Constructors and Methods
    //Value types hold theire value in memory where they are declared 
    //value types are destroyed immediately after the scope is lost, where as for reference types
    //only the reference variable is destroyed after the scope is lost.
    //when you copy a struct into another struct the values contained by the other struct.


    public class StructVsClass
    {
        public int id;
        public string Name;

       

    }

    
//structs can not have explicit parameter less contructor where where class can.
//Structs can not inherit from another class where as a class can, Both structs and classes can
//inherit from an interface

    
//Note1: A class or a struct can not inherit from another struct. struct are sealed types
//Note2: How do you prevent a class from being inherited or what is the significance of 
//sealed keywork
    public struct structcls
    {

        public static void Main()
        {
            int i = 10;
            //will create another place and will not effect when we change j value
            int j = i;
            Console.WriteLine("J value before changed "+j);
            j = 12;
            Console.WriteLine("after value modified "+j+" and I value is "+i);


            StructVsClass Obj1 = new StructVsClass();
            Obj1.id = 101;
            Obj1.Name = "Suresh";
            Console.WriteLine("Obj1 value before changes ID= "+Obj1.id+" and Nmae "+Obj1.Name);
            StructVsClass obj2 = Obj1;

            obj2.id = 102;
            obj2.Name = "Naresh";
            Console.WriteLine("Obj1 value before changes ID= " + Obj1.id + " and Nmae " + Obj1.Name);
            
            Console.ReadLine();
        }
    }




}
