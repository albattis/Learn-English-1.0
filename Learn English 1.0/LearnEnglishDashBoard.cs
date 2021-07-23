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
    public partial class LearnEnglishDashBoard : Form
    {
        public LearnEnglishDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LearnEnglishWordslearning words = new LearnEnglishWordslearning();
            words.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewWordAdd add = new NewWordAdd();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WritetoWord wirte = new WritetoWord();
            wirte.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GramaticChange change = new GramaticChange();
            change.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addgrammar gramm = new Addgrammar();
            gramm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GrammarPractice practice = new GrammarPractice();
            practice.Show();
        }
    }
}
