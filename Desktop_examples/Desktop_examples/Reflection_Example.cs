using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Desktop_examples
{
    public partial class Reflection_Example : Form
    {
        public Reflection_Example()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            listBox3.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Clear();


            string s = textBox1.Text;
            Type t = Type.GetType(s);
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                listBox1.Items.Add(m.Name);
            }
            PropertyInfo[] pi=t.GetProperties();
            foreach (PropertyInfo p in pi)
            {
                listBox2.Items.Add(p.Name);
            }
            ConstructorInfo[] ci = t.GetConstructors();
            foreach (ConstructorInfo c in ci)
            {
                listBox3.Items.Add(c.ToString());
            }
        }
    }
}
