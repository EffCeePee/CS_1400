//this program is to generate a certain ammount of random numbers between one and eighty

using System;

class Program
{
    // declare constants
    const int UPPER_LIMIT = 80;

    static void Main()
    {

        int column = 0;
        int rounds = 0;
        int number = 0;
        string again = "n";
        
        Random randomNums = new Random();
        
      do
      {
          if (column > 0 || rounds > 0 || number > 0)
          {
              column = 0;
              rounds = 0;
              number = 0;
          }
          else
          {

              Console.WriteLine("How many numbers would you like me to generate?");
              rounds = int.Parse(Console.ReadLine());

              Console.WriteLine("round\tnumber\t");

              do
              {
                  number = (randomNums.Next(UPPER_LIMIT) + 1);
                  column++;

                  Console.WriteLine("{0}\t{1}\t", column, number);
              } while (column < rounds);

              Console.WriteLine("would you like to generate more numbers? (y/n)");
              again = Console.ReadLine().ToLower();
              
              
              if (again != "y" && again != "n")
              {
                  Console.WriteLine("Sorry I didn't get that, please enter a 'y' or 'n'");
                  again = Console.ReadLine().ToLower();
              }
             
          }
      } while(again == "y");

      Console.WriteLine("Thanks, press 'Enter' to exit");
        Console.ReadLine();
    }//End Main()
}//End class Program