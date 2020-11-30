/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project: Lab 4
// File Name: Word
// Description: Keeps a dictionary of character count
// Course: Server Side CSCI 2910-940
// Author: Sydni Ward
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    /// <summary>
    /// Keeps a dictionary of character count
    /// </summary>
    public class Word
    {
        Dictionary<char, int> charCount;                        //HOLDS ALL default characters plus added characters if needed
        List<char> chars = new List<char>();
        char[] characters;

        /// <summary>
        /// Word Constructor builds object with default dictionary characters
        /// </summary>
        public Word()
        {
            charCount = new Dictionary<char, int>()                 //defining default dictionary characters
            {{'A', 0 }, {'B', 0 }, {'C', 0 }, {'D', 0 }, {'E', 0 },
            {'F', 0 }, {'G', 0 }, {'H', 0 }, {'I', 0 }, {'J', 0 },
            {'K', 0 }, {'L', 0 }, {'M', 0 }, {'N', 0 }, {'O', 0 },
            {'P', 0 }, {'Q', 0 }, {'R', 0 }, {'S', 0 }, {'T', 0 },
            {'U', 0 }, {'V', 0 }, {'W', 0 }, {'X', 0 }, {'Y', 0 },
            {'Z', 0 }, {'0', 0 }, {'1', 0 }, {'2', 0 }, {'3', 0 },
            {'4', 0 }, {'5', 0 }, {'6', 0 }, {'7', 0 }, {'8', 0 },
            {'9', 0 },
            };
        }

        /// <summary>
        /// Adds up characters from a given string adding character count to dictionary
        /// </summary>
        /// <param name= "input">Takes single string</param>
        public void AddingUpChars(String input)                 //Takes single string
        {
            characters = input.ToCharArray();                   //turns string into characters

            foreach(char c in characters)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c] = charCount[c]  + 1;           //counts chars
                }
                else
                {
                    charCount.Add(c, 1);                        //adding new chars if needed
                }
            }
        }

        /// <summary>
        /// Adds up characters from a list of strings adding character count to dictionary
        /// </summary>
        /// <param name= "input">Takes list of strings</param>
        public void AddingUpChars(List<String> input)
        {
            
            foreach (String sentence in input)
            {
                chars.AddRange(sentence);               //Turn all strings into a list of charactors
            }

            foreach (char c in chars)               // loop through list of charactors
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c] = charCount[c] + 1;        //counts chars
                }
                else
                {
                    charCount.Add(c, 1);                    //adding new chars if needed
                }
            }
        }

    }
}
