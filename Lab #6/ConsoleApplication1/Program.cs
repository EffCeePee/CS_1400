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
        // INITIAL_DISTRIBUTION = 3,  JACK_AND_FIRST_MATE = 2, TWELEVE_PERCENT = .12, ROUND_ERR = .5, EIGHT_PERCENT = .08
        // Declare the variables: goldPile. pirates, captainGold, firstMateGold, crewGold, piratesBenevolentAssociation
        // Ask the user for the number of gold pieces in the treasure, and assign to goldPile
        // Ask the user for the number of pirates on the ship including the captain and first mate, store to pirates
        // Figure out how many pieces of gold are left in the pile after the pirates leave for the night on the town, save this as goldPile. 
        // goldPile = (goldPile -(pirtates * JACK_AND FIRST_MATE) * INITIAL DISTRIBUTION)
        // Calculate how much gold the captain will take as 12%; store this as a variable captainGold
        // captainGold = (goldPile * TWELEVE_PERCENT)
        // Calculate how much gold is left in the gold pile; save this as variable goldPile
        // goldPile = (goldPile - captainGold)
        // Calculate how much gold is left after the first mate takes his 8%; save this as firstMateGold
        // firstMateGold = (goldPile * EIGHT_PERCENT)
        // Calculate how much gold is now left in the gold pile; save this as variable goldPile
        // goldPile = (goldPile - firstMateGold)
        // Calculate how much gold is given to each pirate; save this a variable crewGold
        // crewGold = (goldPile / pirates)
        // Calculate Captain Jacks total gold amount; save it as captainGold
        // captainGold = (captainGold + crewGold)
        // calculate the first mates total gold amount; save it as firstMateGold
        // firstmateGold = (firstMateGold + crewGold)
        // Add back in the amount given to each pirate for the first night to determine the total for each crew member; save as crewGold
        // crewGold = (crewGold + INITIAL_DISTRIBUTION)
        // calcualte how much gold is given to the pirate benevolent association; save this as pirateBenevolentAssociation
        // piratesBenevolentAssociation = goldPile % pirates;
        // Write to the console how much gold is given to the captain, the first mate, each crew member, and the pirate benevolent association

        Console.ReadLine();
    }//End Main()
}//End class Program