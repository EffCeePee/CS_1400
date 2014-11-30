// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 10
// Date:  02/12/13


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

class Program
{

    //Declare Constants that will be used as the limits for the dice

    const int DICEMIN = 1;
    const int DICEMAX = 6;


    static void Main()
    {

        // Declare variables for numbers generated from the random number generator

        int diceOne = 0;
        int diceTwo = 0;
        string rollDice;

        // Create a random number generator object

        Random randomNums = new Random();

        // Tell the user what the program does

        Console.WriteLine("This program will tell you the values of two rolled dice.");

        // Ask the user if the want to roll the dice and store the answer in a variable

        Console.WriteLine("Do you want to roll the dice (y/n)?");
        rollDice = Console.ReadLine().ToLower();


        // create a loop that validates if the input was valid or not
        while (rollDice != "y" && rollDice != "n")
        {

            // If it is invalid input display a warning message and move to ask for data again
            Console.Write("I'm sorry, can you you tell me if you want to roll the dice (y/n)?");
            rollDice = Console.ReadLine().ToLower();
        }

        // If the data is valid and yes Generate two random numbers and store them in the variables
        // Begin a loop to start over if the user wants to roll the dice again when finished
        if (rollDice != "n")
        {
            do
            {
                // create two random numbers and store them as variables  
                diceOne = (randomNums.Next(6) + 1);
                diceTwo = (randomNums.Next(6) + 1);

                // Create an conditional statement to display "you rolled boxcars" if the numbers are 6 and 6
                if (diceOne == DICEMAX && diceTwo == DICEMAX)
                    Console.WriteLine("You rolled boxcars!");

            // Else if they rolled 1 and 1 display "you rolled snake eyes"
                else if (diceOne == DICEMIN && diceTwo == DICEMIN)
                    Console.WriteLine("You rolled snake-eyes!");

            // Else display the two numbers generated. 
                else
                    Console.WriteLine("you rolled {0} and {1}", diceOne, diceTwo);

                // ask if the user wants to return to the beginning to ask if they would like to roll the dice again. store response as a variable
                Console.WriteLine();
                Console.WriteLine("Do you want to roll the dice again? (y/n)");
                rollDice = Console.ReadLine().ToLower();

                // create a loop to validate the user input
                while (rollDice != "y" && rollDice != "n")
                {

                    // If it is invalid input display a warning message and move to ask for data again
                    Console.Write("I'm sorry, can you you tell me if you want to roll the dice (y/n)?");
                    rollDice = Console.ReadLine().ToLower();
                }


            } while (rollDice == "y");
        }

        // If the data is valid and no print a goodbye message and quit
        Console.WriteLine("No problem! Have a nice day");


        Console.ReadLine();
    }//End Main()
}//End class Program