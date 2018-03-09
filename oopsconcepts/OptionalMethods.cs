using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace oopsconcepts
{
    class OptionalMethods
    {

        //there are Four ways we make parameters optional

        //Making method parameters optional using optional parameter
        public void arthimatic(int i, int j,[Optional]int[] k)
        {
            Console.WriteLine("testing parametized");
        }
        //making method parameters using params key word
        public void arthmetic(int i,params string [] str)
        {
            Console.WriteLine("this is params method");
        }
        public void arthmetic1(int i, int j = 10)
        {
            Console.WriteLine("this is parametirized methods  j value : "+j);
        }
        public static void Main()
        {
            OptionalMethods om = new OptionalMethods();
            om.arthimatic(10, 20);
            om.arthmetic(10);
            om.arthmetic1(10);
            om.arthmetic1(1, j: 20);
            Console.ReadLine();
        }
    }
}
