// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 17
// Date:  3/6/13


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

class Program
{
    // Declare Constants

    const int SIZE = 10;

    static void Main()
    {

        // Declare variables, in this case an array

        int[] newArray = new int[SIZE];
        int count = 0;
        int i = 0;

        // tell the user what the program does
        Console.WriteLine("This program will create an array and add all the numbers together.");

        // Starting a loop to populate the array

        
            for (i = 0; i < SIZE; i++)
            {
            // promt the user for the values
            Console.WriteLine();
            Console.Write("Enter intiger value number {0}: ", i + 1);

            // assign the value to the posiiton in the array
            newArray[i] = int.Parse(Console.ReadLine());
            if (newArray[i] == 0)
            {
                break;
            }
            else 
            {
                count++;
            }
          
            }
        


        // call the method SumArray and display it for the user

        Console.WriteLine();
        Console.WriteLine("The product of the array is: {0}", SumArray(newArray, count));

        Console.ReadLine();

    }  // end main

    // New Method Prologue for the SumArray method
    // Purpose:  to sum the numbers in the array
    // Parameters:  the values in the array passed by reference
    // Returns: int that is the sum of the array
    // The Method Header follows

    static int SumArray(int[] a, int count)
    {

        // declare a local variable
        int product = 1;

        // start a loop to add the numbers in the array
        for (int i = 0; i < count; i++)
        {
            product *= a[i];
        }

        // return a value to pring
        return product;

    }



}//End class Program