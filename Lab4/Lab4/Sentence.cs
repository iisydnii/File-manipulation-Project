/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project: Lab 4
// File Name: Sentence
// Description: Creates a list of sentences for file Removes all punctionation and
// gets a random sentence and Counts the words in a given sentences
// Course: Server Side CSCI 2910-940
// Author: Sydni Ward
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab4
{
    /// <summary>
    /// Creates a list of sentences from a file Removes all punctionation and
    /// gets a random sentence and Counts the words in a given sentences
    /// </summary>
    public class Sentence
    {
        public List<String> sentence;                       //List of orginial sentences from file
        public List<String> sentenceWP;                     //List of manipulated sentences (Without punctionation and Uppercase)
        Random rand = new Random();                         //Declaration of a random object
        int count;                                          //Protected variable for method use for holding counts
        String randOutput;                                  //Holds the random sentence generateds in RandomSentence()

        /// <summary>
        /// Constructor - used for building obects 
        /// </summary>
        public Sentence()
        {
            sentence = new List<String>();                   
            sentenceWP = new List<String>();
        }

        /// <summary>
        /// Creation of a list of sentences from a file
        /// </summary>
        /// <param name= "sentenceInput">String Input from a file</param>
        /// <param name= "flag">flag to trigger end of file response</param>
        public List<String> SentenceList(String sentenceInput, String flag)     //Makes List from file output, flag to trigger end of file response
        {
            if (flag != "X")
            {
                sentence.Add(sentenceInput);                // if no flag a sentence to orginial list
            }
            else
            {                                               // once the flag is thrown 
                count = sentence.Count();                   //Get count of number of sentences
                if (count == 1)
                {
                    Console.WriteLine(sentence[0]);         //IF 1 Print for user
                }
                RemovePunctuation();                        //Call method to start text manipulation 
                RandomSentence();                           //call method to get a random sentence
            }
            return sentence;
        }

        /// <summary>
        /// gets a random sentence for sentence collection and Calls CountWords to count the words in that sentence
        /// </summary>
        public String RandomSentence()
        {
            randOutput = sentence[rand.Next(sentence.Count)];    //Outputs single Random sentence
            CountWords(randOutput);                              //Call CountWords to get word count of random output
            Words word1 = new Words(randOutput.ToUpper());                 ////take random output string and call Words class
            return randOutput;                                   //Random return sentence
        }

        /// <summary>
        /// Takes given string and counts it<
        /// </summary>
        /// <param name= "sentenceInput">Takes given string and counts it</param>
        public int CountWords(String sentenceInput)
        {
            List<String> listStrLineElements;                   //Local list to hold words to later count
            String delimitor = " ";                             //Setting delimiter this is what tells the program where to split the string
            count = 0;                                          // Count is 0 

            listStrLineElements = sentenceInput.Split(delimitor).ToList();      //Takes input of a given string and creates a list of words 
            count = listStrLineElements.Count();                                //Get and set count

            return count;                                                       //return count
        }

        /// <summary>
        /// Removes Punctuation using Regex and Makes sentences Uppercase then adds it to it's own list sentenceWP
        /// </summary>
        public List<String> RemovePunctuation()                                 //Removing Punctuation and creating a list 
        {
            String stripped;
            System.Text.RegularExpressions.Regex TitleRegex = new
            System.Text.RegularExpressions.Regex(@"[^\sa-z0-9]+",               //Get rid of all chars that are not spaces,letter,or numbers
            System.Text.RegularExpressions.RegexOptions.IgnoreCase);            //ingnore casing

            foreach (String se in sentence)                                     //loop through sentence collection
            {
                stripped = TitleRegex.Replace(se, String.Empty);                //replace punctuation with empty string

                stripped = stripped.ToUpper();                                  //Make Uppercase
                sentenceWP.Add(stripped);                                       //Add to sentenceWP collection
            }
            Words word1 = new Words(sentenceWP);                                //take sentenceWP and call Words class
            return sentenceWP;                                                  // return sentenceWP collection
        }
    }
}

