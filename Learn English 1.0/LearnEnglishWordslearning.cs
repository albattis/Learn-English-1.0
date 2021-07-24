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
        WordChangeClass words;
        int[] wordid = new int[100];
        int repeatcount = 0;

        

        public LearnEnglishWordslearning(WordChangeClass item)
        {
            words = item;
            InitializeComponent();
            word.talalat = false;
           
                WordMix();
            
        }

       

        private void LearnEnglishWordslearning_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.learnenglishDataSet.words);
            label4.Text = word.word;
        }

        private void WordMixing()
        {
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
        private void WordMix()
        {
            label3.Text = "";
            label1.Text = "";
            label2.Text = "";
            
                if (words.darab != 0)
                {
                while (!word.talalat && !word.end)
                {
                    word.wordsControl(words.szofaj);
                }
                
                    label4.Text =word.word;
                    WordMixing();
                

            }
                else
                { word.end = true;repeatcount = 0;}

                wordid[repeatcount] = word.lastid;
                repeatcount++;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            word.talalat = false;
                    if (game.CheckGame(radioButton1, radioButton2, radioButton3))
                    {
                        label5.BackColor = Color.Green;
                    }
                    else
                    {
                        label5.BackColor = Color.Red;
                    }
                    label5.Text = $"Jelenlegi pont: {game.szamlalo}";
            
            
                WordMix();
            
            words.darab--;
            if (word.end)
            {
                
                    EndLearnWord endLearnWord = new EndLearnWord(game);
                    endLearnWord.Show();
                    this.Close();
                
            }

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            
        }
    }
}
