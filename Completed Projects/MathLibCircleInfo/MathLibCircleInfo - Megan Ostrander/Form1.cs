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
 * Date: September 27, 2020
 * Goal: To take user input for radius of a circle and use it to calculate the circumference, 
 *       diameter, and area of the circle. Uses a Try/Catch block to validate user input.
*/


namespace MathLibCircleInfo___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void calculate_Button_Click(object sender, EventArgs e)
      {
         //Use a Try/Catch block to take user input for radius and calculate diameter, circumference, and area.

         try
         {
            //Place user input into radius_iput variable. Parse information from radiusBox
            int radius_input = int.Parse(radiusBox.Text);

            //Calculate the diameter and store result. Radius * 2. Display result.
            double diameter_result = radius_input * 2;
            diameterBox.Text = diameter_result.ToString("N"); //So the decimal places are limited to 2

            //Calculate the circumference of the circle. 2 * pi * radius. Display result
            //Math.PI has the number in double format!
            double circumference_result = 2 * Math.PI * radius_input;
            circumferenceBox.Text = circumference_result.ToString("N");

            //Calculate the area of the circle. Pi * radius(squared). Display result.
            double area_result = Math.PI * Math.Pow(radius_input, 2.00);
            areaBox.Text = area_result.ToString("N");
            
         }
         catch
         {
            MessageBox.Show("Please only enter numbers for the radius.");
         }

      }
   }
}
