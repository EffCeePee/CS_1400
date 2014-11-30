// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project 11
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
using System.IO;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        // declare class variables and constants
        const int SIZE = 10;
        
        int count = 0;
        Employee[] person;
        string inputString;
        int current = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            // initializing a new object array of persons
            person = new Employee[SIZE];

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // close when press exit
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show about screen
            MessageBox.Show("Franklin Colton Parry \nCS1400\nProject #11");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // use a stream reader class to read a new file
            Stream myStream = null;

            // opening file code
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // set path to open a file to my documents
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            
            // filters for text files
            openFileDialog1.Filter = "text Files (.txt) | *txt";

            // set logic to determine if a file was chosen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // if a file was opened start reading the file
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader data = new StreamReader(myStream);

                    // start a loop to Create Objects Employee
                    for (int i = 0; i < SIZE; i++)
                    {
                        person[i] = new Employee();
                        
                    }

                    do
                    {
                        // read the first line of data in the file    
                        inputString = data.ReadLine();

                        // test the read line to make sure it isn't null
                        if(inputString != null)
                        {
                            // parse  the read line into an int
                            int empNum = int.Parse(inputString);
                            // call setter method to set the employee number
                            person[count].SetEmpNum(empNum);

                            // read the next line and set it to employee name
                            string info = data.ReadLine();
                            person[count].SetName(info);

                            // read next line and set it to address
                            string addy = data.ReadLine();
                            person[count].SetAddress(addy);

                            // read the next line
                            string line = data.ReadLine();
                            // split the line into an array
                            string[] dataLine = line.Split();

                            // parse the first element in the array to the double variable
                            double wage = double.Parse(dataLine[0]);
                            // call setter method to set it to wage
                            person[count].SetWage(wage);

                            // parse the next element in the array
                            double hoursWorked = double.Parse(dataLine[1]);

                            // call setter method to set it to the hours
                            person[count].SetHours(hoursWorked);

                            // increment count to move to next object in the array
                            count++;

                        }
                        // stop when inputstring is null
                    } while (inputString != null);

                    // call amd format value of the method of GetName to set the field for name
                    string nameStr = string.Format("{0}", person[0].GetName());
                    NameTxtBox.Text = nameStr;

                    // call amd format value of the method of GetAddress to set the field for address
                    string addyStr = string.Format("{0}", person[0].GetAddress());
                    AddressTxtBox.Text = addyStr;

                    // call amd format value of the methodd of CalcNetPay to set the field for net pay
                    string payStr = string.Format("{0:C}", person[0].CalcNetPay());
                    NetPayTxtBox.Text = payStr;

                }
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            // start logic to determine if all names have been displayed
            if (current < count - 1)
            {
                // increment current employee when the button is clicked
                current++;
            }
            else
            {
                // if all employees have been displayed diable "next" button
                NxtBtn.Enabled = false;
                
            }

            // call amd format value of the method of GetName to set the field for name
            string nameStr = string.Format("{0}", person[current].GetName());
            NameTxtBox.Text = nameStr;

            // call amd format value of the method of GetAddress to set the field for address
            string addyStr = string.Format("{0}", person[current].GetAddress());
            AddressTxtBox.Text = addyStr;

            // call amd format value of the methodd of CalcNetPay to set the field for net pay
            string payStr = string.Format("{0:C}", person[current].CalcNetPay());
            NetPayTxtBox.Text = payStr;

            

                     
        }


    }
}
