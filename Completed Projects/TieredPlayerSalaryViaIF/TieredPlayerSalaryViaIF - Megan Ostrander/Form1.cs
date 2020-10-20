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
 * Goal: To take user input for player name and number of hits. Then, take that input and calculate 
 *       what payment tier the player is in, how much they earned per hit based on the tier, calculate
 *       the player's salary, and show who the top player is out of all the player's entered. Clear
 *       button resets the program.
*/



namespace TieredPlayerSalaryViaIF___Megan_Ostrander
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      //Initialize variables for player leader amounts
      private String leaderName;               //Leader's name.
      private int leaderHits = 0;              //Leader's total number of hits.
      private int leaderTier = 0;              //Leader's tier ranking.
      private decimal leaderSalary = 0.0m;     //Leader's salary.

      //Variables for tier salary amounts, so they can be changed in one location. Salary * PER HIT!
      //Note: If amounts need to be changed just change the number prior to the decimal point.
      private static decimal tierSalary1 = 17500.0m;
      private static decimal tierSalary2 = 20000.0m;
      private static decimal tierSalary3 = 22500.0m;
      private static decimal tierSalary4 = 25000.0m;


      private void calculateButton_Click(object sender, EventArgs e)
      {

         //Initalize variables for use later.
         String playerName;            //To contain current player's name.
         int hits = 0;                 //To contain the number of hits for current player.
         int tier = 0;                 //To contain current player's tier level.
         decimal playerSalary = 0.0m;  //To contain current player's salary. 
         
         //Take user input and store in local variables. Validate the input is valid with If/Else statement
         //And TryParse method.

         //If player name field is not empty or null value, or does not contain spaces
         if(!String.IsNullOrEmpty(playerBox.Text) & !playerBox.Text.Contains(" ")) 
         {
            //Store the name in local variable.
            playerName = playerBox.Text;


            //Verify user input for number of hits. 
            if (int.TryParse(hitBox.Text, out hits))
            {
               if (hits > 0 & hits <= 300) //If the number of hits is between 1 and 300.
               {
                  //Proceed with calculations.
                  //Determine player's tier and calculate their base salary. highest to lowest tier.
                  if(hits >= 150)
                  {
                     tier = 4;
                     playerSalary = tierSalary4 * hits;
                  }
                  else if(hits >= 100 & hits < 150)
                  {
                     tier = 3;
                     playerSalary = tierSalary3 * hits;
                  }
                  else if(hits >= 50 & hits < 100)
                  {
                     tier = 2;
                     playerSalary = tierSalary2 * hits;
                  }
                  else
                  {
                     //Player hits are less than 50.
                     tier = 1;
                     playerSalary = tierSalary1 * hits;
                  }

                  //Calculate if player earned bonus for being MVP, All Star, or both.
                  if(mvp_checkBox.Checked == true & star_checkBox.Checked == true)
                  {
                     //If player was MVP and All Star, they get 25 % salary bonus
                     decimal percent = .25m;
                     playerSalary = playerSalary + (playerSalary * percent);

                  }
                  else if(mvp_checkBox.Checked == true || star_checkBox.Checked == true)
                  {
                     //Else, if the player was only MVP OR All Star, gets 20% salary bonus.
                     decimal percent = .20m;
                     playerSalary = playerSalary + (playerSalary * percent);

                  } //Otherwise, no bonus is added.

                  //Determine who the leader is based on number of hits.
                  if(hits > leaderHits)
                  {
                     leaderName = playerName;
                     leaderHits = hits;
                     leaderTier = tier;
                     leaderSalary = playerSalary;
                  }

               }
               else
               {
                  //Display an error message.
                  MessageBox.Show("Invalid entry. Number of hits must be 1 - 300.");
               }
            }
            else
            {
               //Display error message if input is not valid.
               MessageBox.Show("You must enter an interger value for Number of Hits.");
            }

         }
         else if(playerBox.Text.Contains(" "))
         {
            //Otherwise, display an error message.
            MessageBox.Show("Player name cannot contain spaces.");
         }
         else
         {
            //Otherwise, display an error message.
            MessageBox.Show("Please enter the name of the Player.");
         }


         //Display the player's tier number and salary earned.
         playerTierBox.Text = tier.ToString();
         playerSalaryBox.Text = playerSalary.ToString("C");

         //Display the leader player's information.
         leaderNameBox.Text = leaderName;
         leaderHitBox.Text = leaderHits.ToString();
         leaderTierBox.Text = leaderTier.ToString();
         leaderSalaryBox.Text = leaderSalary.ToString("C");
      }


      private void clearButton_Click(object sender, EventArgs e)
      {
         //Clear the leader stat variables.
         leaderName = "";
         leaderHits = 0;
         leaderTier = 0;
         leaderSalary = 0.0m;

         //Clear the entered player's fields.
         playerBox.Text = "";
         hitBox.Text = "";

         //Clear the player's tier number and salary earned boxes.
         playerTierBox.Text = "";
         playerSalaryBox.Text = "";

         //Clear the leader player's information boxes.
         leaderNameBox.Text = "";
         leaderHitBox.Text = "";
         leaderTierBox.Text = "";
         leaderSalaryBox.Text = "";
      }
   }
}
