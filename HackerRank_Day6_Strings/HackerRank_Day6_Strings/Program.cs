using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
/* Enter your code here. 
* Read input from STDIN. 
* Print output to STDOUT. 
* Your class should be named Solution */

class Solution
{
    static void Main(String[] args)
    {
        int inputInteger;
        int lowerBound = 1;
        int upperBound = 10;
        int lowerLength = 2;
        int upperLength = 10000;

        while (true)
        {
            Console.Write("Enter an integer value between 1 and 10: ");
            string inputValue = Console.ReadLine();
            //If the input value can be parsed from a String to an Integer...
            if (int.TryParse(inputValue, out inputInteger))
            {
                //...and the inputInteger is within the correct range as per the checkWithinRange method...
                if (IsWithinRange(inputInteger, lowerBound, upperBound))
                {
                    break; //...Break out of the loop and carry on with the rest of the code.
                }
                else
                {
                    Console.WriteLine("Invalid input - please enter an integer between 1 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input - please enter something that can be parsed as an Integer.");
            }

        }

        //This code is executed once the break clause is reached.

        Console.WriteLine("Now enter " + inputInteger + " strings. Minimum characters = " + lowerLength + ", maximum characters = " + upperLength + ": ");

        //Declare a Dictionary to store the user-input Strings/dynamically generated variable name pairs.
        //This will be so i can reference them later on to apply the string operations.
        Dictionary<string, string> inputStringVariableNamePairs = new Dictionary<string, string>();
        string[] assign = new string[inputInteger];
        
        //Create a 'for' loop to take in the required amount of strings from the user, validate their length, 
        for (int i = 0; i < inputInteger; i++)
            {
            
            bool isValidInput = false;
            
            while(!isValidInput) { 

                Console.Write("Enter string " + (i + 1) + " : ");
                string inputString = Console.ReadLine();

                if (IsWithinAllowableLength(inputString, 2, 10000))
                {
                    isValidInput = true;
                    string inputStringName = $"inputString_{i}";
                    inputStringVariableNamePairs.Add(inputStringName, inputString);
                //Checking I have the right values
                    Console.WriteLine(inputString + " : " + inputStringVariableNamePairs[$"inputString_{i}"]);

                    //TODO: perform the functions on the strings to complete the exercise. In this for loop or another?
                }
                else
                {
                Console.WriteLine("Invalid input. Please enter a valid string.");
                
                }
            }
        }


        ////Test Block to test successful escape from first while(true) infinite loop construct. Look to change this in future for safety.
        //Console.Write("!Success!!!Testing valid break clause");
        //Console.Write(assign[inputInteger - 1]);


        //This method takes in an integer and checks if it is within a specified range.
        static bool IsWithinRange(int T, int lowerInt, int upperInt)
        {
            return T >= lowerInt && T <= upperInt;
        }

        static bool IsWithinAllowableLength (string S, int lowerInt, int upperInt)
        {
            return S.Length >= lowerInt && S.Length <= upperInt;
        }
    }
}








