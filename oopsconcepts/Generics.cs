using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    class Generics
    {


        
        
        public static void Main()
        {
            //    Arthmetic.Equal("s", 10);
            //    bool a=  Arthmetic.Equal<int>(20,10);
            bool a = Arthmetic<int>.Equal(20, 10);
            Console.WriteLine(a);


            Console.ReadLine();



        }


        

    }
    public class Arthmetic<T>
    {




        //public static bool Equal(string s, string m)
        //{
        //    return s == m;
        //}
        public override string ToString()
        {
            return base.ToString();
        }

        public static bool Equal(T i, T j)
        {
            return i.Equals(j);
        }

    }

}
