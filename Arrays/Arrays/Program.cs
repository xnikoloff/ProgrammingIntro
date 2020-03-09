using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fill an array with all letters of the english alphabet. 
            // Wait for the user to input a werd
            // and show each index of the letters used in the word
            
            Console.Write("Word: ");
            string word = Console.ReadLine();

            char start = 'a';
            char[] arr = new char[26];

            int[] arrIndex = new int[word.Length];

            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = start;
                start++;
            }

            char[] letters = new char[word.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = word[i];
            }

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (letters[i] == arr[j])
                    {
                        arrIndex[i] = j;
                    }
                }
            }

            Console.WriteLine("Word: " + word);

            for (int i = 0; i < arrIndex.Length; i++)
            {
                Console.WriteLine("Index: [{0}]", arrIndex[i]);
            }
        }
    }
}
