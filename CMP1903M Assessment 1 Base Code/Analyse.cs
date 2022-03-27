using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences [2]
            //2. Number of vowels [0] 
            //3. Number of consonants [1]
            //4. Number of upper case letters [3]
            //5. Number of lower case letters [4]

            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'

            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }
            int length = input.Length;
            LetterType letter = new LetterType();
            for(int i = 0; i<length;i++)
            {
                if (letter.IsVowel(input[i])) { values[0]++; }     // Vowel count   

                if (letter.IsConsonant(input[i])) { values[1]++; } // Consonant count

                if (letter.IsPunctuation(input[i])) { values[2]++; } // Sentence count

                if(Char.IsUpper(input[i])){ values[3]++; } // Uppercase count

                if (Char.IsLower(input[i])) { values[4]++; } // Lowercase count
            }

            return values;
        }
    }
}
