using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    class selfintroduction
    {
        selfintroduction(bool selfintroduction)
        {
            if (selfintroduction)
            {
                Console.Write("Welcomes to Mates");
                Console.Write("I am Sures Mogudala \n");
                Console.Write("Software Developer at Synfosys Business Solutions");
                Console.Write("Leavs at Yousuf guda");
            }
        }
        public static void Main()
        {
            selfintroduction SI = new selfintroduction(true);
        }
    }
}
