// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 02
// Date:  1/28/2013


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
        // Declare Constants: In this case it will be all numbers used to calculate how many gold pieces are distributed
        
        const int INITIAL_DISTRIBUTION = 3;
        const int JACK_AND_FIRST_MATE =2;
        const double TWELEVE_PERCENT = .12;
        const double ROUND_ERR = .5;
        const double EIGHT_PERCENT = .08;

        // Declare the variables:

        int goldPile;
        int pirates;
        int captainGold;
        int firstMateGold;
        int crewGold;
        int piratesBenevolentAssociation;

        // Ask the user for the number of gold pieces in the treasure, and assign to goldPile

            Console.WriteLine("How many gold pieces are in the pile?" );
            goldPile = int.Parse(Console.ReadLine());

        // Ask the user for the number of pirates on the ship including the captain and first mate
            Console.WriteLine();
            Console.WriteLine("How many pirates are on the ship, including the captain and first mate?" );
            pirates = int.Parse(Console.ReadLine());

        // Figure out how many pieces of gold are left in the pile after the pirates leave for the night on the town
        // save this as goldPile.

            goldPile -= ((pirates - JACK_AND_FIRST_MATE) * INITIAL_DISTRIBUTION);

        // Calculate how much gold the captain will take as 12%; store this as a variable captainGold

            captainGold = ((int)((goldPile * TWELEVE_PERCENT)));

        // Calculate how much gold is left in the gold pile; save this as variable goldPile

            goldPile -= captainGold;

        // Calculate how much gold is left after the first mate takes his 8%; save this as firstMateGold

            firstMateGold = ((int)((goldPile * EIGHT_PERCENT)));

        // Calculate how much gold is now left in the gold pile; save this as variable goldPile

            goldPile -= firstMateGold;

        // Calculate how much gold is given to each pirate; save this a variable pirateGold

            crewGold = (goldPile / pirates); 

        // Calculate Captain Jacks total gold amount; save it as captainGold

            captainGold += crewGold;
        
        // calculate the first mates total gold amount; save it as firstMateGold

            firstMateGold += crewGold;

        // Add back in the amount given to each pirate for the first night to determine the total for each crew member; save as crewGold

            crewGold += INITIAL_DISTRIBUTION;

        // calcualte how much gold is given to the pirate benevolent association; save this as pirateBenevolentAssociation

            piratesBenevolentAssociation = goldPile % pirates;


            Console.WriteLine();
            Console.WriteLine("Captain Jack has {0} gold pieces.", captainGold);
            Console.WriteLine("The first mate has {0} gold pieces.", firstMateGold);
            Console.WriteLine("Each crew member will get {0} gold pieces.", crewGold);
            Console.WriteLine("The Pirate Benevolent Association will get {0} gold pieces.", piratesBenevolentAssociation);


        
            Console.ReadLine();
    }//End Main()
}//End class Program