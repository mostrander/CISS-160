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
 * Date: September 12, 2020
 * Goal: To create a program that allows the user to compare the cost of attending one college
 *       versus attending another college. It compares the cost of 2 colleges at a time. 
 *       It takes into account the cost of Tuition, Housing, and cost of gas for 4 years, 
 *       including the one time application fee to apply to the college.
 *       I included a reset button so program can be used multiple times without closing.
*/




namespace CollegeCostComparison___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      //Assuming $2.50 per gallon of fuel purchased.
      private static decimal fuelCost = 2.50m;
      private static int milesPerGallon = 25;

      public Form1()
      {
         InitializeComponent();
      }


      private void calculate_Button_Click(object sender, EventArgs e)
      {
         //Reset the background collor for calculation results for program reuse.
         college1_Result4yr.BackColor = Color.White;
         college2_Result4yr.BackColor = Color.White;


         //Calculate number of miles driven to colleges per year
         //Using decimal because distance may not be a whole number, and will need to 
         //calculate cost accurately later.
         decimal college1_Miles = decimal.Parse(college1_Trips.Text) * decimal.Parse(college1_Distance.Text);
         decimal college2_Miles = decimal.Parse(college2_Trips.Text) * decimal.Parse(college2_Distance.Text);

         //Calculate number of gallons used travelling to colleged
         //Number of miles per gallon assumed to be 25.
         decimal college1_Gallons = college1_Miles / milesPerGallon;
         decimal college2_Gallons = college2_Miles / milesPerGallon;

         //Calculate cost of gas for each college.
         decimal college1_GasCost = college1_Gallons * fuelCost;
         decimal college2_GasCost = college2_Gallons * fuelCost;

         //Test: Display gas / year cost in college 1 year total labels to verify calculations
         //Realized I am supposed to show ONLY fuel cost for 1 year, so I am using this code in production.
         college1_Result1yr.Text = college1_GasCost.ToString("c");
         college2_Result1yr.Text = college2_GasCost.ToString("c");



         //Calculate total cost of attending colleges for 1 year.
         //I removed the following lines because I realized I did not need them. Kept for reference.

         //decimal college1_TotalCost1yr = college1_GasCost + decimal.Parse(college1_Fee.Text) + 
         //            decimal.Parse(college1_RoomBoard.Text) + decimal.Parse(college1_Tuition.Text);

         //decimal college2_TotalCost1yr = college2_GasCost + decimal.Parse(college2_Fee.Text) +
         //            decimal.Parse(college2_RoomBoard.Text) + decimal.Parse(college2_Tuition.Text);


         //Display the 1 year calculation results. See above as to why this is commented out.
         //college1_Result1yr.Text = college1_TotalCost1yr.ToString("C");
         //college2_Result1yr.Text = college2_TotalCost1yr.ToString("C");



         //Calculate total cost of attending colleges for 4 years
         decimal college1_TotalCost4yr = 4 * ( college1_GasCost + decimal.Parse(college1_RoomBoard.Text) 
                     + decimal.Parse(college1_Tuition.Text) ) + decimal.Parse(college1_Fee.Text);

         decimal college2_TotalCost4yr = 4 * ( college2_GasCost + decimal.Parse(college2_RoomBoard.Text)
                     + decimal.Parse(college2_Tuition.Text)) + decimal.Parse(college2_Fee.Text);


         //Display the 4 year calculation results
         college1_Result4yr.Text = college1_TotalCost4yr.ToString("C");
         college2_Result4yr.Text = college2_TotalCost4yr.ToString("C");

         if(college1_TotalCost4yr > college2_TotalCost4yr)
         {
            college1_Result4yr.BackColor = Color.Red;
         }
         else
         {
            college2_Result4yr.BackColor = Color.Red;
         }

      }


      private void clearButton_Click(object sender, EventArgs e)
      {
         //This method clears the form data so it can be used multiple times.
         //Clears any data in the College 1 text boxes.
         college1_Name.Text = "";
         college1_State.Text = "";
         college1_Trips.Text = "";
         college1_Distance.Text = "";
         college1_Fee.Text = "";
         college1_Tuition.Text = "";
         college1_RoomBoard.Text = "";
         college1_Result1yr.Text = "";
         college1_Result4yr.Text = "";

         //Clears any data in the College 2 text boxes
         college2_Name.Text = "";
         college2_State.Text = "";
         college2_Trips.Text = "";
         college2_Distance.Text = "";
         college2_Fee.Text = "";
         college2_Tuition.Text = "";
         college2_RoomBoard.Text = "";
         college2_Result1yr.Text = "";
         college2_Result4yr.Text = "";

         //Reset the calculation results background color.
         college1_Result4yr.BackColor = Color.White;
         college2_Result4yr.BackColor = Color.White;

      }

   }
}
