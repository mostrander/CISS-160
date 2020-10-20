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
 * Goal: To display several playing cards on the screen, that when clicked on the program produces the name
 *       of the card at the bottom of the screen for the user. 
*/


namespace CardIdentifier___Megan_Ostrander
{
   public partial class CardIdentifier : Form
   {
      public CardIdentifier()
      {
         InitializeComponent();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {
         // First card listed in the 3 of Hearts.
         // Sets the text of the cardOutput label to that of the card name, displays on screen.

         cardOutput.Text = "3 of Hearts";
      }

      private void pictureBox2_Click(object sender, EventArgs e)
      {
         // Second card listed is the Ace of Clubs.

         cardOutput.Text = "Ace of Clubs";
      }

      private void pictureBox3_Click(object sender, EventArgs e)
      {
         // Third card listed is the Ace of Diamonds. 

         cardOutput.Text = "Ace of Diamonds";
      }

      private void pictureBox4_Click(object sender, EventArgs e)
      {
         //Fourth card listed is the 7 of Clubs.

         cardOutput.Text = "7 of Clubs";
      }

      private void pictureBox5_Click(object sender, EventArgs e)
      {
         //Fifth card listed is the King of Spades.

         cardOutput.Text = "King of Spades";
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
         //Closes the program when the button is pressed by the user.

         this.Close();
      }
   }
}
