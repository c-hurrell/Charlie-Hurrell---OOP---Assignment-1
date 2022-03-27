using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LongWord
{
	public LongWord()
	{
	}
	public List<string> LongWords(string text) // Filters out long words from the text
    {
		text = text.Replace('.', ' ').Replace('?', ' ').Replace(',', ' ').Replace('!',' ');
		List<string> WordList = new List<string>();
		string[] textSplit = text.Split(' ');
		for(int i = 0; i < textSplit.Length; i++)
        {
			if (textSplit[i].Length >= 7) { WordList.Add(textSplit[i]); }
        }
		return WordList;
    }
}
