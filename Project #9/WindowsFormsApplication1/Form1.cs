// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project 9
// Date:  4/6/213


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // exits program
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // displays content in about box
            MessageBox.Show("Franklin Colton Parry\nCS1400\nSection 601\nProject #9");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // call method add numbers and assign it to the sum text box
                       
            sumTxtBox.Text = AddNumbers(firstNumberTxtBox.Text, secondNumberTxtBox.Text);

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // reset the text boxes to empty

            firstNumberTxtBox.Text = "";
            secondNumberTxtBox.Text = "";
            sumTxtBox.Text = "";
        }



        // Method Prologue for the GetParameters Method
        // Purpose: add two numbers from the user
        // Parameters:  Two doubles passed value
        // Returns: string value of the sum of the numbers
        // The method header follows
        static string AddNumbers(string valueOne, string valueTwo)
        {
            // declare local variables
            double sum;
            double numOne;
            double numTwo;
            string value;

            // parse numbers to ints
            numOne = double.Parse(valueOne);

            numTwo = double.Parse(valueTwo);

            //add the numbers together
            sum = numOne + numTwo;

            // convert back to a string
            value = string.Format("{0}", sum);
            
            //return the right value
            return value;
        }



    }
}
