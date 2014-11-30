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

using System;

class Program
{
    // declare constants
    const int CAGES = 500;

    static void Main()
    {
        // declare variables,  these will include all levels of progression of the rabbits and the time frame intervals

        int month = 0;
        int babies = 1;
        int adolescent = 0;
        int adults = 0;
        int total = 0;
        int adultsAndAdolescents = 0;

        // Tell the user about the program
        Console.WriteLine("Name: Franklin Colton Parry");
        Console.WriteLine("Section 601");
        Console.WriteLine("Project #4");
        Console.WriteLine("Date: 2/15/2013");
        Console.WriteLine();
        Console.WriteLine("This program will determine when you will run out of cages.");

        // print the columns that we would like to display
        Console.WriteLine("Month\tAdults\tBabies\tTotal\t");

        // strat a loop, that will calculate the increased rabbits each month until the rabbit total is greater than 500.
        for (month = 1; total < CAGES; month++)
        {
            // Adults are equivalent to the previous intervals adolecents and all previous adults
            adults += adolescent;
            // the number of adolecent or adults that don't reproduce is equivalent to the previous months babies
            adolescent = babies;
            // the number of babies is equal to the previous months adults
            babies = adults;
            // to get the total number of adults, you need to add the exisiting adults and the current adolecents 
            adultsAndAdolescents = adults + adolescent;
            // the total number of rabits are all the rabbit categories added together for that month
            total = adults + adolescent + babies;

            // print the results for each interval
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", month, adultsAndAdolescents, babies, total);
        }
        Console.WriteLine();
        Console.WriteLine();
        // Print the interval that there will be no more cages
        Console.WriteLine("Will run out of cages in month {0}", --month);

        Console.ReadLine();
    }//End Main()
}//End class Program