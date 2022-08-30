using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    //Change this to public
    public class Translator
    {
        // returns true if its a vowel, false if its a consonant
        public static bool isVowel(char ch)
        {
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool StartswithVowel(string word)
        {
            bool result = isVowel(word[0]);

            return result;
        }
        public static int NumberofCons(string word)
        {
            int index = 0;
            while (index < word.Length && isVowel(word[index])   == false  )
            {
                index++;
            }
                return index;
        }
        public static string PigLatinVowels(string word)
        {
            return word + "yay";
        }
        public static string PigLatinCons(string word)
        {
            int cons = NumberofCons(word);
            string start = word.Substring(0,cons);
            string newword = word + start + "ay";
            newword = newword.Remove(0, cons);
            return newword;
            
        }
        public static string Piglatinize(string word)
        {
            if (StartswithVowel(word))
            {
                return PigLatinVowels(word);
            }
            else
            {
                return PigLatinCons(word);
            }
        }
    }
}
