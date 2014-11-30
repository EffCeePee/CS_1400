// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 19
// Date:  3/22/2013


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.IO;

class Program
{
    // declare constants
    const int SIZE = 50;

    static void Main()
    {
        // declare variables
        int[] gradesArray = new int[SIZE];  // Array for the data
        string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\grades.txt";
        StreamReader gradesData = new StreamReader(path);   // stream reader for grades.txt
        string grades;
        int count = 0;
        double averageGrade = 0;
        
   

        // loop that will read the grades.txt file and store to an array
        do
        {
            // read each line of the file
            grades = gradesData.ReadLine();
            if (grades != null)
            {

                // store the line to the array
                gradesArray[count] = int.Parse(grades);
                // print the line to the console
                Console.WriteLine("the number read is {0}", gradesArray[count]);
                count++;
            }
        } while (grades != null);

        // write a loop that will calculate the average of the partially filled array

        for (int i = 0; i < count + 1; i++)
        {
            averageGrade += gradesArray[i];
            if (i == count)
            {
                averageGrade /= i;
                Console.WriteLine();
                Console.WriteLine("The average grade is {0:f2}", averageGrade);
            }

        }

        //Console.WriteLine("{0}", gradesData);
            
            
        
        Console.ReadLine();
    }//End Main()
}//End class Program
