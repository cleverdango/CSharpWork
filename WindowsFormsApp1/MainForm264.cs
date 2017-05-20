using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.OOP264;

namespace WindowsFormsApp1.win264
{
    public partial class MainForm264 : Form
    {
        public MainForm264()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimeForm264 form =  new DateTimeForm264();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayForm264 form = new ArrayForm264();
            form.Show();
        }

        private void Exper4_Click(object sender, EventArgs e)
        {
            SplitForm264 form = new SplitForm264();
            form.Show();
        }

        private void Exper5_Click(object sender, EventArgs e)
        {
            ListForm264 form = new ListForm264();
            form.Show();
        }

        private void Exper8_Click(object sender, EventArgs e)
        {
            TypeForm264 form = new TypeForm264();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeckForm264 form = new DeckForm264();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ComplexForm264 form = new ComplexForm264();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigNumForm264 form = new BigNumForm264();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlForm264 form = new ControlForm264();
            form.Show();
        }
    }
}
