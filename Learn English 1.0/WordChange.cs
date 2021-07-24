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
    public partial class WordChange : Form
    {
        public WordChange()
        {
            InitializeComponent();
        }

        private void WordChange_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.wordsType' table. You can move, or remove it, as needed.
            this.wordsTypeTableAdapter.Fill(this.learnenglishDataSet.wordsType);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordChangeClass words = new WordChangeClass();
            words.szofaj = (int)comboBox1.SelectedValue;
            
            words.darab = (int)numericUpDown2.Value;
            LearnEnglishWordslearning learn = new LearnEnglishWordslearning(words);
            learn.Show();
        }
    }
}
