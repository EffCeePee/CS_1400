// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project 10
// Date:  4/14/2013

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
        // declare counter variable
        private Counter myCounter;
        
        

        public Form1()
        {
            InitializeComponent();

            // create my counter object
            myCounter = new Counter();
        }

        // event handlers

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Franklin Colton Parry \nCS1400\nProject #10");
        }

        public void incBtn_Click(object sender, EventArgs e)
        {
            // call method to increase count            
            int plusOne = myCounter.Increment();
            // convert to string
            string outStr = string.Format("{0}", plusOne);
            // display in text box
            CountTxtBox.Text = outStr;
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            // call method to decrease count
            int minusOne = myCounter.Decrement();
            // convert to string
            string outStr = string.Format("{0}", minusOne);
            // display in text box
            CountTxtBox.Text = outStr;
           
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // call method to clear counter and reset to zero
            int reset = myCounter.Reset();
            // convert to string
            string outStr = string.Format("{0}", reset);
            // display in text box
            CountTxtBox.Text = outStr;
            
        }

        private void CountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }



                
    }// end of form class

    // new counter class
   public class Counter
    {

        // declare variables
        private int count;


        // ------------------ Constructors ----------------------------
        // the default constructor
        // purpose: initialize  values to zero
        // Parameters: none
        // Returns: none

        public Counter()
        {
            // set count to zero
            count = 0;
        }



   

        // the increment method
        // purpose: setter for count 
        // Parameters: an integer cnt
        // Returns: int    
        public int Increment()
        {
            count++;
            return count;
           
        }


        // the decrement method
        // purpose: setter for count 
        // Parameters: an integer cnt
        // Returns: int    
        public int Decrement()
        {
            if (count > 1)
            {
                count--;

            }
            else count = 0;

            return count;
        }

    

        // the reset method
        // purpose: resets the count to zero
        // Parameters: 
        // Returns: int    
        public int Reset()
        {
            count = 0;
            return count;
        }


    }// end counter class




}  // ond of namespace
