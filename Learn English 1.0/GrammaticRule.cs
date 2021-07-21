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
    public partial class GrammaticRule : Form
    {
        
        public GrammaticRule(int id)
        {
            InitializeComponent();
            Gramatic gram = new Gramatic(id);
            label1.Text = gram.rule_name;
            label4.Text=gram.rule;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add new class
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
