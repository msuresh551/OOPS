using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    public partial class Partialclass
    {
        private static string _Fname;

        public static string Fname
        {
            get { return Partialclass._Fname; }
            set { Partialclass._Fname = value; }
        }

        private static string _Lname;

        public static string Lname
        {
            get { return Partialclass._Lname; }
            set { Partialclass._Lname = value; }
        }

      
        public static void Main()
        {
            Console.WriteLine("----using Partial class ---");
            Partialclass.Fname = "Suresh";
            Partialclass.Lname = "Mogudala";
            Console.WriteLine(Partialclass.fullname());
            Console.ReadLine(  );
        }
    }
}
