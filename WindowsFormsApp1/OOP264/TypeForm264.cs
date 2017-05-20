using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Library264;

namespace WindowsFormsApp1.OOP264
{
    public partial class TypeForm264 : Form
    {
        public TypeForm264()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assembly asmb = Assembly.LoadFrom("Library264.dll");
            Type targetEnum = asmb.GetType("Library264." + comboBox1.Text);

            string[] names = Enum.GetNames(targetEnum);
            Array values = Enum.GetValues(targetEnum);

            listBox1.DataSource = values;
            /*int count = 0;
            String[] result = new String[names.Length];
            foreach (int i in values)
            {
                result[count] += i.ToString() + ", ";
                count++;
            }
            count = 0;
            foreach (String name in names)
            {
                result[count] += name;
                count++;
            }

            listBox1.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(result[i]);
            }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TypeForm264_Load(object sender, EventArgs e)
        {
            Assembly asmb = Assembly.LoadFrom("Library264.dll");
            foreach(var info in asmb.GetTypes())
            {
                comboBox1.Items.Add(info.Name);
            }
        }
    }
}
