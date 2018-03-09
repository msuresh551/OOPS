using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    public class Enumes
    {
        public static void Main()
        {
            Console.WriteLine("List of Enums");
            Array list = Enum.GetValues(typeof(Months));
            foreach (var item in list)
            {
                Console.WriteLine(item.GetHashCode() + " values are " + item);
            }
            Console.ReadLine();
        }
    }

    public enum Months
    {

        Jan = 1,
        Feb = 2,
        Mar = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12
    }


}
