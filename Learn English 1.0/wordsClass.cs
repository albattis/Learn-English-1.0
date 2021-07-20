using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_English_1._0
{
    public class wordsClass
    {
        public string word;
        public string wrongone;
        public string wrongtwo;
        public string answer;
        int nowid = 1;
        int wrongidone = 0;
        int wrongidtwo = 0;

        public wordsClass()
        {


        }


        public void wordsControl()
        {

            using (var content = new learnenglishEntities())
            {
                foreach (var item in content.words)
                {
                    if (item != null && item.word_id.Equals(nowid))
                    {
                        word = item.word_hungarian;
                        answer = item.word_english;
                        nowid++;
                    }
                }
            }
            wrongIdSelected();
        }

        
        private void wrongIdSelected()
        {
            using (var content = new learnenglishEntities())
            {
                Random r = new Random();
                wrongidone = r.Next(1, content.words.Count());
                wrongidtwo = r.Next(1, content.words.Count());
                foreach (var item in content.words)
                {
                    if (item.word_id.Equals(wrongidone))
                    {
                        wrongone = item.word_english;
                    }
                    if (item.word_id.Equals(wrongidtwo))
                    {
                        wrongtwo = item.word_english;
                    }
                }

            }
        }
    }
}
