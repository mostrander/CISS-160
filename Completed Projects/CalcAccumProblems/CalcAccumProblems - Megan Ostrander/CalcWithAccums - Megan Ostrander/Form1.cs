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
 * Goal: To calculate the amount of cubic yards of mulch being ordered by user based on the user input 
 *       for the amount of mulch purchased in feet (height, width, length). Calculate the price of 
 *       the current mulch order, as well as maintain a running total of mulch orders and calculate 
 *       the amount of truck capacity left after each order is "placed".
*/


namespace CalcWithAccums___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      //Create variables to hold constant information that will not change during the program.
      private static int cubicYardConversion = 27;
      private static decimal pricePerYard = 17.00m;


      //Create variable for constant truck capacity value, will not change during program.
      //Capacity is in cubic yards.
      private static double truckCapacity = 4.00;


      //Create variables to hold running totals while program is running, until user using Clear button.
      double totalFeetOrdered = 0;
      double totalYardsOrdered = 0;
      decimal totalOrdersCost = 0m;
      int orders = 0; //For total number of orders made
      double capacityRemaining = 4.00; //Matches truckCapacity by default.


      public Form1()
      {
         InitializeComponent();
      }

      private void calculateButton_Click(object sender, EventArgs e)
      {
         //Update the priceLabel with the static price variable.
         priceLabel.Text = "@ " + pricePerYard.ToString("C") +" Price";

         //Take the user's input and calculate the total feet and yards.
         double feet = double.Parse(lengthFeetBox.Text) * double.Parse(widthFeetBox.Text) 
                           * double.Parse(heightFeetBox.Text);

         double yards = feet / cubicYardConversion;

         cubicFeetBox.Text = feet.ToString("N");
         cubicYardsBox.Text = yards.ToString("N");

         //Calculate the price of the current order. yards * pricePerYards
         decimal price = (decimal)yards * pricePerYard;
         priceBox.Text = price.ToString("C");

         //Update the total orders section with the new order information.
         orders += 1; 
         totalFeetOrdered += feet;
         totalYardsOrdered += yards;
         totalOrdersCost += price;

         //Display the updated total order section with the updated information.
         cubicFeetAll_Box.Text = totalFeetOrdered.ToString("N");
         cubicYardsAll_Box.Text = totalYardsOrdered.ToString("N");
         costTotal_Box.Text = totalOrdersCost.ToString("C");
         totalOrders_Box.Text = orders.ToString();

         //Display total cubic yards ordered and remaining truck capacity.
         emptyTruckCapacity_Box.Text = truckCapacity.ToString("N");
         orderedYards_Box.Text = totalYardsOrdered.ToString("N");

         capacityRemaining = capacityRemaining - yards;
         truckCapacityLeft_Box.Text = capacityRemaining.ToString("N");


         //Determine if there is still capacity left in the truck.
         //If yes, color the capacityLeft box background blue. If no, color red.

         if(double.Parse(truckCapacityLeft_Box.Text) > 0 )
         {
            truckCapacityLeft_Box.BackColor = Color.LightBlue;
         }
         if (double.Parse(truckCapacityLeft_Box.Text) <= 0)
         {
            truckCapacityLeft_Box.BackColor = Color.Red;
         }

      }

      private void clearButton_Click(object sender, EventArgs e)
      {
         //Clear the running totals so they all equal zero.
         orders = 0; 
         totalFeetOrdered = 0;
         totalYardsOrdered = 0;
         totalOrdersCost = 0m;
         capacityRemaining = 0.00;

         //Clear the current order section boxes to remove information when button is clicked.
         cubicFeetBox.Text = "";
         cubicYardsBox.Text = "";
         priceBox.Text = "";

         //Clear the total order section boxes to remove information when button is clicked.
         cubicFeetAll_Box.Text = "";
         cubicYardsAll_Box.Text = "";
         costTotal_Box.Text = "";
         totalOrders_Box.Text = "";

         //Clear the user input boxes for height, width, and length.
         lengthFeetBox.Text = "";
         widthFeetBox.Text = "";
         heightFeetBox.Text = "";

         //Clear the truck capacity, total cubic yards ordered, and remaining capacity fields.
         emptyTruckCapacity_Box.Text = "";
         orderedYards_Box.Text = "";
         truckCapacityLeft_Box.Text = "";

         //Reset the background color for the truckCapacityLeft_Box.
         truckCapacityLeft_Box.BackColor = Color.White;
      }
   }
}
