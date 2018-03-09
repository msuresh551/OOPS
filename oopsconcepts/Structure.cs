using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{





    //    Structs

    //Just like Classes Structs can have
    //1) Private Fields
    //2)Public Properties
    //3) COnstructors
    //4)Methods

    //Object Initializers Syntax introduced in C# 3.0 can be used to initialize either
    //a struct or a class

    //Note: there are several differeces between Class and Structucts
    interface Emp
    {
        void test();
    }
    public struct Structure:Emp
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Structure(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public void test()
        {
            Console.WriteLine("Test the Interface method");
        }
        public void fullname()
        {
            Console.WriteLine("Employee ID " + ID);

            Console.WriteLine("Employee Full name " + Name);
        }

    }
    public class sample_Ex
    {
        public static void Main()
        {
            Structure st = new Structure();
            st.ID = 10;
            st.Name = "Suresh";
            st.test();
            st.fullname();

            Structure constructorobj = new Structure(20, "suresh mogulada");
            constructorobj.fullname();





            //Object initializer from C# 3.0
            Structure objin = new Structure
            {

                ID = 30,
                Name = "Suresh kumar moguldala"

            };
            objin.fullname();
            Console.ReadKey();
        }
    }
}
