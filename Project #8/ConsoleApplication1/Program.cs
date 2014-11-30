// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project 8
// Date:  3/28/2013

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.IO;

class Program
{

// Declare Constants
    
    const double expressionOne = 35.74;
    const double expressionTwo = 0.6215;
    const double expressionThree = 35.75;
    const double exponent = 0.16;
    const double expressionFour = 0.4275;
    const int Size = 100;

    static void Main()
{

// Declare Variables

   double chill;
   double temp = 0;
   double wind = 0;
   string file;
   string weather;
   string[] weatherArray = new string [Size];
  
  

// start code for program
// display student information



Console.WriteLine("Name: Franklin Colton Parry");
Console.WriteLine("Date: 3/28/2013");
Console.WriteLine("Assignment: Project 8");
Console.WriteLine("Section: 601");
Console.WriteLine("___________________________");
Console.WriteLine();

// ask user for file name and save it as a variable

Console.WriteLine("Enter a file name in your documents folder:");
    file = Console.ReadLine();
    
    string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\" + file;
    StreamReader weatherData = new StreamReader(path);
    

// start a loop to read each line and separate them to the correct variables

do
{

    // put the first line of the string into a variable
    weather = weatherData.ReadLine();

    // check to make sure the file isn't complete
    if (weather != null)
    {

        // split the line into an array of variables
        weatherArray = weather.Split();
        // store the new values to variables

        temp = double.Parse(weatherArray[0]);

        wind = double.Parse(weatherArray[1]);
        
        // perform calculations

        chill = expressionOne + expressionTwo * temp - expressionThree * (Math.Pow(wind, exponent)) + expressionFour * temp * (Math.Pow(wind, exponent));

// print results

        Console.WriteLine("For temperature in degrees F = {0:f2}", temp);
        Console.WriteLine("and a wind velocity in mph = {0:f2}", wind);
        Console.WriteLine("The Wind Chill Factor = {0:f2} degrees", chill);

    }



}while(weather != null);

Console.ReadLine();

}// end main
}// end program