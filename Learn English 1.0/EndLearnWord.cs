using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_English_1._0
{
    public partial class EndLearnWord : Form
    {
        public EndLearnWord(WordGame game)
        {
            InitializeComponent();
            label1.Text = $"Az Őn által szerezett \npontok összege:\n \t\t{game.szamlalo}";
        }

        public EndLearnWord(WriteGame game)
        {
            InitializeComponent();
            label1.Text = $"Az Őn által szerezett \npontok összege:\n \t\t{game.szamlalo}";

        }

        public EndLearnWord(int jegy)
        {
            InitializeComponent();
            label1.Text = $"Az Őn által szerezett \njegy:\n \t\t{jegy}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
