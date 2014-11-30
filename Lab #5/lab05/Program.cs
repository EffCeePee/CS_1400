// This program is designed to display the addition of two numbers typed in by the user.
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 05
// Date:  1/24/2013


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
        double num1;
        double num2;
        double num3;

        //Gather the first number below 100 from the user
        Console.Write("Please enter the first number below 100 to be added: ");

        // Store the first number 
        num1 = double.Parse(Console.ReadLine());

        // Prompt the user to enter their second number below 100
        Console.Write("Please enter the second number below 100 to be added: ");

        // Get their course and section and store it in the variable course
        num2 = double.Parse(Console.ReadLine());

        // Calculate the sum of the two numbers
        num3 = (num1 + num2);

        // Display the sum of the two two numbers in the proper format.
        Console.WriteLine();
        Console.WriteLine(" {0, 7:f2}", num1);
        Console.WriteLine("+{0, 7:f2}", num2);
        Console.WriteLine("__________");
        Console.WriteLine("={0, 7:f2}", num3);


        Console.WriteLine();
        Console.WriteLine("Press any key to continue ...");

        Console.ReadLine();
    }//End Main()
}//End class Program