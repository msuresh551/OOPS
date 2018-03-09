using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    class Dictionary
    {
        public static void Main()
        {
            Customer_dictionary cd = new Customer_dictionary() { Name = "suresh", ID = 10, Salary = 16000 };
            Customer_dictionary cd1 = new Customer_dictionary() { Name = "Mahesh", ID = 11, Salary = 17000 };
            Customer_dictionary cd2 = new Customer_dictionary() { Name = "Sandeep", ID = 12, Salary = 18000 };
            Customer_dictionary cd3 = new Customer_dictionary() { Name = "Pradeep", ID = 13, Salary = 19000 };

            Dictionary<int, Customer_dictionary> Dictt = new Dictionary<int, Customer_dictionary>();
            Dictt.Add(cd.ID, cd);

            Dictt.Add(cd1.ID, cd1);

            //Check whether key exists or not
            if (!Dictt.ContainsKey(cd2.ID))
            {
                Dictt.Add(cd2.ID, cd2);
            }
            Dictt.Add(cd3.ID, cd3);

            //Check whether key exists or not
            if (Dictt.ContainsKey(100))
            {
                Customer_dictionary cds = Dictt[100];
            }
            foreach (KeyValuePair<int, Customer_dictionary> kv in Dictt)
            {

                Console.WriteLine("Key {0} ", kv.Key);
                Customer_dictionary cu = kv.Value;
                {
                    Console.WriteLine("Customer ID {0},Customer Name {1},Customer salary={2}", cu.ID, cu.Name, cu.Salary);
                }

            }
            Console.WriteLine("----------------------------------------");
            //var is a implicit typed variable
            foreach (var kv in Dictt)
            {

                Console.WriteLine("Key {0} ", kv.Key);
                Customer_dictionary cu = kv.Value;
                {
                    Console.WriteLine("Customer ID {0},Customer Name {1},Customer salary={2}", cu.ID, cu.Name, cu.Salary);
                }
            }
            //TryGetvalue()
            //Count()
            Console.WriteLine("-----------Trygetvalue--------------\n");
            Customer_dictionary cdt;
            //gets the value with associated key
            if (Dictt.TryGetValue(10, out cdt))
            {
                Console.WriteLine("customer  name:{0},ID:{1},salary:{2}",cdt.Name,cdt.ID,cdt.Salary);
            }
            else
            {
                Console.WriteLine(  "Key is not found");
            }
            Console.WriteLine("------Count number of values in Dictionary----------");

            Console.WriteLine(  "Total number of customers {0}",Dictt.Count);
            Console.WriteLine("Total number of customers {0}", Dictt.Count());
            //using LINQ Extension methods with Dictionary
            Console.WriteLine("Total number of customers sal greater then 12000: {0}",Dictt.Count(em=>em.Value.Salary>16000));
            Console.WriteLine("-----------Class array converting to Dictionary-------\n");

            Customer_dictionary[] cud = new Customer_dictionary[3];
            cud[0] = cd1;
            cud[1] = cd2;
            cud[2] = cd3;
            Dictionary<int,Customer_dictionary> dic= cud.ToDictionary(custome => custome.ID, cust => cust);
            foreach (KeyValuePair<int,Customer_dictionary> cdarray in dic)
            {
                Console.WriteLine(" Key value: {0}",cdarray.Key);
                Customer_dictionary cds1 = cdarray.Value;

                Console.WriteLine("ID: {0},Name :{1}, Salary :{2}", cds1.ID, cds1.Name, cds1.Salary);
                
            }
            //Array to Dictionary

            Console.WriteLine("------LIst Dictionary------\n");
            List<Customer_dictionary> Listcust = new List<Customer_dictionary>();
            Listcust.Add(cd1);
            Listcust.Add(cd2);
            Listcust.Add(cd3);
            Dictionary<int, Customer_dictionary> diclist = Listcust.ToDictionary(custome => custome.ID, cust => cust);
            foreach (KeyValuePair<int, Customer_dictionary> cdarray in dic)
            {
                Console.WriteLine(" Key value: {0}", cdarray.Key);
                Customer_dictionary cds1 = cdarray.Value;

                Console.WriteLine("ID: {0},Name :{1}, Salary :{2}", cds1.ID, cds1.Name, cds1.Salary);

            }
            

            Dictt.Remove(11);
            Dictt.Clear();


            Console.ReadLine();
        }
    }
    class Customer_dictionary
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
    }
}
