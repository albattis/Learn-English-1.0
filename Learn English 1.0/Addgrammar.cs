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
    public partial class Addgrammar : Form
    {
        public Addgrammar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var content=new learnenglishEntities())
            {
                int count=0;
                foreach (var item in content.grammar)
                {
                     count = content.grammar.Count();
                }

                grammar gram = new grammar
                {
                    grammary_id = count,
                    grammatical_rule = textBox2.Text,
                    rule_name = textBox1.Text
                };

                content.grammar.Add(gram);
                content.SaveChanges();


            }
        }
    }
}
