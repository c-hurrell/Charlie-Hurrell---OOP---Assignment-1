using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void count_output(List<int> values)
        {
            Console.WriteLine(' '); Console.WriteLine("Values for the counts are: "); Console.WriteLine(' ');
            for(int i = 0; i < values.Count; i++)
            {
                if(i == 0) { Console.WriteLine("Vowels: " + values[i]); }
                else if(i == 1) { Console.WriteLine("Consonants: " + values[i]); }
                else if(i == 2) { Console.WriteLine("Sentences: " + values[i]); }
                else if(i == 3) { Console.WriteLine("Uppercase letters: " + values[i]); }
                else if(i == 4) { Console.WriteLine("Lowercase letters: " + values[i]); }
                else { Console.WriteLine("How did you get here?"); }
            }
            Console.WriteLine(' ');
            Console.WriteLine("Total Characters: " + (values[3] + values[4]));
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
            string longFileName = @"C:\Users\charl\OneDrive\Documents\Semester B Modules\Object Oriented Programming\CMP1903M Assessment 1 Base Code\CMP1903M Assessment 1 Base Code\LongWordsSave.txt";
            if(File.Exists(longFileName))
            {
                using(StreamWriter sw = File.CreateText(longFileName))
                {
                    for(int i = 0; i < longWords.Count;i++)
                    {
                        sw.WriteLine(longWords[i]);
                    }
                }
            }

            
        }

          


    }
}
