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

        Console.WriteLine("Franklin Colton Parry");
        Console.WriteLine("CS 1400 Section 601");
        Console.WriteLine("Project Two: Goodguys Delivery Services");
        Console.WriteLine("________________________________________");
        Console.WriteLine();


 // Define constants, avoid magic numbers by defining the numbers needed for time conversion
    const int ONE_HUNDRED = 100;
    const int SIXTY = 60;
    const double TIME_INCREASE = .25;

// Define Variables, variables in this case will be for the old times and new times in minutes
    int startTime = 0;
    int deliveryTime = 0;
    int deliveryDurration = 0;
  

// Tell the user we are going to give a new arrival time
        Console.WriteLine("This program will give a new delivery time, due to I-15 construction.");

// Ask the user for the start time in 24rh format hhmm, store it as startTime
        Console.WriteLine("Please provide the delivery start time in 24hr format hhmm:");
   startTime = int.Parse(Console.ReadLine());

// Ask the user for the Delivery end time in 24hr format hhmm, store it as oldDeliveryTime
        Console.WriteLine("Please provide the delivery end time in 24hr format, HHMM:");
        deliveryTime = int.Parse(Console.ReadLine());

// We will need to convert the start time from 24hr format into minutes.  
// First we will start by getting the hours by dividing the start time by the constant ONE_HUNDRED
// then find the minutes then muliplying by SIXTY for minutes,  
// Then we will get the remaining minutes by using the modulo function so it will be startTime % ONE_HUNDRED 
// Finally we will add the minutes together
// We will then store that replacing the starttime. 

        startTime = (((startTime / ONE_HUNDRED) * SIXTY) + (startTime % ONE_HUNDRED));

// we now need to convert the end time to minutes following the same proceedure as before
// First we will start by getting the hours by dividing the oldDeliverytime by the constant ONE_HUNDRED
// then find the minutes then muliplying by SIXTY for minutes,  
// Then we will get the remaining minutes by using the modulo function so it will be oldDeliveryTime % ONE_HUNDRED 
// Finally we will add the minutes together
// We will then store that replacing oldDeliveryTime

        deliveryTime = (((deliveryTime / ONE_HUNDRED) * SIXTY) + (deliveryTime % ONE_HUNDRED));

// we will then calculate the old delivery duration by taking the delivery time in minutes and subtracting 
// the start time in minutes to give us a delivery duration time. 
// (delivery time – start time = oldDeliveryDurration)

        deliveryDurration = (deliveryTime - startTime);

// To get the new delivery durration we will take the old delivery durration and multiply it by our contstant TIME_INCREASE

        deliveryDurration += (int)(deliveryDurration * TIME_INCREASE);

// To get a new delivery time we then add the deliveryDurration in minutes to the start time in minutes

        deliveryTime = (startTime + deliveryDurration);

// To generate the output we will need to convert the deliveryTime back to hhmm format.  To do that, first we will
// will need to figure out how many hours it takes by dividing the deliveryTime by SIXTY.   We will then find the remainder
// using the module so it will look like (deliveryTime % SIXTY), then store them as variables. 


        deliveryTime = (((deliveryTime / SIXTY) * ONE_HUNDRED) + (deliveryTime % SIXTY));

// Then we will print the new delivery time. 
        Console.WriteLine();
        Console.WriteLine("The new trip time is {0} minutes", deliveryDurration );
        Console.WriteLine();
        Console.WriteLine("The new delivery end time is: {0:D4}", deliveryTime);


        Console.ReadLine();
    }//End Main()
}//End class Program