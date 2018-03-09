using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    public class Teacher
    {
        public string _Firstname;
        public string _Lastname;
        public virtual void fullname()
        {
            Console.WriteLine("Teacher Fullname " + _Firstname + " " + _Lastname);
        }

        public virtual void OverridingMethod()
        {
            Console.WriteLine("This method will hides when Overriden - From Teacher class");
        }

        public virtual void HidingMethod()
        {
            Console.WriteLine("This method will Invoke when New keyword used - From Teacher class");
        }
    }
    public class PartimeTeacher : Teacher
    {

        public override void OverridingMethod()
        {
            Console.WriteLine("This method will  Invoke  when Overriden - From PartTeacher class");
        }

        public new void HidingMethod()
        {
            Console.WriteLine("This method will hides when New keyword used - From PartTeacher class");
        }
        
        public override void fullname()
        {
            Console.WriteLine("Part Time Teacher Fullname " + _Firstname + " " + _Lastname + " ");
        }
    }
    public class FulltimeTeacher : Teacher
    {
        public override void fullname()
        {
            Console.WriteLine("Full Time Teacher Fullname " + _Firstname + " " + _Lastname + "");
        }
    }

    public class TeamparoryTeacher : Teacher
    {
        public override void fullname()
        {
            Console.WriteLine("Teamparory Teacher Fullname " + _Firstname + " " + _Lastname + " ");
        }
    }


    public class Teachers
    {

        //Polymorphism allows you to invoke derived class methods through a base class reference during runtime.
        //In the base class the method is declared virtual, and in the derived class we override the same method.
        //the virtual keyword indicates, the method can be overridden in any derived class.

        public static void Main()
        {
            Teacher[] teacher = new Teacher[3];
            teacher[0] = new FulltimeTeacher();
            teacher[1] = new PartimeTeacher();
            teacher[2] = new TeamparoryTeacher();
            foreach (Teacher obj in teacher)
            {
                obj.fullname();
            }
            //Method Overriding vs method Hiding 
            //In method overriding Base class reference variable pointing to a child class object,will invoke the 
            //overriding 
            //In the child class.
            //In method hiding base class reference variable pointing to a Child object, will invoke 
            //the Hiden method in the base class

            Teacher Override = new PartimeTeacher();
         //will calls the Base class Methods
            Override.HidingMethod();
            //will calls the Child class Methods
            Override.OverridingMethod();

            Console.ReadKey();
        }
    }
}
