using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    //Multicast Delegate

    //A multicast delegate is a delegate that has references to more then one function
    //when you invoke a multicast delegate, all the functions the delegate is pointing to , are invoked.
    //there are 2 approaches to create a multicast delegate. Depending on the approach you use
    //+ or += to register a method with the  delegate.
    //- or -=to Un-register a method with the delegate.
    //Note: A multicast delegate , invokes the methods in the invocation list, in the 
    //same order in which they are added.
    //if the delagete has a return type other then void and if the delegate is a multicast delegate,
    //only the value of the last invoked method will be returned . along the same lines , if the delegate has 
    //an out parameter, the value of the output parameter, will be the value assigned by the last method.
    //Where do you use multicast delegates ?
    //Multicast delegate makes implementation of observer design pattern very simple . observer pattern
    //is also called as publish/subscribe pattern.


    public delegate void multidel(out int m);

    public class Delegate2
    {
        static void Method1(out int i)
        {
            i = 1;
        }

        static void Method2(out int j)
        {
            j = 2;
        }


        public static void Main()
        {
            //multidel md1, md2, md3,md4;

            //md1 = new multidel(Method1);
            //md2 = new multidel(Method2);
            //md3 = new multidel(Method3);
            //md4 = md1 + md2 + md3;
            //md4();
            multidel md = new multidel(Method1);
            md += Method2;
            int DelegateIntegervalue = -1;
            md(out DelegateIntegervalue);
            Console.WriteLine("The last method value will be printed in multicast delegate "+DelegateIntegervalue);
            Console.ReadLine();

            //multidel md = new multidel(Method1);
            //md
        }

    }
}
