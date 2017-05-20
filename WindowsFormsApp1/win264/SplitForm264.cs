using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.win264
{
    public partial class SplitForm264 : Form
    {
        public SplitForm264()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show("请输入数据再点击按钮！");
            }

            string temp = textBoxInput.Text;
          
            int res = 0;
            int start = 0;
            int len = 0;
            while ((res = temp.IndexOf('，', start)) >= 0)
            {
                 len = res - start;//逗号的位置-起始位置
                 textBoxSplitedList.Text += (temp.Substring(start, len) + "\r\n");
                 start = res + 1;
            }
            textBoxSplitedList.Text += temp.Substring(start, temp.Length - start);

        }

        private void textBoxSplitedList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
