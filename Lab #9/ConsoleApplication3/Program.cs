// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 02
// Date:  1/14/2012


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

// Sample Program To Illustrate Debugger
// Calculates the gross pay for a Sales
// If a person's sales exceed $40,000 in one month, then their commission will be ten percent 
// of their sales for that month. If their sales is less than $25,000 then their commission
// is three percent of their sales for the month. Otherwise, their commission will be five
// percent of their sales for the month. Their gross pay is equal to a base salary of
// $1,000 each month plus their commission.

using System;

class Program
{
    // declare constants - no magic numbers
    const double BIG = 40000;
    const double SMALL = 25000;
    const double BIG_BONUS = .10;
    const double SMALL_BONUS = .05;
    const double TINY_BONUS = .03;

    static void Main()
    {
        // delcare variables 
        double sales = 0;
        double salary = 1000;
        double commission = 0;
        double pay = 0;

        Console.WriteLine("This program will calculate sales comissions.");

        Console.Write("Please enter the person's Sales: ");

        sales = double.Parse(Console.ReadLine());

        if (sales >= BIG)
            commission = sales * BIG_BONUS;
        if (sales < BIG && sales >= SMALL)
            commission = sales * SMALL_BONUS;
        if (sales < SMALL)
            commission = sales * TINY_BONUS;



        pay = salary + commission;

        Console.WriteLine("This person's gross pay will be {0:C2}", pay);


        Console.WriteLine("Thanks ... goodbye");
        Console.ReadLine();
    }
}