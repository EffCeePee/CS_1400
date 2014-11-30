// This program is designed to display the information typed in by the user.
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 04
// Date:  1/17/2013


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

        // variable declarations
        string name;
        string course;
        int age;
        double value;

        // Here you must supply code that does the following:
        // Prompt the user to enter their full name
        Console.Write("Please enter your full name: ");

        // Get their name and store it in the variable name
        name = Console.ReadLine();

        // Prompt the user to enter their course and section
        Console.Write("Please enter your course and section: ", name);

        // Get their course and section and store it in the variable course
        course = Console.ReadLine();

        // Prompt the user for their age
        Console.Write("Please enter your age: ", name);

        // Get their age and store it in the variable age
        age = int.Parse(Console.ReadLine());

        // Prompt the user for how much money they have
        Console.Write("Please tell me how much money you have: ", name);

        // Get the amount of money and store it in the variable value
        value = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Now display the following. Use format specifiers
        // to control the format of your output:
        //    The person's name. You must display the full name
        Console.WriteLine("Thank you {0},", name);
        Console.WriteLine();

        //    The person's course and section
        Console.WriteLine("You are in course {0}.", course);
        Console.WriteLine();

        //    The person's age
        Console.WriteLine("Your age is {0}.", age);
        Console.WriteLine();

        //    The amount of money the person has. Display the dollar symbol
        //    and two digits after the decimal point.
        Console.WriteLine("You have {0:c2}", value);
        Console.WriteLine();

        Console.WriteLine("Press any key to continue ...");

        Console.ReadLine();
    }//End Main()
}//End class Program