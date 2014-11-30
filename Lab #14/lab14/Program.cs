// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 14
// Date: 2/26/13

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

class Program
{
    static void Main()
    {
        // declare some variables to test the program
        int number1 = 10;
        int number2 = 15;

        // call the Swap method and output the result
        Swap(ref number1, ref number2);
        Console.WriteLine("number1 = {0}", number1);
        Console.WriteLine("number2 = {0}", number2);

        Console.ReadLine();
    }

    // The Swap method
    // Purpose: To interchange the value of two variables
    // Parameters: two integers
    // Returns: None
    // Pre-conditions: None
    // Post-conditions: None
    // Side Effect: the values of the 2 integers are swapped

    static void Swap(ref int n1, ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2 = temp;

    }
}// end class program


// Passing by reference works better in this case because we need two way communication after the Swap method has run. 
// When we pass by value, we have to have a return value, and cannont pass both numbers back to the main method.
// The other reason that the pass by value method does not work is because the local variables in Swap are discarded and not 
// assigned back to the main method. Passing by reference allows us to return these values back to the main method.  