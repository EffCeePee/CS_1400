// CS 1400, Lab #13
// Determining a leap year with a function
// Franklin Colton Parry
// 02/19/2013
// --------------------------------------------

using System;

class Program
{

    static void Main()
    {
        // declare some variables
        int year;
        char decision;

        // main program lop
        do
        {
            // get a year from the user
            Console.Write("Enter in a year (for example, 1923): ");
            year = int.Parse(Console.ReadLine());

            // test it with method and output result
            if (IsLeap(year))
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);

            // get and validate response
            do
            {
                Console.Write("Do another year (y or n): ");
                decision = char.Parse(Console.ReadLine());
            } while (decision != 'y' && decision != 'n');
        } while (decision == 'y');
    }
    

    // The IsLeap method
    // Purpose: Determines if the year given is a leap year
    //               it is a leap year if the year is divisible by 4,
    //               but not divisible by 100 unless it is divisible by 400
    // Parameters: The year, as an integer
    // Returns: A boolean, true if the year is a leap year
    // ------------------------------------------------------------------
    static bool IsLeap(int year)
   {
    // declare local variables
       int yearOne = year;
       int four = 4;
       int oneHundred = 100;
       int remainderOneHundred;
       int remainderFour;
       int fourHundred = 400;
       int remainderFourHundred;
       bool leapYear;

    // determine if the year divided by four has a remainder

           remainderFour = year % four;
           remainderOneHundred = year % oneHundred;
           remainderFourHundred = year % fourHundred;

           if (remainderOneHundred == 0)
           {
               if (remainderFourHundred == 0)
               {
                   leapYear = true;
               }
               else
               {
                   leapYear = false;
               }
           }
           else
           {
               if (remainderFour == 0)
               {
                   leapYear = true;
               }
               else
               {
                   leapYear = false;
               }
           }


    return leapYear;
    }// end IsLeap
}// End class program
    