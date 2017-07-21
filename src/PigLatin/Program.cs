using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {


            do
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!\n");
                Console.WriteLine("Enter a word to be translated: \n");
                NewWord();
                Console.WriteLine("Type yes to continue:  ");

            } while (Console.ReadLine().ToUpper() == "YES");
        }


        //method to translate word
        public static void NewWord()
        {
            string word = Console.ReadLine().ToLower();
            word = CheckifWord(word);// checks if word is a valid entry (not numbers, characters, etc see method below) 
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int index = word.IndexOfAny(vowels);

            //check if word starts with vowel - make if else statement a method
            if ((word.StartsWith("a")) || (word.StartsWith("e")) || (word.StartsWith("i")) || (word.StartsWith("o")) || (word.StartsWith("u")))
            {
                Console.WriteLine(word + "way");
            }


            else //if (index == -1)  
            {
                string removedConsonants = word.Substring(index);
                string con = (word.Substring(0, index));
                Console.WriteLine(removedConsonants + con + "ay\n");


            }
        }

        public static string CheckifWord(string word)
        {


            while (!Regex.IsMatch(word, @"[A-Za-z]+$"))
            {
                Console.WriteLine("Invalid entry: please enter a word:  ");
                word = Console.ReadLine();
            }
            return word;
        }

    }
}
