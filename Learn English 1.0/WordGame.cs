using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_English_1._0
{
    public class WordGame
    {
        public int i = 0;
        public int szamlalo = 0;
        public bool CheckGame(RadioButton radioButton1,RadioButton radioButton2,RadioButton radioButton3)
        {
            if (i.Equals(1) && radioButton3.Checked)
            {
                szamlalo++;
                return true;
            }
            if (i.Equals(2) && radioButton1.Checked)
            {
                szamlalo++;
                return  true;
            }
            if (i.Equals(3) && radioButton2.Checked)
            {
                szamlalo++;
                return true;
            }
            return false;
        }
    }
}
