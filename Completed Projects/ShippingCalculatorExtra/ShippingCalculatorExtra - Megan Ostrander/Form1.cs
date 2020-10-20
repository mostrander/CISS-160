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
 * Date: October 10, 2020
 * Goal: Modified version of the Shipping Calculator project. To take user input for package weight and shipping zone code, 
 *       and use that information to calculate the total shipping cost of the package, and cap the cost at $100 if it costs more than
 *       that to ship the package. 
*/


namespace ShippingCalculator___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void calculate_Button_Click(object sender, EventArgs e)
      {
         //Ensure that the CAPPED message does not appear on subsequent clicks of this button
         cap_Label.Visible = false;

         //Variables created to hold data during program
         String zone = null;                        //To hold user input for specified shipping zone.
                                             //Will be set based on radio buttons
         double weight = 0;                  //To hold weight of package.
         decimal weightCostTotal = 0.0m;     //Holds cost of package weight for shipping.
         decimal shippingCost = 0.0m;        //Holds final shipping cost.

         //Variables for zone shipping costs so they can be changed easily in one location.
         decimal weightCost = 18.0m;         //Cost per pound to ship package
         decimal zoneN_Cost = 27.0m;         //North zone.
         decimal zoneS_Cost = 36.0m;         //South zone.
         decimal zoneE_Cost = 45.0m;         //East zone.
         decimal zoneW_Cost = 54.0m;         //West zone.
         decimal netPoundPrice = 0.0m;

         //Verify that Radio buttons are selected before proceeding.
         zone = shippingZone(zone);


         //First, validate that the weightBox field and shipping zone field is not 
         //empty and contains valid numeric data
         if (!String.IsNullOrEmpty(weightBox.Text))
         {
            //Verify that weightBox field contains valid numeric data
            if(double.TryParse(weightBox.Text, out weight))
            {
               //Verify that zone variable is not null. User has selected a shipping zone.
               if (zone != null)
               {
                  //Calculate the cost to ship the package based only on weight
                  weightCostTotal = (decimal)weight * weightCost;

                  //Determine cost of shipping based on Zone code entered.
                  //Added messageBoxes to test and make sure switch worked.
                  //If greater than $100 statement must be switch for each case or as an additional method to work. 
                  if(zone == "N")
                  {
                     //MessageBox.Show("Adding zone N charge!");
                     shippingCost = weightCostTotal + zoneN_Cost;

                     //Test of additional method created to hold above if statement.
                     shippingCost = capped_Cost(shippingCost);  //It worked!

                     //Calculate the net price per pound
                     netPoundPrice = shippingCost / (decimal)weight;

                     //Display values on user screen
                     weight_Label.Text = weightCost.ToString("C");
                     netPound_Label.Text = netPoundPrice.ToString("C");
                     shipping_Label.Text = shippingCost.ToString("C");
                     zone_Label.Text = zoneN_Cost.ToString("C");
                  }
                  else if (zone == "S")
                  {
                     shippingCost = weightCostTotal + zoneS_Cost;

                     //MessageBox.Show("Shipping cost is now " + shippingCost.ToString("C"));
                     shippingCost = capped_Cost(shippingCost);

                     //Calculate the net price per pound
                     netPoundPrice = shippingCost / (decimal)weight;

                     //Display values on user screen
                     weight_Label.Text = weightCost.ToString("C");
                     netPound_Label.Text = netPoundPrice.ToString("C");
                     shipping_Label.Text = shippingCost.ToString("C");
                     zone_Label.Text = zoneS_Cost.ToString("C");
                  }
                  else if (zone == "E")
                  {
                     shippingCost = weightCostTotal + zoneE_Cost;

                     //MessageBox.Show("Shipping cost is now " + shippingCost.ToString("C"));
                     shippingCost = capped_Cost(shippingCost);

                     //Calculate the net price per pound
                     netPoundPrice = shippingCost / (decimal)weight;

                     //Display values on user screen
                     weight_Label.Text = weightCost.ToString("C");
                     netPound_Label.Text = netPoundPrice.ToString("C");
                     shipping_Label.Text = shippingCost.ToString("C");
                     zone_Label.Text = zoneE_Cost.ToString("C");
                  }
                  else if (zone == "W")
                  {
                     shippingCost = weightCostTotal + zoneW_Cost;

                     //MessageBox.Show("Shipping cost is now " + shippingCost.ToString("C"));
                     shippingCost = capped_Cost(shippingCost);

                     //Calculate the net price per pound
                     netPoundPrice = shippingCost / (decimal)weight;

                     //Display values on user screen
                     weight_Label.Text = weightCost.ToString("C");
                     netPound_Label.Text = netPoundPrice.ToString("C");
                     shipping_Label.Text = shippingCost.ToString("C");
                     zone_Label.Text = zoneW_Cost.ToString("C");
                  }


               }
               else
               {
                  MessageBox.Show("Please select one of the shipping zones.");
               }
            }
            else
            {
               //If weightbox does not contain a value numeric input
               MessageBox.Show("Please enter only a numeric value in the Package Weight field.");
            }
         }
         else
         {
            //If the weightBox field is null or does not contain a value
            if(String.IsNullOrEmpty(weightBox.Text))
            {
               MessageBox.Show("Please enter a numeric value in the package weight field.");
            }
            
         }
      }

      //Determine if shipping cost is above $100
      private decimal capped_Cost(decimal shippingCost)
      {
         if (shippingCost >= 100)
         {
            //Test message to inform you when it is over 100, to verify it is processed right
            //MessageBox.Show("Cost to ship package is over $100!");

            shippingCost = 100.00m;
            cap_Label.Visible = true;
         }

         return shippingCost;
      }

      //Determine Shipping zone based on radio button selected.
      private String shippingZone(String zone)
      {
         if (radioButtonNorth.Checked == true)
         {
            zone = "N"; // For North.
            return zone;
         }
         else if (radioButtonEast.Checked == true)
         {
            zone = "E"; // For East.
            return zone;
         }
         else if (radioButtonWest.Checked == true)
         {
            zone = "W"; // For West.
            return zone;
         }
         else if (radioButtonSouth.Checked == true)
         {
            zone = "S"; // For South.
            return zone;
         }
         else
         {
            MessageBox.Show("No shipping zone was selected.");
            return null;
         }
      }


      private void clear_Button_Click(object sender, EventArgs e)
      {
         //Clear the input fields
         weightBox.Text = "";

         //Reset all of the radio buttons to not selected.
         radioButtonNorth.Checked = false;
         radioButtonEast.Checked = false;
         radioButtonWest.Checked = false;
         radioButtonSouth.Checked = false;

         //Clear the display fields for values calculated.
         weight_Label.Text = "";
         netPound_Label.Text = "";
         shipping_Label.Text = "";
         zone_Label.Text = "";

         //Hide the cap Label so it is not visible until new calculate value is about $100
         cap_Label.Visible = false;

      }
   }
}
