using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    class List_Collections
    {
        public static void Main()
        {
            Customer_list cl1 = new Customer_list { Name = "suresh", ID = 1, Salary = 10000 };
            Customer_list cl2 = new Customer_list { Name = "mahesh", ID = 2, Salary = 20000 };
            Customer_list cl3 = new Customer_list { Name = "sandeep", ID = 3, Salary = 30000 };
            Customer_list cl4 = new Customer_list { Name = "pradeep", ID = 4, Salary = 40000 };
            //gives error index was out side of array 
            Customer_list[] cla = new Customer_list[2];
            cla[0] = cl1;
            cla[1] = cl2;
            // cla[2] = cl3;

            List<Customer_list> cll = new List<Customer_list>();
            cll.Add(cl1);
            cll.Add(cl2);
            cll.Add(cl3);
            cll.Add(cl4);
            cll.Insert(0, cl4);

            foreach (Customer_list item in cll)
            {
                Console.WriteLine("customer ID:{0}, Name:{1},Salary:{2}", item.ID, item.Name, item.Salary);
            }

            Console.WriteLine("index of class  "+cll.IndexOf(cl4,1,4));

            //for (int i = 0; i < cll.Count; i++)
            //{
            //    Customer_list cll1 = cll[i];
            //    Console.WriteLine("customer ID:{0}, Name:{1},Salary:{2}", cll1.ID, cll1.Name, cll1.Salary);
            //}



            //Console.WriteLine(""+cl.Name);


            Console.ReadLine();
        }
    }

    class Customer_list
    {
        //even object initializer also constructor will be called.
        public Customer_list()
        {
            //            Console.WriteLine("this is constructor method");
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
    }
}
