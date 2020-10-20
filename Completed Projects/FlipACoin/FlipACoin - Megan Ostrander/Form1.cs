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
 * Date: September 6, 2020
 * Goal: To create a program that randomly flips a "coin" and shows the corresponding side of 
 *       coin on the screen. In this case, if the program generates a 0, then the "coin" landed
 *       on Heads, and if it generates a 1 it landed on Tails.
*/

namespace FlipACoin___Megan_Ostrander
{
   public partial class FlipACoin : Form
   {
      // Initializes a random generator for generating random numbers.
      Random rand = new Random();

      public FlipACoin()
      {
         InitializeComponent();

         // Initializes program with the images of the coin sides hidden on screen.
         coinHeads.Visible = false;
         coinTails.Visible = false;
      }

      private void coinFlipButton_Click(object sender, EventArgs e)
      {
         /* When the user clicks on this button, the program automatically picks a 
          * number (either 0 or 1), and then displays the corresponding coin side.
          * It also locks the button so it cannot be pressed again until user clicks 
          * on the Clear button.
         */

         // Assigns 0 or 1 randomly to the flip variable.
         int flip = rand.Next(2);

         // For testing that the random number generator works and only produces 0 & 1.
         // flipTestLabel.Visible = true;
         // flipTestLabel.Text = flip.ToString();

         // If the result of the random coin flip is 0, display the heads side of coin.
         if (flip == 0)
         {
            coinHeads.Visible = true;
         }

         // If the result of the random coin flip is 1, display tails side of coin.
         if (flip == 1)
         {
            coinTails.Visible = true;
         }


         // Disables the Flip A Coin button after it has been clicked.
         coinFlipButton.Enabled = false;
      }

      private void clearButton_Click(object sender, EventArgs e)
      {
         // Clears the image of the coin and resets the program to flip coin again.

         // Hides the coin side images on screen.
         coinHeads.Visible = false;
         coinTails.Visible = false;

         // Re-enables the Flip a Coin button for next coin flip. 
         coinFlipButton.Enabled = true;
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
         // Closes the program when the user clicks on the Exit button.

         this.Close();
      }
   }
}
