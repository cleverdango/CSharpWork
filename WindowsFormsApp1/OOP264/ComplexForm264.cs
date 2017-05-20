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
    public partial class ComplexForm264 : Form
    {
        public ComplexForm264()
        {
            InitializeComponent();
        }

        private void tb_cmnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            ComplexNumber264 a = ComplexNumber264.Parse(tb_cmnum1.Text);
            ComplexNumber264 b = ComplexNumber264.Parse(tb_cmnum2.Text);
            ComplexNumber264 c = a + b;
            lb_output.Text = c.ToString();
        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            ComplexNumber264 a = ComplexNumber264.Parse(tb_cmnum1.Text);
            ComplexNumber264 b = ComplexNumber264.Parse(tb_cmnum2.Text);
            bool c = a == b;
            lb_output.Text = c.ToString();
        }

        private void bt_less_Click(object sender, EventArgs e)
        {
            ComplexNumber264 a = ComplexNumber264.Parse(tb_cmnum1.Text);
            ComplexNumber264 b = ComplexNumber264.Parse(tb_cmnum2.Text);
            bool c = a < b;
            lb_output.Text = c.ToString();
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            ComplexNumber264 a = ComplexNumber264.Parse(tb_cmnum1.Text);
            ComplexNumber264 b = ComplexNumber264.Parse(tb_cmnum2.Text);
            ComplexNumber264 c = a - b;
            lb_output.Text = c.ToString();
        }

        private void bt_noequal_Click(object sender, EventArgs e)
        {
            ComplexNumber264 a = ComplexNumber264.Parse(tb_cmnum1.Text);
            ComplexNumber264 b = ComplexNumber264.Parse(tb_cmnum2.Text);
            bool c = a != b;
            lb_output.Text = c.ToString();
        }

        private void bt_more_Click(object sender, EventArgs e)
        {
            ComplexNumber264 a = ComplexNumber264.Parse(tb_cmnum1.Text);
            ComplexNumber264 b = ComplexNumber264.Parse(tb_cmnum2.Text);
            bool c = a > b;
            lb_output.Text = c.ToString();
        }
    }
}
