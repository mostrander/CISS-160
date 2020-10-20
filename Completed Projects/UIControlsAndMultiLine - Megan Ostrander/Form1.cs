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
 * Date: October 20, 2020
 * Goal: To take user input for car selection and additional add ons, and calculate the cost of the vehicle based on those selections.
 *       Output should show everything that is ordered for the car purchase.
*/

namespace UIControlsAndMultiLine___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void calculateButton_Click(object sender, EventArgs e)
      {
         decimal car_cost = 0.00m; //Holds select car's value.
         decimal additional_cost = 0.00m; //holds $ amount for car additional options selected
         decimal total_cost = 0.00m; //holds final order cost
         string order = "";
         string newline = Environment.NewLine; //FOr my purposes I have to use this to create new lines

         //Verify that a car is selected. REQUIRED.
         if (radioVolt.Checked == true || radioPinto.Checked == true)
         {
            if(radioVolt.Checked == true)
            {
               //Equals cost of Chevrolet Volt at $50,000
               car_cost = 50000.00m;
               order += radioVolt.Text + newline;
            }
            else if (radioPinto.Checked == true)
            {
               //Equals cost of Ford Pinto at $1,000
               car_cost = 1000.00m;
               order += radioPinto.Text + newline;
            }

            //Determine if any additional features were added to car order. If yes, add to additional_cost
            //If ordered, add to string variable order.
            if(roofBox.Checked == false && playerBox.Checked == false && gasTankBox.Checked == false)
            {
               order += "Options: None";
            }
            
            if(roofBox.Checked == true)
            {
               additional_cost += 1000;
               order += roofBox.Text + newline;
            }
            if(playerBox.Checked == true)
            {
               additional_cost += 500;
               order += playerBox.Text + newline;
            }
            if(gasTankBox.Checked == true)
            {
               additional_cost += 100;
               order += gasTankBox.Text + newline;
            }

            //Add the total cost of car + additional optional features. Display on screen.
            total_cost = car_cost + additional_cost;
            total_box.Text = total_cost.ToString();

            //Display items ordered on screen.
            orderedBox.Text = order;

            //Running small test with Environment.NewLine because textbox is not recognizing \n
            //string newline = Environment.NewLine;
            //orderedBox.Text = "Testing new" + newline + "line to see" + newline + "if it works.";
            //It did work. Thus, I will need to use this method instead for what I intend.
            //Will leave code here as a reference.

         }
         else
         {
            //Throw an error message if neither option is selected by the user. 
            MessageBox.Show("You must select a car to purchase.");
         }

      }

      private void clearButton_Click(object sender, EventArgs e)
      {
         //Erase the information in total box and ordered box, and uncheck additional feature boxes.
         total_box.Text = "";
         orderedBox.Text = "";

         roofBox.Checked = false;
         playerBox.Checked = false;
         gasTankBox.Checked = false;
      }
   }
}
