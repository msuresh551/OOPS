using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace oopsconcepts
{
    class Enums
    {
        //        -- Enums

        // Enums are strongly typed constants.
        // If a program uses set of integral numbers, consider replacing them with
        //enums. Otherwise the program becomes less
        //  Readable, Maintainable.
        // --Types vs Type Members
        //  In this example Customer(class) is the Type and Fields,Properties and method are type members.
        //So, in general classes,structs,enums,delegates are called as types and 
        //fields,properties,constructors,methods etc.that normally reside in a type are called as type
        //memberes.

        public static void Main()
        {
            customer[] cuarr = new customer[4];
            cuarr[0] = new customer { name = "Mahesh", gender = Gender.Unknow };
            cuarr[1] = new customer { name = "suresh", gender = Gender.Male };
            cuarr[2] = new customer { name = "Pradeep", gender = Gender.Male };
            cuarr[3] = new customer { name = "Bunny", gender = Gender.Female };
            foreach (customer c in cuarr)
            {
                Console.WriteLine("Name : {0} && Gender : {1}", c.name, getgender(c.gender));
            }
            Console.ReadLine();
        }
   
        
        public static string getgender(Gender gen)
        {
            string getgender = "";
            switch (gen)
            {
                case Gender.Unknow:
                    getgender = "Unknow";
                    break;
                case Gender.Male:
                    getgender = "Male";
                    break;
                case Gender.Female:
                    getgender = "Female";
                    break;
            }
            return getgender;

        }

    }
    public class customer
    {
        public string name { get; set; }
        // public int Gender { get; set; }
        public Gender gender { get; set; }
        public static string GetGender(int i)
        {
            string getGender = "";
            switch (i)
            {
                case 1:
                    getGender = "Unknow Gender";
                    break;
                case 2:
                    getGender = "Male";
                    break;
                case 3:
                    getGender = "FeMale";
                    break;
            }
            return getGender;

        }

    }
    public enum Gender
    {
        Male,
        Female,
        Unknow
    }

}
