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
    public partial class GrammarPractice : Form
    {
        public GrammarPractice()
        {
            InitializeComponent();
        }

        private void GrammarPractice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.grammar' table. You can move, or remove it, as needed.
            this.grammarTableAdapter.Fill(this.learnenglishDataSet.grammar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 10)
            {

                GrammaticalRuleControl control = new GrammaticalRuleControl();
                control.mondatok = textBox1.Text.Split('.');
                control.GrammaticalControl((int)comboBox1.SelectedValue);
                EndLearnWord word = new EndLearnWord(control.jegy);
                word.Show();
            }
            else 
            {
                MessageBox.Show("Nem fejtette ki a nyelvtani szabályt", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
