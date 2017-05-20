using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Library264;

namespace WindowsFormsApp1.OOP264
{
    public partial class DeckForm264 : Form
    {
        private Deck264 deck = new Deck264();
        public DeckForm264()
        {
            InitializeComponent();
        }

        private void darkForm355_Load(object sender, EventArgs e)
        {

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            deck.ShuffleDeck();
            textBox1.Text = deck.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
