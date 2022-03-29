using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine(" To end your input please enter * at the end.");
            Console.WriteLine(" Please input your text sentence by sentence: ");
            while(true)
            { 
                text += Console.ReadLine();
                if(text[text.Length-1] == '*') 
                {
                    text = format(text.Remove(text.Length-1));
                    // This if statment ensures the the end of the text is always a fullstop and won't be a comma
                    if (text[text.Length -1] == ',') { text = text.Remove(text.Length-1) + '.'; }

                    break; 
                }
                // Created this method to insure when a user inputs their text it is corrected to be in the right format of ending in a fullstop
                // to count it as a sentence still
                text = format(text);
                text += ' ';
            }
            Console.WriteLine(text);
            
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            //This trim allows the user to copy and paste file paths into the program
            fileName = fileName.Trim('"');
            text = System.IO.File.ReadAllText(fileName);
            Console.WriteLine("\n" + " File found!" + "\n");
            Console.WriteLine(text + "\n");
            return text;
        }

        // This format method was added to deal with repeating code I had as it just makes the text the correct format
        // for analysis
        public string format(string text)
        {
            // This while loop ensures the line ends as either a sentence or is split by a comma
            while (text[text.Length - 1] != '.' && text[text.Length - 1] != '!' && text[text.Length - 1] != '?' && text[text.Length-1] != ',')
            {
                // Checks if the ending character is a text or digit then end the sentence
                if (Char.IsLetterOrDigit(text[text.Length - 1])) { text += '.'; }
                else { text = text.Remove(text.Length - 1, 1); }
            }
            string temp = text;
            return temp;
        }

    }
}
