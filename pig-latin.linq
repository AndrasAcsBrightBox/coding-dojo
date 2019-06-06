<Query Kind="Program" />

void Main()
{
	PigLatin("hello").Dump();
}

public static string PigLatin(string word)
{
	var vowels = new char[] { 'a', 'e', 'u', 'o', 'i' };
    if (Array.IndexOf(vowels, word[0]) > -1)
        return word + "ay";
    else
    {
        return PigLatin(word.Substring(1) + word[0].ToString());
    }
}


// Define other methods and classes here
