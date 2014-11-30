// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project #7
// Date:  3/20/2013

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

class Program
{
    // declare constants
    const int TEN = 10;

    static void Main()
    {

        // declare variables 

        string userInput;
        string bowlNames;
        int bowlscore;
        string[] parsedInput = new string[TEN];
        string[] names = new string[TEN];
        int[] scores = new int[TEN];
        int count = 0;
        double average = 0;
        int perfect = 300;



        // Tell the user to enter in the bowling names and scores
        Console.WriteLine("Colton's awesome bowling team:");
        Console.WriteLine("Enter in a name and score for each preson on the team");
        Console.WriteLine("For example, 'Mary 143'.  Just hit Enter when you are done.");
        Console.WriteLine();

        // Start a loop that will gather the data
        for (int i = 0; i < TEN; i++)
        {
            Console.Write("Enter in a name and score: ");
            // store the data in a local variable userInput
            userInput = Console.ReadLine();

            // Break the loop when the user presses enter with no value
            if (userInput == "")
            {
                break;
            }
            else
            {
                // split the user input into two parts
                parsedInput = userInput.Split();
                // put the first part in bowler names variable
                bowlNames = parsedInput[0];
                // put the second part into the bower score variable
                bowlscore = int.Parse(parsedInput[1]);
                // put the name into index  an array called names
                names[i] = bowlNames;
                // put the score into a related index of an array called scores
                scores[i] = bowlscore;
                // add a counter for the number of intervals
                count++;
            }
        }
        Console.WriteLine("------------------------Input Complete-----------------------");

        // start a loop to put the scores in the right order
        // outer loop variable is j
        for (int j = 0; j < count; j++)
        {
            // nested loop value is i
            for (int i = 0; i < count; i++)
            {
                if (scores[i] < scores[i + 1])
                {
                    Swap(ref scores[i], ref scores[i + 1]);
                    Swap(ref names[i], ref names[i + 1]);
                }
            }
        }


        //  start a loop to print out the scores
        Console.WriteLine("Here are the scores for this game from highest to lowest");

        for (int i = 0; i < count; i++)
        {
            // astrix condition
            if (scores[i] == perfect)
            {
                Console.WriteLine("{0}\t{1}*\t", names[i], scores[i]);
            }
            // regular scores
            else
            {

                Console.WriteLine("{0}\t{1}\t", names[i], scores[i]);
            }
        }




        // start a loop Calculate the average of scores

        for (int i = 0; i < count; i++)
        {
            average += scores[i];
        }

        average /= count;

        // print the results
        Console.WriteLine();
        Console.WriteLine("The team average for this game was {0:f2}", average);

        Console.ReadLine();
    }//End Main()

    // Method Prologue for the Swap Method
    // Purpose: To use in a sort from highest to lowest
    // Parameters:  Two passed by reference
    // Returns: Void, all parameters are passed by reference
    // The method header follows
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }


    // Method Prologue for the Swap Method
    // Purpose: To use in a sort from highest to lowest
    // Parameters:  Two passed by reference
    // Returns: Void, all parameters are passed by reference
    // The method header follows
    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }



}//End class Program
