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
    public partial class GramaticChange : Form
    {
        public GramaticChange()
        {
            InitializeComponent();
        }

        private void GramaticChange_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnenglishDataSet.grammar' table. You can move, or remove it, as needed.
            this.grammarTableAdapter.Fill(this.learnenglishDataSet.grammar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrammaticRule grammatic = new GrammaticRule((int)comboBox1.SelectedValue);
            grammatic.Show();

        }
    }
}
