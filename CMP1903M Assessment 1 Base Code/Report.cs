using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        // Encapsulation: the user doesnt need to access this alphabet array so I have made it private
        private List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void count_output(List<int> values)
        {
            Console.WriteLine(' '); Console.WriteLine(" Values for the counts are: "); Console.WriteLine(' ');
            for(int i = 0; i < values.Count; i++)
            {
                if(i == 0) { Console.WriteLine("  - Vowels: " + values[i]); }
                else if(i == 1) { Console.WriteLine("  - Consonants: " + values[i]); }
                else if(i == 2) { Console.WriteLine("  - Sentences: " + values[i]); }
                else if(i == 3) { Console.WriteLine("  - Uppercase letters: " + values[i]); }
                else if(i == 4) { Console.WriteLine("  - Lowercase letters: " + values[i]); }
                else { Console.WriteLine("How did you get here?"); } // This is just a notation if the user somehow exceeds the index of the array
            }
            Console.WriteLine("\n  - Total Characters: " + (values[3] + values[4]) + "\n");
        }
        public void longwords_output(List<string> longWords)
        {
            for(int i = 0; i < longWords.Count;i++)
            {
                Console.Write(longWords[i] + " ");
            }
        }
        public void longwords_save(List<string> longWords)
        {
            // This creates a file in the current directory for the user to access
            // (The common save location would be:\Assessment 1 Base Code\bin\Debug\net6.0\LongWordsSave.txt)
            // If the file isnt already present then it will be overwritten
            string fileAddress = Environment.CurrentDirectory + @"\LongWordsSave.txt";

            // Recommended addition by Brandon Grindle to indicate where the file has been saved
            Console.WriteLine(" ~  Your file has been saved at: ");
            Console.WriteLine(" ~  " + fileAddress + "\n");

            using (StreamWriter sw = File.CreateText(fileAddress))
            {
                for (int i = 0; i < longWords.Count; i++)
                {
                    sw.WriteLine(longWords[i]);
                }
            }
        }

        // Created the splitter function just to split out sections to help with user understanding
        // seperates data the program generates in a neater format
        public void splitter(string section) 
        { 
            Console.WriteLine("\n ==== " + section + " ==== \n");
        }

        // This outputs the individual letter count
        public void count_output(Dictionary<char, int> char_count)
        {
            int temp = 0;
            Console.WriteLine(" ~ The individual count for each letter in the text is: ");
            for(int i = 0; i < alphabet.Count;i++)
            {
                if (char_count.ContainsKey(alphabet[i])) { temp = char_count[alphabet[i]]; }
                Console.WriteLine("    - " + Char.ToUpper(alphabet[i]) + " = " + temp);
            }

        }
    }
}
