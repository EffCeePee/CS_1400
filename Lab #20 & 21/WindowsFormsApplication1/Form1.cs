// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Lab 20
// Date:  4/2/13


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

//namespace WindowsFormsApplication1
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Franklin Colton Parry \nCS1400\nLab #20");
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

 
//        private void computeBtn_Click_1(object sender, EventArgs e)
//        {
//            int num = int.Parse(inTxtBox.Text);
//            num += num;
//            string outStr = string.Format("{0:D}", num);
//            outTxtBox.Text = outStr;
//        }
//    }
//}




class Program
{
    static void Main()
    {
        // create a Box object and use setters
        Box hatBox = new Box();
        hatBox.SetHeight(5);
        hatBox.SetWidth(2);
        hatBox.SetLength(3);

        // use getters
        Console.WriteLine("The dimensions of the hat box are: {0} x {1} x {2}",
            hatBox.GetHeight(), hatBox.GetWidth(), hatBox.GetLength());

        // use the data manipulation method
        Console.WriteLine("The volume of this box is {0}", hatBox.CalcVolume());
        Console.ReadLine();

    }
}

// Box class definition
// represents a Box of some kind
class Box
{
    private int width;
    private int height;
    private int length;

    // ------------------ Constructors ----------------------------

    // the default constructor
    // purpose: initialize all values to zero
    // Parameters: none
    // Returns: none
    public Box()
    {
        length = 0;
        height = 0;
        width = 0;
    }

    // the parameterized constructor
    // purpose: initialize all values 
    // Parameters: the width (p1), height (p2) and width (p3) of the box
    // Returns: none
    public Box(int p1, int p2, int p3)
    {
        length = p1;
        height = p2;
        width = p3;
    }

    //---------------------- Getters ----------------------

    // the GetWidth method
    // purpose: getter for width 
    // Parameters: none
    // Returns: the width as an integer    
    public int GetWidth()
    {
        return width;
    }

    // the GetHeight method
    // purpose: getter for height 
    // Parameters: none
    // Returns: the height as an integer    
    public int GetHeight()
    {
        return height;
    }

    // the GetLength method
    // purpose: getter for length 
    // Parameters: none
    // Returns: the length as an integer    
    public int GetLength()
    {
        return length;
    }

    //------------------------- Setters --------------------------

    // the SetWidth method
    // purpose: setter for width 
    // Parameters: an integer p1
    // Returns: none    
    public void SetWidth(int p1)
    {
        width = p1;
    }

    // the SetHeight method
    // purpose: setter for height 
    // Parameters: an integer p1
    // Returns: none   
    public void SetHeight(int p1)
    {
        height = p1;
    }

    // the SetLength method
    // purpose: setter for length 
    // Parameters: an integer p1
    // Returns: none    
    public void SetLength(int p1)
    {
        length = p1;
    }

    //------------------ Data Manipulation Method --------------------
    // the CalcVolume method
    // purpose: calculates and returns the volume of the box 
    // Parameters: none
    // Returns: an integer, the calculated volume    
    public int CalcVolume()
    {
        return length * height * width;
    }
}