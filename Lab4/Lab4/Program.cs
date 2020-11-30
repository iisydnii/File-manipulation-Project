/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project: Lab 4
// File Name: Program
// Description: Used as a driver file takes a txt file and reads it and the calls
// the other methods to do text manipulation
// Course: Server Side CSCI 2910-940
// Author: Sydni Ward
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab4
{
    /// <summary>
    /// Used as a driver file takes a txt file and reads it and the calls
    /// the other methods to do text manipulation
    /// </summary>
    class Program
    {
        static readonly string textFile = @"testing.txt";       //Default file.  

        static void Main(string[] args)
        {
            Sentence addingSent = new Sentence();               //Creating a intance of Sentence

            if (File.Exists(textFile))
            {
                // Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(textFile))
                {
                    string line;
                    
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line != "")                        //DO NOT ADD EMPTY LINE 
                        {
                            addingSent.SentenceList(line, " "); //Call method SentenceList inside the Class Sentence
                        }                                       //Using line and flag not present
                    }                                       
                    file.Close();                           //Closing file
                    addingSent.SentenceList("", "X");      //Throw flag to trigger end of file respone
                }
            }
        }
    }
}