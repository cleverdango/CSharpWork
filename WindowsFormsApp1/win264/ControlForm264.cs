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
  
    public partial class ControlForm264 : Form
    {
    
        public ControlForm264()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShi.Items.Clear();
            switch (cboSheng.Text)
            {
                case "福建省":
                    cboShi.Items.Add("福州市");
                    cboShi.Items.Add("厦门市");
                    cboShi.Items.Add("三明市");
                    break;
                case "江西省":
                    cboShi.Items.Add("南昌市");
                    cboShi.Items.Add("吉安市");
                    break;
                
               
            }
        }

        private void cboShi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtb_no.Text.Length != 6) throw new Exception();
                if (lb_name.Text.Length == 0) throw new Exception();
                lb_all.Items.Add("学号：");
                lb_all.Items.Add(mtb_no.Text);
                lb_all.Items.Add("姓名：");
                lb_all.Items.Add(tb_name.Text);
                lb_all.Items.Add("生日：");
                lb_all.Items.Add(dtp_birth.Text);
                lb_all.Items.Add("生日：");
                lb_all.Items.Add(dtp_birth.Text);
                lb_all.Items.Add("生日：");
                lb_all.Items.Add(dtp_birth.Text);
                lb_all.Items.Add("生日：");
                lb_all.Items.Add(dtp_birth.Text);
                lb_all.Items.Add("生日：");
                //lb_no.Text + mtb_no 
                //lb_name.Text + tb_name.Text
                //lb_birth.Text + dtp_birth.Text
                //怎么改成遍历所有的数组标签
                //外加label标签只获取前几个字符串
            }
            catch (Exception)
            {
                MessageBox.Show("你输入的学号或姓名错误");
                this.mtb_no.Focus();
            }
         
        }

        private void tb_all_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_all_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
