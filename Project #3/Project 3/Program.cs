// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project #3
// Date:  02/08/13


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;

class Program
{
  // declare constants that will be used in shipping calculations
    enum Shipping { STANDARD = 1, EXPRESS, SAME_DAY }

    const double STANDARD_A = 3;
    const double STANDARD_B = 1.45;
    const double EXPRESS_A = 4;
    const double EXPRESS_B = 2.5;
    const double SAME_DAY_A = 5.5;
    const double SAME_DAY_B = 3;
    const double STANDARD_SURCHARGE = 2.5;
    const double EXPRESS_SURCHARGE = 5;
    const double SAME_DAY_SURCHARGE = 8;

    static void Main()
    {
   // declare variables that we will gather from the user
        
        string category = "A";
        double items = 0;
        double weight = 0;
        string alaskaOrHawaii = "null";
        double shippingMethod = 0;
        double shippingCost = 0;

        Console.WriteLine("Name: Franklin Colton Parry");
        Console.WriteLine("Section: 601");
        Console.WriteLine("Project #3");
        Console.WriteLine("2/9/13");
        Console.WriteLine();
      

   // Tell the users what the programs does
   // get input from users on which type of shipping they would like.  Store it as shipping cost. 

        Console.WriteLine("This program will determine what your shipping costs are.");
        Console.WriteLine();
        Console.WriteLine("Please tell me what shipping method you want: ");
        Console.WriteLine("Please press {0:d} for Standard (3-5 days) Shipping", Shipping.STANDARD);
        Console.WriteLine("Please press {0:d} for Express (2 days) Shipping", Shipping.EXPRESS);
        Console.WriteLine("Please press {0:d} for Same Day (1 day) Shipping", Shipping.SAME_DAY);
        Console.WriteLine("Type you choice (1, 2, or 3): ");
        shippingMethod = double.Parse(Console.ReadLine());

   // Use a switch statement to determine which set of instructions to run for shipping costs.  
        switch ((Shipping)shippingMethod)
        {
   // Standard shipping method
            case Shipping.STANDARD:

   // Gather if the shipping cost will be determined by items or weight.  Store Answers as a variable category
                Console.WriteLine();
                Console.WriteLine("Thank You.");
                Console.WriteLine("Will the items shipped be in category A or B?");
                Console.WriteLine("Type your choice (A or B): ");
                category = (Console.ReadLine().ToUpper());

   // Gather the number of items if it is category A, store as a variable items.
                if (category == "A")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank You.");
                    Console.WriteLine("Please enter the number of items in this shipment: ");
                    items = double.Parse(Console.ReadLine());
                }
   // Geather the weight of the items if category B, store the input as a variable weight
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank You.");
                    Console.WriteLine("Please enter the weight of the items: ");
                    weight = double.Parse(Console.ReadLine());
                }

   // Determine if there will be a surcharge for Alaska or Hawaii, store the result as variable 
                Console.WriteLine();
                Console.WriteLine("Thank You.");
                Console.WriteLine("Will the items be going to Alaska or Hawaii? (Y / N)");
                alaskaOrHawaii = (Console.ReadLine().ToUpper());

   // If a surcharge is needed calculate the shipping cost, store it as shipping costs.
                if (alaskaOrHawaii == "Y")
                {
                    shippingCost = items * STANDARD_A + weight * STANDARD_B + STANDARD_SURCHARGE;
                }
   // If a surcharge is not needed calculate the shipping cost, store it as shipping costs.
                else
                {
                    shippingCost = items * STANDARD_A + weight * STANDARD_B;
                }

                Console.WriteLine();
                Console.WriteLine("Standard Shipping");
                if (weight > 0)
                {
                    Console.WriteLine("your itmes weigh {0} lbs", weight);
                }

                else
                {
                    Console.WriteLine("{0} items", items);
                }

                Console.WriteLine("Your shipping costs are {0:C}", shippingCost);

            break;
   // Move to next condition


   // Express shipping method
            case Shipping.EXPRESS:

