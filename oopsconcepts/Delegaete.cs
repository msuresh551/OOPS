using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{

public delegate void Helloword(string test);

   public class Delegaete
    {
       public void testDelegate(string test)
       {
           Console.WriteLine("Delegate is "+test );
       }
       //Delegate is Type safe function Pointer
       public static void Main()
       {
           Delegaete DE = new Delegaete();
           
           Helloword hw=new Helloword(DE.testDelegate);
           hw(" Type safe function Pointer");
           Console.ReadLine();
           
       }
    }
}
