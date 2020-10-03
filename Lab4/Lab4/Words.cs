/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project: Lab 4
// File Name: Words
// Description: Creates a list of words and keeps count
// Course: Server Side CSCI 2910-940
// Author: Sydni Ward
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    /// <summary>
    /// Creates a list of words and keeps count
    /// </summary>
    public class Words
    {
        List<String> words;                 //collection of words used in sentences
        Dictionary<String, int> wordCount; //collection of words to get word count to keep dictionary of every word used
        Word word2;                         //declare object

        /// <summary>
        /// Constructor Takes in a list of sentences calls ListOfWords
        /// Calls word call using sentences collection
        /// </summary>
        /// <param name= "sentences"> Takes in a list of sentences </param>
        public Words(List<String> sentences) //Takes in a list of sentences, Example of overloading
        {
            wordCount = new Dictionary<string, int>();
            words = new List<string>();
            word2 = new Word();                //initialize object
            foreach (string se in sentences)
            {
                ListOfWords(se);                    //Takes single string and calls ListOfWords method
            }
            word2.AddingUpChars(sentences);         //Calls word call using sentences collection
        }

        /// <summary>
        /// Constructor Takes in a single string sentence calls ListOfWords
        /// Calls word call using sentences collection
        /// </summary>
        /// <param name= "sentences"> Takes in a single string sentence </param>
        public Words(String sentence)               //Example of overloading
        {
            wordCount = new Dictionary<string, int>();
            words = new List<string>();
            word2 = new Word();                     //initialize object
            ListOfWords(sentence);                  //Takes single string and calls ListOfWords method
            word2.AddingUpChars(sentence);
        }

        /// <summary>
        /// Takes in a single string returns list of words of the given string
        /// </summary>
        /// <param name= "input">Takes in a single string</param>
        public List<String> ListOfWords(String input)   //Takes in a single string returns list of words of the given string
        {
            String delimitor = " ";                     //Sets local delimitor as a space 
            words = input.Split(delimitor).ToList();    //splits the string by the local delimitor    
            return words;                               //returns list of word of a given string
        }

        /// <summary>
        /// CountWords - loop through collection of words to get word count to keep dictionary of every word used
        /// </summary>
        public void CountWords()
        {
            int value;                                  //local declaration of value to temporarily hold value from Dictionary
            foreach(String word in words)               //loop through collection of words to get word count
            { 
                if (wordCount.ContainsKey(word))        //if that word is in the dictionary
                {
                    value = wordCount[word];           //get current value
                    wordCount[word] = value + 1;       //update value in dictionary by adding 1
                }
                else
                {
                    wordCount.Add(word, 1);             //adding a new word as key and value as 1
                }    
            }
        }
    }
}
