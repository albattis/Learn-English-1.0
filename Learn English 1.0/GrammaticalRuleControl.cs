using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_English_1._0
{
    public class GrammaticalRuleControl
    {
        string gramaticalrule;
        public string[] mondatok;
        string[] szavak;
        int grammatical_id;
        string[] feltetel;
        int talalat = 0;
        int osszesfeltetel;
        double eredmeny;
        public int jegy;

        public void GrammaticalControl(int id)
        {
            var content = new learnenglishEntities();
            foreach (var item in content.grammar)
            {
                if (item.grammary_id.Equals(id))
                {
                    feltetel = item.condition.Split(',');
                    osszesfeltetel = feltetel.Length;
                    
                    for (int i = 0; i < mondatok.Length; i++)
                    {
                        szavak = mondatok[i].Split(' ');
                        for (int j = 0; j < szavak.Length; j++)
                        {
                            for (int k = 0; k < feltetel.Length; k++)
                            {
                                if (szavak[j].Equals(feltetel[k]))
                                {
                                    talalat++;
                                }
                            }
                        }
                    }

                
                }
            }
            ResultCheck();
        }

        private void ResultCheck()
        {
            //osszesfeltetel az alap
            //szazalekertek az talalat

            eredmeny = (double.Parse(talalat.ToString()) / double.Parse(osszesfeltetel.ToString()))* 100;
            if (eredmeny >= 50 && eredmeny < 60)
            {
                jegy = 2;
            }
            else if (eredmeny >= 60 && eredmeny < 70)
            {
                jegy = 3;
            }
            else if (eredmeny >= 70 && eredmeny < 80)
            {
                jegy = 4;
            }
            else if (eredmeny >= 80)
            {
                jegy = 5;
            }
            else
            {
                jegy = 1;
            }
        }


    }
}
