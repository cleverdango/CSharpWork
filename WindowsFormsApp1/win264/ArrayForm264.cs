using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.win264
{
    public partial class ArrayForm264 : Form
    {
        public ArrayForm264()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_n_array_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_find_Click(object sender, EventArgs e)
        {
           
            String[] arrayInputs = tb_input.Text.Split('\n').Select((v)=>v.Trim()).ToArray();
            
            String t = tb_find.Text;
            
            int j = 0;
            foreach (String temp in arrayInputs)
            {
                if (temp.ToString() == t.ToString())
                {
                    
                    lb_find.Text = "数组中的第" + (j+1) + "个元素";
                }
                j++;
            }




        }
        private void tb_input_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt_sort_Click(object sender, EventArgs e)
        {
            String[] arrayInputs = tb_input.Text.Split('\n');
            Array.Sort(arrayInputs);
            for (int i = 0; i < arrayInputs.Length; i++)
            {
                tb_output.Text += (arrayInputs[i] + "\r\n");

            }



        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
