using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    public class Delegate1
    {
        public static void Main()
        {
            List<Employe> emplist = new List<Employe>();
            emplist.Add(new Employe() { ID = 12, Emp_Name = "Suresh", Experience = 6 });
            emplist.Add(new Employe() { ID = 12, Emp_Name = "Venkat", Experience = 5 });
            emplist.Add(new Employe() { ID = 12, Emp_Name = "pawan", Experience = 7 });
            isgethike isget = new isgethike(isgetting);
            //Employe.WillGetHike(emplist, isget);
            // emp => emp.Experience > 5
            Employe.WillGetHike(emplist, emp => emp.Experience > 5);
            Console.ReadLine();
        }

        public static bool isgetting(Employe emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    //Delegates are exspecially used for Framwork developers
    //Classes and Methods should be reusable
    //if ur code is hard coded then ur code can not be reusable
    public delegate bool isgethike(Employe employee);
    public class Employe
    {
        public int ID { get; set; }
        public string Emp_Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void WillGetHike(List<Employe> employee, isgethike isgothike)
        {

            foreach (Employe obj in employee)
            {
                //obj.Experience > 5
                if (isgothike(obj))
                {
                    Console.WriteLine(obj.Emp_Name + " Will Get Hike ");
                }
            }
        }
    }








}
