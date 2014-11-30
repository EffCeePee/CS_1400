using System;

class Program
{


// Declare Constants, in this case we have none

// Declare Variables, Side A, Side B, and Side C, repeat


    // start main method
    static void Main()
    {
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;
        bool doAgain;
        


       // Begin main program Loop

do
{
// Tell the user that this program will compute the hypotenuse of a triangle..
    
    Console.WriteLine("This program will compute the hypotenuse of a triangle.");

    // Gather the lenghts of the two known sides of the triangle, store them as variables
    Console.WriteLine("Please type the length of side A: ");
    sideA = double.Parse(Console.ReadLine());
 
    Console.WriteLine("Please type the length of side B: ");
    sideB = double.Parse(Console.ReadLine());

    // Call Method "CalculateHypotenuse", and display the results stored in Side C
    sideC = CalculateHypotenuse(sideA, sideB);

    Console.WriteLine("The length of the hypotenuse is {0}", sideC);

    doAgain = Repeat();

    // Close main loop while: call method "Repeat."
} while (doAgain);

}// end main


// Start a new method "Calculate Hypotenuse"
// Purpose: Calculates the the hypotenuse of a triangle
// Parameters: Two Doubles, the known triangle side lengths
// Returns: A double, the hypotenuse
// The method header: 

    static double CalculateHypotenuse(double sideA, double sideB)
{
// Declare local variables
int squared = 2;
double sideD = sideA;
double sideE = sideB;
double sideC;


// Square Side A, store it as a variable double SideA
sideD = Math.Pow(sideD, squared);

// Square Side B, store it as a variable double SideB
sideE = Math.Pow(sideE, squared);

// Add Side A and Side B together store as variable Side C
sideC= sideD + sideE;

// Square Root Side C, store it as variable Side C

sideC = Math.Sqrt(sideC);

return sideC;
} // End CalculateHypotenuse



// Start a new method "Repeat"
// Purpose: to determine if the user would like to calculate another hypotenuse
// Parameters: none
// Returns: a boolean = true for yes, and false for no
// The method header: static bool repeat()
static bool Repeat()
{
// declare local variables, string yes, string no, string answer
string answer;

// Begin validation loop
do
{

// Prompt user if they want to calculate a new hypotenuse
Console.WriteLine("Do you want to calculate another hypotenuse?");
answer = Console.ReadLine().ToUpper();

// If answer is not "yes" or "no" then ask for correct input
if (answer != "YES" && answer != "NO")
{
 Console.WriteLine("I'm sorry, can you say 'yes' or 'no'");
            }
} while (answer != "YES" && answer != "NO");

// else if answer is yes, then return true,
if (answer == "YES")
return true;
// else if answer is no, then return false
else
return false;
// end method repeat
}// end repeat

} // end class program 