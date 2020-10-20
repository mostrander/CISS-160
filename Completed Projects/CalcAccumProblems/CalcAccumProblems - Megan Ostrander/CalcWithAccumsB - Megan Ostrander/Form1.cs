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
 * Date: September 21, 2020
 * Goal: To take user input of a purchase they made or plan to make, calculate the total tax, 
 *       and calculate the total amount with user paid or will pay for the purchase. Based on
 *       the current Lorain county sales tax rate. This one includes additional fields for grand 
 *       totals and item count.
*/


namespace CalcWithAccumsB___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      //Creates an instance of the tax rate variable to be used while
      //program is running. This also allows it to be changed once if needed.
      private decimal taxRate = .0675m;
      private int items = 0;
      private decimal grandTotalSales = 0;
      private decimal grandTotalTax = 0;
      private decimal grandTotalPaid = 0;
      private decimal grandTotalAverage = 0;

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

         //Increase the number of items "purchased" each time the button is clicked.
         items = items + 1;

         //Take user input and calculate tax owed on purchase
         tax_Amount = purchaseCost * taxRate;
         cost_Total = purchaseCost + tax_Amount;

         //Calculate the grand totals
         grandTotalSales = grandTotalSales + purchaseCost;  //Total paid without tax
         grandTotalTax = grandTotalTax + tax_Amount;        //Total tax paid
         grandTotalPaid = grandTotalPaid + cost_Total;      //total with tax
         grandTotalAverage = grandTotalSales / items;       //before tax

         //Display the information on screen for user to view
         taxCalculated_Box.Text = tax_Amount.ToString("C");
         totalCost_Box.Text = cost_Total.ToString("C");

         //Display the grand totals and averages on screen
         totalSalesBox.Text = grandTotalSales.ToString("C");
         total_TaxBox.Text = grandTotalTax.ToString("C");
         grandTotalBox.Text = grandTotalPaid.ToString("C");
         costPerItemBox.Text = grandTotalAverage.ToString("C");

         //Display number of items purchased.
         total_ItemsBox.Text = items.ToString();
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
