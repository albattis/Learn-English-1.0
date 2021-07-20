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
    public partial class NewWordAdd : Form
    {
        public NewWordAdd()
        {
            InitializeComponent();
        }

        private void NewWordAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.wordsType' table. You can move, or remove it, as needed.
            this.wordsTypeTableAdapter.Fill(this.learnenglishDataSet.wordsType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            using (var context = new learnenglishEntities())
            {
                id = context.words.Count() + 1;


                words words = new words
                {
                    word_id = id,
                    word_hungarian = textBox1.Text,
                    word_english = textBox2.Text,
                    word_tpye = (int)comboBox1.SelectedValue
                };

                context.words.Add(words);
                try { context.SaveChanges();
                    MessageBox.Show("Sikeres felvétel", "Új szó felvétele", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                catch (Exception ee) {
                    MessageBox.Show($"Sikertelen felvétel\n {ee.Message}", "Új szó felvétele", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
