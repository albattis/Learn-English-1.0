using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_English_1._0
{
    public class WordGameController
    {
        int wordscount = 0;
        int nowid = 1;
        public string word;
        public string answer;
        public bool end = false;
        public void wordsControl()
        {

            using (var content = new learnenglishEntities())
            {
                wordscount = content.words.Count();
                if (!nowid.Equals(wordscount + 1))
                {
                    foreach (var item in content.words)
                    {
                        if (item != null && item.word_id.Equals(nowid))
                        {
                            word = item.word_hungarian;
                            answer = item.word_english;

                        }
                    }
                    nowid++;
                }
                else { end = true; }
            }
            
        }

    }
}
