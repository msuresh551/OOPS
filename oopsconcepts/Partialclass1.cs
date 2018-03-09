using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
   public partial class Partialclass
    {

        public static string fullname()
        {
            return "Your name : " + Partialclass.Fname + " " +Partialclass.Lname;
        }
    }
}
