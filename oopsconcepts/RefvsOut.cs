using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    public class RefvsOut
    {

        //ref tells the compiler that the object is initialized before entering the function, while out tells the 
        //compiler that the object will be initialized inside the function.
        //So while ref is two-ways, out is out-only.
        //The ref modifier means that:
        //The value is already set and
        //The method can read and modify it.
        //The out modifier means that:
        //The Value isn't set and can't be read by the method until it is set.
        //The method must set it before returning
        public int Add()
        {
            return 0;
        }

        public static void Main()
        {

        }
    }
}
