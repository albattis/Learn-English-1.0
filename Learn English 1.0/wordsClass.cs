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
        int wordscount = 0;
        public bool end = false;

        public wordsClass()
        {


        }


        public void wordsControl()
        {

            using (var content = new learnenglishEntities())
            {
                wordscount = content.words.Count();
                if (!nowid.Equals(wordscount+1))
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
            wrongIdSelected();
        }

        private void RandomGenerate()
        {

            Random r = new Random();
            wrongidone = r.Next(1, wordscount);
            wrongidtwo = r.Next(1, wordscount);
            while (wrongidone.Equals(wrongidtwo)||wrongidone.Equals(nowid-1)||wrongidtwo.Equals(nowid-1))
            {
                wrongidone = r.Next(1, wordscount);
                wrongidtwo = r.Next(1, wordscount);
            }
        }
        private void wrongIdSelected()
        {
            using (var content = new learnenglishEntities())
            {
                RandomGenerate();
                
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