            // Gather if the shipping cost will be determined by items or weight.  Store Answers as a variable category
            Console.WriteLine();
            Console.WriteLine("Thank You.");
            Console.WriteLine("Will the items shipped be in category A or B?");
            Console.WriteLine("Type your choice (A or B): ");
            category = (Console.ReadLine().ToUpper());

            // Gather the number of items if it is category A, store as a variable items.
            if (category == "A")
            {
                Console.WriteLine();
                Console.WriteLine("Thank You.");
                Console.WriteLine("Please enter the number of items in this shipment: ");
                items = double.Parse(Console.ReadLine());
            }
            // Geather the weight of the items if category B, store the input as a variable weight
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank You.");
                Console.WriteLine("Please enter the weight of the items: ");
                weight = double.Parse(Console.ReadLine());
            }

            // Determine if there will be a surcharge for Alaska or Hawaii, store the result as variable 
            Console.WriteLine();
            Console.WriteLine("Thank You.");
            Console.WriteLine("Will the items be going to Alaska or Hawaii? (Y / N)");
            alaskaOrHawaii = (Console.ReadLine().ToUpper());

   // If a surcharge is needed calculate the shipping cost, store it as shipping costs.
                    if (alaskaOrHawaii == "Y")
                    {
                        shippingCost = items * EXPRESS_A + weight * EXPRESS_B + EXPRESS_SURCHARGE;
                    }
   // If a surcharge is not needed calculate the shipping cost, store it as shipping costs.
                    else
                    {
                        shippingCost = items * EXPRESS_A + weight * EXPRESS_B;
                    }
            
                Console.WriteLine();
                Console.WriteLine("Express Shipping");
                if (weight > 0)
                {
                    Console.WriteLine("your itmes weigh {0} lbs", weight);
                }

                else
                {
                    Console.WriteLine("{0} items", items);
                }
                Console.WriteLine("Your shipping costs are {0:C}", shippingCost);

            break;
   // Move to next condition

   // Same Day  shipping method
            case Shipping.SAME_DAY:

            // Gather if the shipping cost will be determined by items or weight.  Store Answers as a variable category
            Console.WriteLine();
            Console.WriteLine("Thank You.");
            Console.WriteLine("Will the items shipped be in category A or B?");
            Console.WriteLine("Type your choice (A or B): ");
            category = (Console.ReadLine().ToUpper());

            // Gather the number of items if it is category A, store as a variable items.
            if (category == "A")
            {
                Console.WriteLine();
                Console.WriteLine("Thank You.");
                Console.WriteLine("Please enter the number of items in this shipment: ");
                items = double.Parse(Console.ReadLine());
            }
            // Geather the weight of the items if category B, store the input as a variable weight
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank You.");
                Console.WriteLine("Please enter the weight of the items: ");
                weight = double.Parse(Console.ReadLine());
            }

            // Determine if there will be a surcharge for Alaska or Hawaii, store the result as variable 
            Console.WriteLine();
            Console.WriteLine("Thank You.");
            Console.WriteLine("Will the items be going to Alaska or Hawaii? (Y / N)");
            alaskaOrHawaii = (Console.ReadLine().ToUpper());

   // If a surcharge is needed calculate the shipping cost, store it as shipping costs.
                    if (alaskaOrHawaii == "Y")
                    {
                        shippingCost = items * SAME_DAY_A + weight * SAME_DAY_B + SAME_DAY_SURCHARGE;
                    }   
   // If a surcharge is not needed calculate the shipping cost, store it as shipping costs.
                    else
                    {
                       shippingCost = items * SAME_DAY_A + weight * SAME_DAY_B;
                    }

                Console.WriteLine();
                Console.WriteLine("Same Day Shipping");
                if (weight > 0)
                {
                    Console.WriteLine("your itmes weigh {0} lbs", weight);
                }
                else
                {
                    Console.WriteLine("{0} items", items);
                }
                Console.WriteLine("Your shipping costs are {0:C}", shippingCost);

            break;
   // Put in the default class

            default:
                Console.WriteLine("I'm sorry I don't know which shipping method you'd like.  Please try again.");
            break;
        }


   // print the shipping costs for the user

        Console.WriteLine("Press any key to continue...");

        Console.ReadLine();
    }//End Main()
}//End class Program