using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV_01
{
    public class NonRepeatedCharacter:Dictionary<char, int>
    {
        public int GetNonRepeatedCharacter(string str)
        {
           
            for (int i = 0; i < str.Length; i++)
            {
                if (ContainsKey(str[i]))
                {
                    this[str[i]]++;
                }
                else
                {
                    this[str[i]] = 1;
                }
            }

            for (int j = 0; j < str.Length; j++)
            {
                if (this[str[j]] == 1)
                {
                    return j;
                }
                
            }
            return -1;
        }
    }
}
