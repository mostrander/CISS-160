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
 * Goal: To take user input of a purchase they made or plan to make, calculate the total tax, 
 *       and calculate the total amount with user paid or will pay for the purchase. Based on
 *       the current Lorain county sales tax rate.
*/



namespace SalesTaxCalc___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      //Creates an instance of the tax rate variable to be used while
      //program is running. This also allows it to be changed once if needed.
      private decimal taxRate = .0675m;

      public Form1()
      {
         InitializeComponent();
      }

      private void calculateCost_Button_Click(object sender, EventArgs e)
      {
         //Variables to hold calculation results
         decimal tax_Amount;
         decimal cost_Total;
         decimal purchaseCost = decimal.Parse(userCost_Input.Text);

         //Take user input and calculate tax owed on purchase
         tax_Amount = purchaseCost * taxRate;
         cost_Total = purchaseCost + tax_Amount;

         //Display the information on screen for user to view
         taxCalculated_Box.Text = tax_Amount.ToString("C");
         totalCost_Box.Text = cost_Total.ToString("C");
      }

      private void clearButton_Click(object sender, EventArgs e)
      {
         //Resets all of the information back to the default settings
         //Erases all of the input and calculations, basically.
         userCost_Input.Text = "0";
         taxCalculated_Box.Text = "";
         totalCost_Box.Text = "";
        
      }
   }
}
