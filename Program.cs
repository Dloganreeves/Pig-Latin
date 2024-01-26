using System;
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to the Pig Latin Translater");




bool repeat = true;
while (repeat)
{
   //Asks user for word
    Console.WriteLine("What word/sentence would you like to translate?");
    string word = Console.ReadLine().ToLower();
    Console.WriteLine(PigLatin(word));
    //asks user if they want to continue
    Console.WriteLine("Do you want to continue? y/n");
    string choice = Console.ReadLine();
    if (choice == "y")
    {
        repeat = true;
    }
    else if (choice == "n")
    {
        repeat = false;
    }
}

static string PigLatin(string word)
    {
        string[] vowels = { "A", "E", "I", "O", "U", "a", "e", "i", "o", "u" };
        //searches fisrt letter in word for vowels
        if (vowels.Contains(word.Substring(0, 1)))
        {
            return word + "way";
        }
        else
        {
        //searches for vowel location 
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word.Substring(i, 1)))
                {
                //splits word at vowl location and adds the letters before hand at the end.   
                return word.Substring(i) + word.Substring(0, i) + "ay";
                }


            }
        }
        return "invalid word";
    }








