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
 * Goal: To translate a group of individual words one one language into English, where each word
 *       is attached to a different button. When the button is pressed, the word listed on the 
 *       button is translated into english and displayed on the screen. I am using Japanese in 
 *       this program. 
*/


namespace Translator___Megan_Ostrander
{
   public partial class Translator : Form
   {
      public Translator()
      {
         InitializeComponent();
      }

      private void Translator_Load(object sender, EventArgs e)
      {

      }

      private void morningButton_Click(object sender, EventArgs e)
      {
         // Assign the translation of ohayoo to the output label, thus showing the translation to the user.
         // Ohayoo in Japanese means "good morning". It is a casual form of greeting.

         translationOutput.Text = "Good morning.";
      }

      private void catButton_Click(object sender, EventArgs e)
      {
         // Assign the translation of neko to the output label, thus showing the translation to the user.
         // Neko in Japanese means cat.

         translationOutput.Text = "Cat";
      }

      private void yesButton_Click(object sender, EventArgs e)
      {
         // Assign the translation of hai to the output label, thus showing the translation to the user.
         // Hai in Japanese means Yes.

         translationOutput.Text = "Yes.";
      }

      private void fishButton_Click(object sender, EventArgs e)
      {
         // Assign the translation of sakana to the output label, thus showing the translation to the user.
         // Sakana in Japanese means fish.

         translationOutput.Text = "Fish";
      }

      private void alcoholButton_Click(object sender, EventArgs e)
      {
         // Assign the translation of sake to the output label, thus showing the translation to the user.
         // Sake in Japanese means alcohol. It is also the name of an alcoholic drink.

         translationOutput.Text = "Alcohol";
      }

      private void sorryButton_Click(object sender, EventArgs e)
      {
         // Assign the translation of gomenasai to the output label, thus showing the translation to the user.
         // Gomenasai in Japanese means "I am sorry". 

         translationOutput.Text = "I am sorry.";
      }
   }
}
