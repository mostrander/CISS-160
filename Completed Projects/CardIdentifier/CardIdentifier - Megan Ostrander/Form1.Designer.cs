namespace CardIdentifier___Megan_Ostrander
{
   partial class CardIdentifier
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardIdentifier));
         this.label1 = new System.Windows.Forms.Label();
         this.card3Hearts = new System.Windows.Forms.PictureBox();
         this.cardAceClubs = new System.Windows.Forms.PictureBox();
         this.cardAceDiamonds = new System.Windows.Forms.PictureBox();
         this.card7Clubs = new System.Windows.Forms.PictureBox();
         this.cardKingSpades = new System.Windows.Forms.PictureBox();
         this.cardOutput = new System.Windows.Forms.Label();
         this.exitButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.card3Hearts)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardAceClubs)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardAceDiamonds)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.card7Clubs)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardKingSpades)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(166, 28);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(212, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Click a Card to See Its Name";
         // 
         // card3Hearts
         // 
         this.card3Hearts.Image = ((System.Drawing.Image)(resources.GetObject("card3Hearts.Image")));
         this.card3Hearts.Location = new System.Drawing.Point(21, 65);
         this.card3Hearts.Name = "card3Hearts";
         this.card3Hearts.Size = new System.Drawing.Size(83, 113);
         this.card3Hearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.card3Hearts.TabIndex = 1;
         this.card3Hearts.TabStop = false;
         this.card3Hearts.Click += new System.EventHandler(this.pictureBox1_Click);
         // 
         // cardAceClubs
         // 
         this.cardAceClubs.Image = ((System.Drawing.Image)(resources.GetObject("cardAceClubs.Image")));
         this.cardAceClubs.Location = new System.Drawing.Point(126, 65);
         this.cardAceClubs.Name = "cardAceClubs";
         this.cardAceClubs.Size = new System.Drawing.Size(83, 113);
         this.cardAceClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.cardAceClubs.TabIndex = 2;
         this.cardAceClubs.TabStop = false;
         this.cardAceClubs.Click += new System.EventHandler(this.pictureBox2_Click);
         // 
         // cardAceDiamonds
         // 
         this.cardAceDiamonds.Image = ((System.Drawing.Image)(resources.GetObject("cardAceDiamonds.Image")));
         this.cardAceDiamonds.Location = new System.Drawing.Point(233, 65);
         this.cardAceDiamonds.Name = "cardAceDiamonds";
         this.cardAceDiamonds.Size = new System.Drawing.Size(83, 113);
         this.cardAceDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.cardAceDiamonds.TabIndex = 3;
         this.cardAceDiamonds.TabStop = false;
         this.cardAceDiamonds.Click += new System.EventHandler(this.pictureBox3_Click);
         // 
         // card7Clubs
         // 
         this.card7Clubs.Image = ((System.Drawing.Image)(resources.GetObject("card7Clubs.Image")));
         this.card7Clubs.Location = new System.Drawing.Point(339, 65);
         this.card7Clubs.Name = "card7Clubs";
         this.card7Clubs.Size = new System.Drawing.Size(83, 113);
         this.card7Clubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.card7Clubs.TabIndex = 4;
         this.card7Clubs.TabStop = false;
         this.card7Clubs.Click += new System.EventHandler(this.pictureBox4_Click);
         // 
         // cardKingSpades
         // 
         this.cardKingSpades.Image = ((System.Drawing.Image)(resources.GetObject("cardKingSpades.Image")));
         this.cardKingSpades.Location = new System.Drawing.Point(446, 65);
         this.cardKingSpades.Name = "cardKingSpades";
         this.cardKingSpades.Size = new System.Drawing.Size(83, 113);
         this.cardKingSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.cardKingSpades.TabIndex = 5;
         this.cardKingSpades.TabStop = false;
         this.cardKingSpades.Click += new System.EventHandler(this.pictureBox5_Click);
         // 
         // cardOutput
         // 
         this.cardOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.cardOutput.Location = new System.Drawing.Point(21, 203);
         this.cardOutput.Name = "cardOutput";
         this.cardOutput.Size = new System.Drawing.Size(508, 34);
         this.cardOutput.TabIndex = 6;
         this.cardOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // exitButton
         // 
         this.exitButton.Location = new System.Drawing.Point(203, 257);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(136, 37);
         this.exitButton.TabIndex = 7;
         this.exitButton.Text = "Exit";
         this.exitButton.UseVisualStyleBackColor = true;
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // CardIdentifier
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(552, 313);
         this.Controls.Add(this.exitButton);
         this.Controls.Add(this.cardOutput);
         this.Controls.Add(this.cardKingSpades);
         this.Controls.Add(this.card7Clubs);
         this.Controls.Add(this.cardAceDiamonds);
         this.Controls.Add(this.cardAceClubs);
         this.Controls.Add(this.card3Hearts);
         this.Controls.Add(this.label1);
         this.Name = "CardIdentifier";
         this.Text = "CardIdentifier";
         ((System.ComponentModel.ISupportInitialize)(this.card3Hearts)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardAceClubs)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardAceDiamonds)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.card7Clubs)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardKingSpades)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox card3Hearts;
      private System.Windows.Forms.PictureBox cardAceClubs;
      private System.Windows.Forms.PictureBox cardAceDiamonds;
      private System.Windows.Forms.PictureBox card7Clubs;
      private System.Windows.Forms.PictureBox cardKingSpades;
      private System.Windows.Forms.Label cardOutput;
      private System.Windows.Forms.Button exitButton;
   }
}

