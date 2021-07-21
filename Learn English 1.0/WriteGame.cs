using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_English_1._0
{
    public class WriteGame
    {
        public int i = 0;
        public int szamlalo = 0;

        public bool CheckWriteWord(TextBox textBox,string word)
        {

            if (word.ToLower().Equals(textBox.Text.ToLower()))
            {
                szamlalo++;
                return true;
            }
            return false;
        }
    }
}
