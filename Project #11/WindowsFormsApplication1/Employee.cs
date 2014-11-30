// File Prologue
// Name: Franklin Colton Parry
// Section: 601
// Project: Project 11
// Date:  4/16/2013

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Employee
    {

        // declare attributes 

        private int employeeNumber;
        private string name;
        private string address;
        private double hourlyWage;
        private double hrsWorked;

        //------------------------constructors-------------------------
        // Method Prologue for the default contructor Method
        // Purpose: initializes the vaules
        // Parameters:  none
        // Returns: none
        // The method header follows

        public Employee()
        {
            employeeNumber = 0;
            name = null;
            address = null;
            hourlyWage = 0.0;
            hrsWorked = 0;
        }


        //------------------------Setters-------------------------

        // Method Prologue for the SetEmpNum Method
        // Purpose: initializes the vaules
        // Parameters:  empNum
        // Returns: void
        // The method header follows

        public void SetEmpNum(int empNum)
        {
            employeeNumber = empNum;
        }


        // Method Prologue for the SetName Method
        // Purpose: sets the value for the name
        // Parameters:  name
        // Returns: none
        // The method header follows

        public void SetName(string fullName)
        {
            name = fullName;
        }


        // Method Prologue for the SetAddress Method
        // Purpose: initializes the vaules
        // Parameters: addy
        // Returns: none
        // The method header follows

        public void SetAddress(string addy)
        {
            address = addy;
        }

        // Method Prologue for the SetWage Method
        // Purpose: sets the value for the wages
        // Parameters:  wage
        // Returns: none
        // The method header follows

        public void SetWage(double wage)
        {
            hourlyWage = wage;
        }
        // Method Prologue for the SetHours Method
        // Purpose: Sets the value for the hours worked
        // Parameters:  none
        // Returns: none
        // The method header follows

        public void SetHours(double hoursWorked)
        {
            hrsWorked = hoursWorked;
        }


        //------------------------Getters-------------------------


        // Method Prologue for the GetName Method
        // Purpose: Get the name
        // Parameters:  none
        // Returns: name
        // The method header follows

        public string GetName()
        {
            return name;
        }


        // Method Prologue for the GetAddress Method
        // Purpose: Gets the address
        // Parameters:  none
        // Returns: address
        // The method header follows

        public string GetAddress()
        {
            return address;
        }


        //--------------------Data Manipulation-------------------

        // Method Prologue for the CalcNetPay Method
        // Purpose: to calculate the net pay
        // Parameters:  none
        // Returns: netPay
        // The method header follows
        public double CalcNetPay()
        {
            // declare instance variables
            double fullTime = 40;
            double overtime = hrsWorked - fullTime;
            double halfTime = .5;
            double netPay;
            double taxes = (1 - .275);

            // logic to determine overtime
            if (overtime > 0)
            {
                // calculate net pay if overtime occured
                netPay = ((hourlyWage * hrsWorked) + (overtime * halfTime * hourlyWage)*taxes);

            }
            else
            {
                // calculate net pay if no overtime
                netPay = (hourlyWage * hrsWorked)*taxes;
            }

            
            return netPay;
        }

    }

}
