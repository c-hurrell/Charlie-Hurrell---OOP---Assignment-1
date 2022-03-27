//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            Input input = new Input();
            //Get either manually entered text, or text from a file
            int selection = 0;
            string text = "nothing";
            Console.WriteLine("Please choose how you wish to enter your text");
            while (true)
            {
                try
                {
                    Console.WriteLine("1.Manual Entry");
                    Console.WriteLine("2.From File");
                    selection = Convert.ToInt32(Console.ReadLine());
                    if (selection != 1 && selection != 2) { throw new Exception(); }
                    break;
                }
                catch { Console.WriteLine("Incorrect Input! Invalid option or invalid entry!"); }
            }
            if (selection == 1)
            {
                text = input.manualTextInput();
            }
            if (selection == 2)
            {
                while (true)
                {
                //Exception Handling: If the user enters a file name or string which doesn't correspond to a file the code will loop
                //until they enter a valid file address
                    try
                    {
                        Console.WriteLine("Please input file name: ");
                        string fileName = Console.ReadLine();
                        text = input.fileTextInput(fileName);
                        break;
                    }
                    catch { Console.WriteLine("Error: File not found. Please check file name or file location"); }
                }
            }
            //Create an 'Analyse' object
            Analyse analyse = new Analyse();
            LongWord longWords = new LongWord();
            //Pass the text input to the 'analyseText' method

            //Our analysis is a form of Data Abstraction as it takes the date we want from the
            //text the user gives it reporting it as the count totals of each type we are
            //s
            List<int> values = analyse.analyseText(text);
            //for(int i = 0;i < 5; i++) { Console.WriteLine(values[i]); }
            //Receive a list of integers back
            List<string> longwords = longWords.LongWords(text);
            //Console.WriteLine(longwords.Count);
            //Report the results of the analysis
            Report report = new Report();
            report.count_output(values);
            report.longwords_save(longwords);
            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
