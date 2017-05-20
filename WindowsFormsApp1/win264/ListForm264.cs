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
    public partial class ListForm264 : Form
    {
        public List<String> list = new List<String>();
        public ListForm264()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textName.Text.Length == 0)
            {
                MessageBox.Show("请先给个名字！");
                return;
            }
            foreach (String str in list)
            {
                if (str == textName.Text)
                {
                    MessageBox.Show("已经有这个人了！");
                    return;
                }
            }
            list.Add(textName.Text);
            textName.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listMembers.Items.Clear();
            foreach (String str in list)
            {
                listMembers.Items.Add(str);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            list.Sort();
            listMembers.Items.Clear();
            foreach (String str in list)
            {
                listMembers.Items.Add(str);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = list.IndexOf(textSearch.Text);
            if (index >= 0)
            {
                MessageBox.Show("找到" + textSearch.Text + "在第" + (index+1).ToString() + "个位置");
            }
            else
            {
                MessageBox.Show("未找到" + textSearch.Text);
            }
        }
    }
}
