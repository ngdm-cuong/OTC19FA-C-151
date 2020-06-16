using System;
using System.Collections.Generic;
using System.Text;

namespace _6PigLatin
{
    class PigLatin
    {
        //private static string[] vowel = new string[] { "a", "e", "i", "o", "u", "y" };
        private static string vowel = "aeiouyAEIOUY";

        public static string Latin(string input)
        {

            int  popPosition=0;
            string  temp;
            string output;
            // Find the first position

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < vowel.Length; k++)
                {
                    if (input[0] == vowel[5] || input[0] == vowel[11])
                    {
                        popPosition = i+1;
                        i = 99;
                        break;
                    }
                    if (input[i] == vowel[k])
                    {
                        popPosition = i;
                        i = 99;
                        break;
                        
                    }
                }
                
            }
            temp = input.Substring(0, popPosition);
            input = input.Remove(0, popPosition);

            if (popPosition == 0) // The word starts vowel
                output = input +"way";
            else
                output = input + temp + "ay";

            return output;
        }//End of platin

        public static string [] Chopping (string input)
        {
            int popPosition = 0;
            // Define the number of words 
            string space = " ";
            int numOfWords =0;
            for (int i =0; i<input.Length; i++)
            {
                if (input[i] == space[0])
                numOfWords++; 
            }
            numOfWords++; // For the last word of the sentence because there is no space after that 
            string[] words = new string[numOfWords];
            string[] EncryptWord = new string[numOfWords];

            // Trying to save word to array
            //int n = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == space[0])
            //    {
            //        words[n] = input.Substring(popPosition, i - popPosition);
            //        popPosition = i+1;
            //        n++;
            //        if (i == input.Length - 1)
            //        {
            //            words[n] = input.Substring(popPosition, i - popPosition+1);
            //            n++;
            //        }
            //    }
            //}

            words = input.Split(' ');

            // Save stranslated word in another array to print out
            for (int i = 0 ; i < EncryptWord.Length; i++)
            {
                EncryptWord[i] = Latin(words[i]);
                Console.Write("{0} ", EncryptWord[i]);
            }
            

            return EncryptWord;
        }

    }//End of class
}//End of namespace
