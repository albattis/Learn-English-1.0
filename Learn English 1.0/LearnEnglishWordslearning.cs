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
        
        wordsClass word = new wordsClass();
        WordGame game = new WordGame();

        public LearnEnglishWordslearning()
        {
            InitializeComponent();
        }

        private void LearnEnglishWordslearning_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.learnenglishDataSet.words);

        }

        private void WordMix()
        {
            
            word.wordsControl();
            label4.Text = word.word;
            Random r = new Random();
            game.i = r.Next(1, 3);
            if (game.i.Equals(1))
            {
                label1.Text = word.wrongone;
                label2.Text = word.wrongtwo;
                label3.Text = word.answer;
            }
            if (game.i.Equals(2))
            {
                label2.Text = word.wrongone;
                label3.Text = word.wrongtwo;
                label1.Text = word.answer;
            }
            if (game.i.Equals(3))
            {
                label3.Text = word.wrongone;
                label1.Text = word.wrongtwo;
                label2.Text = word.answer;
            }
        }

        private void CheckGame()
        {
            bool eredmeny = false;
            if (game.i.Equals(1) && radioButton3.Checked)
            {
                game.szamlalo++;
                eredmeny = true;
            }
            if (game.i.Equals(2) && radioButton1.Checked)
            {
                game.szamlalo++;
                eredmeny = true;
            }
            if (game.i.Equals(3) && radioButton2.Checked)
            {
                game.szamlalo++;
                eredmeny = true;
            }
            if (eredmeny)
            {
                eredmeny = false;
                label5.BackColor = Color.Green;
            }
            else
            {
                label5.BackColor = Color.Red;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            CheckGame();
            label5.Text = $"Jelenlegi pont: {game.szamlalo}";
            
            if (!word.end)
            {
                WordMix();
            }
            else 
            {
                EndLearnWord endLearnWord = new EndLearnWord();
               
            }
        }
    }
}
