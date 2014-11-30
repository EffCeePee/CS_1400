// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 24
// Date:  4/15/2013


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
using System.IO;


// purpose:  To open a file 
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Exits program when exit button is clicked
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Shows about menu when the about button is clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Franklin Colton Parry \nCS1400\nLab #24");
        }

        // Opens up a dialog box for finding a file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // declaring a vairable myStream
            Stream myStream = null;

            // open thefile dialog box
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // initialized the primary directory
            openFileDialog1.InitialDirectory = "c:\\" ;

            // allows us to open  .txt files
            openFileDialog1.Filter = "text files (*.txt)|*txt" ;

            // conditional statement validating the open file worked
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //validates that the file was not empty
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    
                    // reads the data in the file 
                    StreamReader data = new StreamReader(myStream);

                    // writes the data to the text box
                    textBox.Text = data.ReadLine();
                }

            }


        }


    }
}
