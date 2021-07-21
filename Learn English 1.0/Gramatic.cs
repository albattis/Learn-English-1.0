using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_English_1._0
{
    public class Gramatic
    {
        public string rule_name;
        public int grammar_id;
        public string rule;


        public Gramatic(int id)
        {
            grammar_id = id;
            using (var content = new learnenglishEntities())
            {
                foreach (var item in content.grammar)
                {
                    if (item.grammary_id.Equals(grammar_id))
                    {
                        rule_name = item.rule_name;
                        rule = item.grammatical_rule;
                    }
                }

            }
        }

       
    }
}
