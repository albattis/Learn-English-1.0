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
    public partial class LearnEnglishWordslearning : Form
    {
        public LearnEnglishWordslearning()
        {
            InitializeComponent();
        }

        private void LearnEnglishWordslearning_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.learnenglishDataSet.words);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordsClass words = new wordsClass();
            
        }
    }
}
