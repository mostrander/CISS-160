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
 * Date: October 3, 2020
 * Goal: To take two numbers the user inputs, multiple them, can calculate a running total based off of the calcullation result. 
 *       Need to display the calculation result and the running total on the screen for user after they clcik the calculate button.
*/


namespace MultiAndAccum___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      //running total variable has to be initialized outside of calculate method to work properly.
      private double total = 0.0;

      public Form1()
      {
         InitializeComponent();
      }

      private void calculateButton_Click(object sender, EventArgs e)
      {
         //Variables to hold information as needed, and for calculation later.
         //I am using doubles so user may add decimal values instead of strickly integers.
         double number1 = 0.0;
         double number2 = 0.0;
         double result = 0.0;


         //Verify that there is data inputted into the number1 and number2 boxes.
         if (!String.IsNullOrEmpty(number1_Box.Text) && !String.IsNullOrEmpty(number2_Box.Text))
         {
            //Attempt to parse numbers from user input, otherwise throw error.
            if(double.TryParse(number1_Box.Text, out number1))
            {
               //Attempt to parse data from number2_Box input. Otherwise, throw error.
               if (double.TryParse(number2_Box.Text, out number2))
               {
                  //Calculate the result of multiplying the 2 numbers.
                  result = number1 * number2;

                  //Calculate the running total using the current result.
                  total = total + (result);

                  //display the results and running total on user screen.
                  result_Label.Text = result.ToString("N");
                  runningTotal_Label.Text = total.ToString("N");

                  //Determine if runningTotal_Label background should be changed to orange.
                  if(total <= 0)
                  {
                     runningTotal_Label.BackColor = Color.Orange;
                  }
                  else
                  {
                     runningTotal_Label.BackColor = Color.LightBlue;
                  }
               }
               else
               {
                  //Throw error if cannot parse information (i.e. it is not a numerical input only)
                  MessageBox.Show("Please only enter numerical data for Number 2.");
               }
            }
            else
            {
               //Throw error if cannot parse information (i.e. it is not a numerical input only)
               MessageBox.Show("Please only enter numerical data for Number 1.");
            }
         }
         else
         {
            MessageBox.Show("Please ensure you have entered a value for both Number 1 and Number 2!");
         }
      }

      private void clearButton_Click(object sender, EventArgs e)
      {

         //Clear the input boxes and result labels
         number1_Box.Text = "";
         number2_Box.Text = "";
         result_Label.Text = "";
         runningTotal_Label.Text = "";

         //Make sure to reset the total variable to 0 since it is outside of the calculate method.
         total = 0;

         //Reset the background color for running total field to blue.
         runningTotal_Label.BackColor = Color.LightBlue;
      }
   }
}
