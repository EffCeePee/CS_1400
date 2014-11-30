// This program is designed to give an output to Farmer John.  The output will be the area inside the circles not covered by his irrigation.
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 02
// Date:  1/14/2012


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
//------------------------------------------------------------------------

using System;

class Program
{
    const double PI = Math.PI;
    static void Main()
    {
        //Here I will define variable names
        double radius;
        double areaOfSquare;
        double areaOfCircle;
        double unWateredArea;

        // 1. We are goign to figure out the shaded area that Farmer John would like to know from the Lab 2 Exercise
        
        // 2. We will ask Farmer John to provide us the radius of the circle
        Console.WriteLine("This program calculates the unwatered area that Farmer John would like to know.");
        Console.Write("Please enter the radius of the irrigation circles: ");

        // 3. We will save this in a variable named radius
        radius = double.Parse(Console.ReadLine());

        // 4. We will calculate the area of the square, given that the radius is half of the length and width of the square using
        //    the formula, Area of a Square = the length X the Width
        areaOfSquare = ((radius + radius) * (radius + radius));

        // 5. We will calculate the area of the irrigation circles that are inside the square, using the formula Area of a circle
        //    = Pi x Radius Squared
        areaOfCircle = (PI * (radius * radius));

        // 6. We will then subtract the areas of the irrigation circles from the area of the square
        unWateredArea = (areaOfSquare - areaOfCircle);

        // 7. We will display the results
        Console.WriteLine("The unwatered area that Farmer John would like to know is {0:F} units", unWateredArea);

        Console.ReadLine();
    }//End Main()
}//End class Program
