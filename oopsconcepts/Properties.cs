using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcepts
{
    /// <summary>
    /// Problems with Public Fields
    /// 1. ID should always be non negative number
    /// 2.name Can not be set to Null
    //3.If Employee name is missing "No Name" should be returned.
    //4.minimum Salary should be read only.
    ///You can not Control the What gets and what returns from the Variable
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Normal public variables, assigning directly to variables.
        /// </summary>
        public int id;
        public string name;
        public int Passmarks = 35;

        private int _id1;

        public int getId()
        {
            return this._id1;
        }
        public void setId(int id)
        {
            if (id < 0)
            {
                throw new Exception(" ID should not be less then 0 ");
            }
            this._id1 = id;
        }
        private string _name1;
        public void setName(string Name)
        {

            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name can not be null");
            }
            this._name1 = Name;
        }

        public string getName()
        {
            //Tornary Operator
            return string.IsNullOrEmpty(this._name1) ? "Name can not be null" : this._name1;
        }

        private int _passmarks=35;
        //then can not set the passmarks so the it should be readonly.
        public int getPassmarks()
        {
            return _passmarks;
        }
    }
    public class DisplaypublicProperties
    {
        public static void Main()
        {
            Employee pp = new Employee();
            //pp.id = -20;
            //pp.name = null;
            //pp.Passmarks = 20;
            //Console.WriteLine("ID ={0}, Name= {1},Passmarks = {2}",pp.id,pp.name,pp.Passmarks);

            pp.setId(120);
            Console.WriteLine("Call Employee Name before assigning to the variable "+pp.getName());
            pp.setName("suresh");
           
            Console.WriteLine(" Employee ID =" + pp.getId());
            Console.WriteLine(" Employee Name =" + pp.getName());
            Console.WriteLine("Employee Minmum salary ="+pp.getPassmarks());
           //Never ever exposed class fields
            Console.ReadKey();

        }
    }


}
 