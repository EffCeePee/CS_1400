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


    static void Main()
{

// Assignment Header
Console.WriteLine("Franklin Colton Parry");
Console.WriteLine("CS 1400 Section 601");
Console.WriteLine("Date: 3/1/2013");
Console.WriteLine("Project #5");
Console.WriteLine("______________________________");

// Declare local variables

double xValue = 0;
double yValue = 0;
double theta = 0;
double hypotenuse = 0;
string repeat = "no";


// starting a loop to run the program as long as the user wants to.
do
{
    // Start A Method to get the parameters from the user and make sure that they are not zero or negative numbers
    GetParameters(ref xValue, ref yValue);
    Console.WriteLine();
    
    // Start a metheod to determine the polar coordiantes and  calculate them in degrees and distance
    PolarCoordinates(ref hypotenuse, ref theta, xValue, yValue);
    Console.WriteLine();
    
    // Start a method to print the results of the the calculations
    PrintResults(hypotenuse, theta);
    Console.WriteLine();

    // ask the user if they would like to run the program again?
    Console.WriteLine("Would you like to run the program again? (yes / no)");
    repeat = Console.ReadLine().ToLower();

    // write a statement to determine if we should un the pgrogram again and loop to validate the answer
    if (repeat != "yes" && repeat != "no")
    {
        while (repeat != "yes" && repeat != "no")
        {
            Console.Write("I'm sorry, please enter 'yes' to begin agian or 'no' to quit");
            repeat = Console.ReadLine().ToLower();
        }
    }
} while (repeat == "yes");

} // End Main

    // Method Prologue for the GetParameters Method
    // Purpose: Gets the input from a user and validates if it was positve and not zero
    // Parameters:  Two doubles passed by reference
    // Returns: Void, all parameters are passed by reference
    // The method header follows
static void GetParameters(ref double x, ref double y)
{
    // Begining a loop to ask for parameters, if they don't meet the specs, then we'll ask agian.
    do
    {
        // Ask user for the value of x, it must not be zero.
        Console.WriteLine();
        Console.Write("Please enter X-coordiante of a point. It must not be zero: ");

        // parse the value and assign it to variable x
        x = double.Parse(Console.ReadLine());

        // begin validation of x that must not be zero
        if (x == 0)
        {
            // if the value is zero, ask for another value 
            Console.WriteLine();
            Console.WriteLine("I'm sorry the value for x must not be zero");
            
        }
        else
        {
            // the the value is not zero ask for a y value
            Console.WriteLine();
            Console.Write("Please enter the y-coordinate of a point: ");

            // parse the the input and assign it to value y
            y = double.Parse(Console.ReadLine());

            // check to validate y is a positive number
            if (y < 0)
            {
                // if Y is less than zero ask for a new number
                while (y < 0)
                {
                    Console.Write("Please enter a positive value for Y: ");

                    // check to validate y is a positive number
                    y = double.Parse(Console.ReadLine());
                }
            }
        }

    // close loop to validate x is not zero
    } while (x == 0);

}


    // Method Prologue for the PolarCoordinates Method
    // Purpose: Change the coordinates given to polar coordinates
    // Parameters:  Two doubles passed by reference, and two doubles passed by value
    // Returns: Void, all parameters are passed by reference
    // The method header follows
 static void PolarCoordinates(ref double hyp, ref double angle, double x, double y)
{
     // declare the variable for the calculation to polar coordiantes
     double degrees = 180; 

     //  calculate the distance to the point by finding the square root of x squared plus y squared
     hyp = Math.Sqrt(((x * x) + (y * y)));

     // find the angle of the coordiantes by taking the arc tangent of y / x and then turing it to degrees. 
     angle = (Math.Atan((y / x)))* degrees / Math.PI;
     
}

    // Method Prologue for the PrintResults Method
    // Purpose: To print the polar coordinates for the user
    // Parameters:  Two doubles passed by value
    // Returns: Void
    // The method header follows
static void PrintResults(double hyp, double angle)
{
    // print the results of the Method PolarCoordinates
    Console.WriteLine("The polar coordinates are:");
    Console.WriteLine("Distance from the origin is {0:f3}", hyp);
    Console.WriteLine("Angle (in degrees) from the x-axis is {0:f3}", angle);
}





}// end class program