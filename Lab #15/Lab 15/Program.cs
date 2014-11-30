// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 15
// Date:  2/28/13


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

class Program
{
    // some  class level constants
    const int HALVES = 50;
    const int QUARTERS = 25;
    const int DIMES = 10;
    const int NICKELS = 5;
    const int PENNIES = 1;

    static void Main()
    {
        int money;  // the value we want to count change for

        Console.WriteLine("I will make change for you.");
        Console.Write("Enter in an amount between 1 and 99: ");
        money = int.Parse(Console.ReadLine());

        Console.WriteLine("For {0} you get:", money);

        Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
        Console.WriteLine("{0} quarters", ComputeChange(ref money, QUARTERS));
        Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
        Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
        Console.WriteLine("{0} pennies\n", ComputeChange(ref money, PENNIES));
        Console.ReadLine();
    }

    // The ComputeChange Method
    // Add your method prologue here
    static int ComputeChange(ref int changeValue, int coinValue)
    {
        // you provide the method to compute change here

        int coins;

        coins = changeValue / coinValue;
        changeValue %= coinValue;
        return coins;
    }
}