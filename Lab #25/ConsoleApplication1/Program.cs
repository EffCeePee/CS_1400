// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 25
// Date:  4/16/2013


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

        // declare constants
        const int SIZE = 5;

        // create a new object call numbers type integer
        Integer[] numbers = new Integer[SIZE];


        // start a loop to create the objects stored in the array
        for (int i = 0; i < SIZE; i++)
        {
            numbers[i] = new Integer(i);

        }

        // start a loop to write the integer values
        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("The integer in {0} is {1}",i,numbers[i].GetValue());
        }


        Console.ReadLine();
    }//End Main()
}//End class Program

class Integer
{
    // the data member is just the value of the integer
    private int value;

    // Default Constructor
    // Purpose: Initialize the value of the integer to zero
    // Parameters: none
    // Returns: none
    public Integer()
    {
        value = 0;
    }

    // Parameterized Constructor
    // Purpose: Initialize the value of the integer to the parameter
    // Parameters: an integer
    // Returns: none
    public Integer(int n)
    {
        value = n;
    }

    // GetValue method
    // Purpose: to get the value of the integer object
    // Parameters: None
    // Returns: the value
    public int GetValue()
    {
        return value;
    }
}