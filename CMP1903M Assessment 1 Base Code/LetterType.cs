using System;

public class LetterType
{
	public LetterType()
	{
			
	}

	public bool IsVowel(char c) // This function checks if the inputed character is a vowel
    {
		c = Char.ToLower(c);
		char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
		for(int i = 0; i < vowels.Length; i++)
        {
			if(c == vowels[i]) { return true; }
        }
		return false;
    }
	public bool IsConsonant(char c) // This function checks if the inputed character is a consonant
    {
		c = Char.ToLower(c);
		char[] consonants = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z' };
		for(int i = 0; i < consonants.Length; i++)
        {
			if(c == consonants[i]) { return true; }
        }
		return false ;
	}

	public bool IsPunctuation(char c) // This function checks if the inputed character is a punctuation character at the end of a sentence
    {
		char[] punctuation = { '.', '!', '?' };
		for(int i = 0; i < punctuation.Length;i++)
        {
			if(c == punctuation[i]) { return true; }
        }
		return false;
	}
}
