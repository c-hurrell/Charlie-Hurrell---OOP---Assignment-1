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
            // Moved report to here in order to use the splitter function for better presentation
            Report report = new Report();

            //Create 'Input' object
            Input input = new Input();
            //Get either manually entered text, or text from a file
            int selection = 0;
            string text = "nothing";
            report.splitter("Data Input");
            Console.WriteLine(" Please choose how you wish to enter your text\n");
            while (true)
            {
                try
                {
                    Console.WriteLine(" 1. Manual Entry");
                    Console.WriteLine(" 2. From File\n");
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
                        Console.WriteLine("\n Please input file name: \n");
                        string fileName = Console.ReadLine();
                        text = input.fileTextInput(fileName);
                        break;
                    }
                    catch { Console.WriteLine("\n Error: File not found. Please check file name or file location"); }
                }
            }
            //Create an 'Analyse' object
            Analyse analyse = new Analyse();
            LongWord longWords = new LongWord();
            //Pass the text input to the 'analyseText' method

            //Our analysis is a form of Data Abstraction as it takes the date we want from the
            //text the user gives it reporting it as the count totals of each type we are
            //searching for
            List<int> values = analyse.analyseText(text);

            //Receive a list of integers back
            List<string> longwords = longWords.LongWords(text);

            //Report the results of the analysis
            report.splitter("Results");
            report.count_output(values);

            Console.WriteLine("  Would you like to save a file of the longwords? Y/N\n");
            while (true)
            {
                // Exception handling to handle incorrect inputs for the Y/N option
                try
                {
                    string temp = Console.ReadLine();
                    char option = temp[0];
                    option = Char.ToLower(option);
                    if (option == 'y')
                    {
                        report.splitter("Long words saved");
                        report.longwords_save(longwords);
                        break;
                    }
                    else if (option == 'n') { break; }
                    else Console.WriteLine("\n Error: Invalid option!");
                }
                catch { Console.WriteLine("\n Error: Invalid value entered!"); }
            }
            //TO ADD: Get the frequency of individual letters?
            Frequency frequency = new Frequency();
            Console.WriteLine("\n  Would you like the frequecy of individual letters? Y/N\n");
            while (true)
            {
                // Exception handling to handle incorrect inputs for the Y/N option
                try
                {
                    string temp = Console.ReadLine();
                    char option = temp[0];
                    option = Char.ToLower(option);
                    if (option == 'y')
                    {
                        Dictionary<char, int> char_count = frequency.char_count(text);
                        report.splitter("Letter Count");
                        report.count_output(char_count);
                        break;
                    }
                    else if (option == 'n') { break; }
                    else Console.WriteLine("\n Error: Invalid option!");
                }
                catch { Console.WriteLine("\n Error: Invalid value entered!"); }
            }

            
        }
        
        
    
    }
}
