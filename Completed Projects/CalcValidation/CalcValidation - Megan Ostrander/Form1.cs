using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Author: Megan Ostrander
 * ID: 000635277
 * Date: September 22, 2020
 * Goal: To take user input for odometer readings at two different stops, calculate the # of 
 *       miles traveled between stops, calculate the average miles per gallon (mpg) based on
 *       the number of miles traveled, and to calculate the total cost to refill the gas tank
 *       at the second stop.
*/


namespace CalcValidation___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void calculateButton_Click(object sender, EventArgs e)
      {

         //Variables to hold user input during calculations
         double odometerStart;
         double odometerEnd;
         double gallons;
         decimal gasPrice;

         //Use a Try / Catch block to catch any exceptions or incorrect input.
         try
         {
            //Try to take numeric input from the user input boxes
            odometerStart = double.Parse(beginningOdometer_Box.Text);
            odometerEnd = double.Parse(endingOdometer_Box.Text);
            gallons = double.Parse(gallonsFilled_Box.Text);
            gasPrice = decimal.Parse(gasPrice_Box.Text);

            if(odometerEnd < odometerStart)
            {
               MessageBox.Show("Negative miles is not possible. " +
                                 "Please the numbers you input for stop #1 and #2.");
            }
            else if (gasPrice < 0)
            {
               MessageBox.Show("It is not possible to have a negative gas price. " +
                                 "Please enter zero if you were not charged for gas.");
            }
            else
            {
               //Calculate the average miles per gallon (MPG), as well as # of miles driven between stops
               //And the total amount spent to refill tank.
               double miles = odometerEnd - odometerStart; //determines # of miles driven between stops
               double mpg = miles / gallons;
               decimal totalCost = (decimal)gallons * gasPrice;

               //For testing purposes, display the above information to ensure it is
               //Being recognized properly.
               //milesTraveled.Text = odometerEnd.ToString("N") + " - " + odometerStart.ToString("N");
               //milesPerGallon.Text = gallons.ToString("N");
               //gasCost.Text = cost.ToString("C");

               //Display the results.
               milesTraveled.Text = miles.ToString("N");
               milesPerGallon.Text = mpg.ToString("N");
               gasCost.Text = totalCost.ToString("C");
                     
            }

         }
         catch
         {
            //Ensure that all input fields have content in them (not empty)
            if (String.IsNullOrEmpty(beginningOdometer_Box.Text))
            {
               MessageBox.Show("The Stop #1 field cannot be empty. Please input a number.");
               return;
            }
            else if (String.IsNullOrEmpty(endingOdometer_Box.Text))
            {
               MessageBox.Show("The Stop #2 field cannot be empty. Please input a number.");
               return;
            }
            else if (String.IsNullOrEmpty(gallonsFilled_Box.Text))
            {
               MessageBox.Show("The gallons refilled field cannot be empty. Please input a number.");
               return;
            }
            else if(String.IsNullOrEmpty(gasPrice_Box.Text))
            {
               MessageBox.Show("The gas price field cannot be empty. Please input a number.");
               return;
            }
            else
            {
               if (double.TryParse(beginningOdometer_Box.Text, out odometerStart))
               {
                  if (double.TryParse(endingOdometer_Box.Text, out odometerEnd))
                  {
                     if (double.TryParse(gallonsFilled_Box.Text, out gallons))
                     {
                        if (decimal.TryParse(gasPrice_Box.Text, out gasPrice))
                        {
                           //Calculate the average miles per gallon (MPG), as well as # of miles driven between stops
                           //And the total amount spent to refill tank.
                           double miles = odometerEnd - odometerStart; //determines # of miles driven between stops
                           double mpg = miles / gallons;
                           decimal totalCost = (decimal)gallons * gasPrice;

                           //Display the results.
                           milesTraveled.Text = miles.ToString("N");
                           milesPerGallon.Text = mpg.ToString("N");
                           gasCost.Text = totalCost.ToString("C");
                        }
                        else
                        {
                           MessageBox.Show("Please enter a valid number into the cost of gas field.");
                           return;
                        }
                     }
                     else
                     {
                        MessageBox.Show("Please enter a valid number into the gallons needed to refill tank field.");
                        return;
                     }
                  }
                  else
                  {
                     MessageBox.Show("Please enter a valid number into the Stop #2 Odometer Reading field.");
                     return;
                  }
               }
               else
               {
                  MessageBox.Show("Please enter a valid number into the Stop #1 Odometer Reading field.");
                  return;
               }

            }

            return;
         }
      }


      private void clearButton_Click(object sender, EventArgs e)
      {
         //Clear the user input boxes, as well as the results.
         milesTraveled.Text = "";
         milesPerGallon.Text = "";
         gasCost.Text = "";

         beginningOdometer_Box.Text = "";
         endingOdometer_Box.Text = "";
         gasPrice_Box.Text = "";
         gallonsFilled_Box.Text = "";
      }
   }
}
