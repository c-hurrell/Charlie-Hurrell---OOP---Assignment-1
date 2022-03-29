using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Frequency
    {
        public Frequency()
        {
        }
        // This method was recommended by both my reviews to be added and have added as so
        // This method counts the frequency of individual letters
        public Dictionary<char, int> char_count(string text)
        {
            Dictionary<char, int> letter_count = new Dictionary<char, int>();
            for(int i = 0; i < text.Length - 1;i++)
            {
                char key = Char.ToLower(text[i]);
                if (!letter_count.ContainsKey(key)) { letter_count.Add(key, 1); }
                else { letter_count[key]++;}
            }
            return letter_count;
        }
        

    }

}
