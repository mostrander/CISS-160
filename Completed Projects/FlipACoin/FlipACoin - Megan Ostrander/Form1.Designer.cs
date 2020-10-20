namespace FlipACoin___Megan_Ostrander
{
   partial class FlipACoin
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlipACoin));
         this.coinHeads = new System.Windows.Forms.PictureBox();
         this.coinFlipButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.exitButton = new System.Windows.Forms.Button();
         this.coinTails = new System.Windows.Forms.PictureBox();
         this.flipTestLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.coinHeads)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.coinTails)).BeginInit();
         this.SuspendLayout();
         // 
         // coinHeads
         // 
         this.coinHeads.Image = ((System.Drawing.Image)(resources.GetObject("coinHeads.Image")));
         this.coinHeads.Location = new System.Drawing.Point(109, 23);
         this.coinHeads.Name = "coinHeads";
         this.coinHeads.Size = new System.Drawing.Size(211, 207);
         this.coinHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.coinHeads.TabIndex = 0;
         this.coinHeads.TabStop = false;
         this.coinHeads.Visible = false;
         // 
         // coinFlipButton
         // 
         this.coinFlipButton.Location = new System.Drawing.Point(20, 253);
         this.coinFlipButton.Name = "coinFlipButton";
         this.coinFlipButton.Size = new System.Drawing.Size(117, 49);
         this.coinFlipButton.TabIndex = 1;
         this.coinFlipButton.Text = "Flip A Coin";
         this.coinFlipButton.UseVisualStyleBackColor = true;
         this.coinFlipButton.Click += new System.EventHandler(this.coinFlipButton_Click);
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(151, 253);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(118, 49);
         this.clearButton.TabIndex = 2;
         this.clearButton.Text = "Clear";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // exitButton
         // 
         this.exitButton.Location = new System.Drawing.Point(283, 253);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(117, 49);
         this.exitButton.TabIndex = 3;
         this.exitButton.Text = "Exit";
         this.exitButton.UseVisualStyleBackColor = true;
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // coinTails
         // 
         this.coinTails.Image = ((System.Drawing.Image)(resources.GetObject("coinTails.Image")));
         this.coinTails.Location = new System.Drawing.Point(108, 24);
         this.coinTails.Name = "coinTails";
         this.coinTails.Size = new System.Drawing.Size(211, 207);
         this.coinTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.coinTails.TabIndex = 4;
         this.coinTails.TabStop = false;
         this.coinTails.Visible = false;
         // 
         // flipTestLabel
         // 
         this.flipTestLabel.AutoSize = true;
         this.flipTestLabel.Location = new System.Drawing.Point(20, 73);
         this.flipTestLabel.Name = "flipTestLabel";
         this.flipTestLabel.Size = new System.Drawing.Size(40, 20);
         this.flipTestLabel.TabIndex = 5;
         this.flipTestLabel.Text = "Test";
         this.flipTestLabel.Visible = false;
         // 
         // FlipACoin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(420, 318);
         this.Controls.Add(this.flipTestLabel);
         this.Controls.Add(this.exitButton);
         this.Controls.Add(this.clearButton);
         this.Controls.Add(this.coinFlipButton);
         this.Controls.Add(this.coinHeads);
         this.Controls.Add(this.coinTails);
         this.Name = "FlipACoin";
         this.Text = "Flip A Coin";
         ((System.ComponentModel.ISupportInitialize)(this.coinHeads)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.coinTails)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox coinHeads;
      private System.Windows.Forms.Button coinFlipButton;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.Button exitButton;
      private System.Windows.Forms.PictureBox coinTails;
      private System.Windows.Forms.Label flipTestLabel;
   }
}

