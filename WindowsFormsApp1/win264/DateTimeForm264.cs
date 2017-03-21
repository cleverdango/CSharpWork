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
    public partial class DateTimeForm264 : Form
    {
        public DateTimeForm264()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(tb_year.Text);
                int month = int.Parse(tb_month.Text);
                int day = int.Parse(tb_day.Text);
                DateTime dt = new DateTime(year, month, day);
                lb_week.Text = dt.DayOfWeek.ToString();
            }
            catch
            {
                lb_week.Text = "输入的日期有误";
            }
          
                

                
           
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void calc_span_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(tb_year.Text);
                int month = int.Parse(tb_month.Text);
                int day = int.Parse(tb_day.Text);
                DateTime dt = new DateTime(year, month, day);

                int ts_days = int.Parse(tb_span.Text);
                TimeSpan ts = new TimeSpan(ts_days, 0, 0, 0);
                DateTime ds_new = dt + ts;
                lb_newday.Text = string.Format("{0:D}", ds_new);
            }
            catch
            {
                lb_newday.Text = "日期输入错误";
            }
        }
    }
}
