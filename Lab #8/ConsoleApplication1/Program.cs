// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 08
// Date:  02/5/2013


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

        // declare some constants for saturday and sunday
        const string SAT = "Saturday";
        const string SUN = "Sunday";
        const double FREEZING = 32;

        // declare a variable to hold user's input
        string today;
        int temp;

        // prompt the user to enter a day and get the input
        Console.Write("Please enter a day of the week, e.g. Tuesday: ");
        today = Console.ReadLine();

       // see if it is a work day
        if (today != SAT && today != SUN)
        {
            Console.WriteLine("What is the temperature?");
            temp = int.Parse(Console.ReadLine());

            // if it is above freezing go to work
            if (temp > FREEZING)
                Console.WriteLine("Go to work.");

            // if it is below freezing go to work and dress warmly
            else
                Console.WriteLine("go to work and dress warmly.");
        }
        else Console.WriteLine("Yeah! No Work Today!");

        Console.ReadLine();
    }//End Main()
}//End class Program