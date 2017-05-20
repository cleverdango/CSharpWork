using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library264;

namespace WindowsFormsApp1.OOP264
{
    public partial class BigNumForm264 : Form
    {
        public BigNumForm264()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            { 
            decimal initnum = decimal.Parse(textBox1.Text);
            BigNum264 bignum = new BigNum264(initnum);
            label1.ForeColor = bignum.Color;
            label1.Text = bignum.ToString();
            }
            catch
            {
                label1.Text = "你输入的数据有误";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
