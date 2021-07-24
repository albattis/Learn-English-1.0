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
    public partial class WritetoWord : Form
    {
        WriteGame game = new WriteGame();
        WordGameController controller = new WordGameController();
        
        public WritetoWord()
        {
            InitializeComponent();
            controller.wordsControl();
            label2.Text = controller.word;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (game.CheckWriteWord(textBox1, controller.answer))
            {
                label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Red;
            }
            label3.Text = $"A Megszerzett pontok: {game.szamlalo}";
            controller.wordsControl();
            label2.Text = controller.word;
            if (controller.end)
            {
                EndLearnWord end = new EndLearnWord(game);
                end.Show();
                this.Close();
            }
            textBox1.Text = "";

        }
    }
}
