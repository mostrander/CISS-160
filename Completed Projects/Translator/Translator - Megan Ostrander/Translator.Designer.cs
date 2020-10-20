namespace Translator___Megan_Ostrander
{
   partial class Translator
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
         this.translationLabel = new System.Windows.Forms.Label();
         this.morningButton = new System.Windows.Forms.Button();
         this.catButton = new System.Windows.Forms.Button();
         this.yesButton = new System.Windows.Forms.Button();
         this.fishButton = new System.Windows.Forms.Button();
         this.alcoholButton = new System.Windows.Forms.Button();
         this.sorryButton = new System.Windows.Forms.Button();
         this.translationOutput = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // translationLabel
         // 
         this.translationLabel.AutoSize = true;
         this.translationLabel.Location = new System.Drawing.Point(12, 34);
         this.translationLabel.Name = "translationLabel";
         this.translationLabel.Size = new System.Drawing.Size(151, 20);
         this.translationLabel.TabIndex = 0;
         this.translationLabel.Text = "English translation : ";
         // 
         // morningButton
         // 
         this.morningButton.Location = new System.Drawing.Point(16, 81);
         this.morningButton.Name = "morningButton";
         this.morningButton.Size = new System.Drawing.Size(109, 45);
         this.morningButton.TabIndex = 1;
         this.morningButton.Text = "Ohayoo";
         this.morningButton.UseVisualStyleBackColor = true;
         this.morningButton.Click += new System.EventHandler(this.morningButton_Click);
         // 
         // catButton
         // 
         this.catButton.Location = new System.Drawing.Point(142, 81);
         this.catButton.Name = "catButton";
         this.catButton.Size = new System.Drawing.Size(109, 45);
         this.catButton.TabIndex = 2;
         this.catButton.Text = "Neko";
         this.catButton.UseVisualStyleBackColor = true;
         this.catButton.Click += new System.EventHandler(this.catButton_Click);
         // 
         // yesButton
         // 
         this.yesButton.Location = new System.Drawing.Point(269, 81);
         this.yesButton.Name = "yesButton";
         this.yesButton.Size = new System.Drawing.Size(109, 45);
         this.yesButton.TabIndex = 3;
         this.yesButton.Text = "Hai";
         this.yesButton.UseVisualStyleBackColor = true;
         this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
         // 
         // fishButton
         // 
         this.fishButton.Location = new System.Drawing.Point(16, 142);
         this.fishButton.Name = "fishButton";
         this.fishButton.Size = new System.Drawing.Size(109, 45);
         this.fishButton.TabIndex = 4;
         this.fishButton.Text = "Sakana";
         this.fishButton.UseVisualStyleBackColor = true;
         this.fishButton.Click += new System.EventHandler(this.fishButton_Click);
         // 
         // alcoholButton
         // 
         this.alcoholButton.Location = new System.Drawing.Point(142, 142);
         this.alcoholButton.Name = "alcoholButton";
         this.alcoholButton.Size = new System.Drawing.Size(109, 45);
         this.alcoholButton.TabIndex = 5;
         this.alcoholButton.Text = "Sake";
         this.alcoholButton.UseVisualStyleBackColor = true;
         this.alcoholButton.Click += new System.EventHandler(this.alcoholButton_Click);
         // 
         // sorryButton
         // 
         this.sorryButton.Location = new System.Drawing.Point(269, 142);
         this.sorryButton.Name = "sorryButton";
         this.sorryButton.Size = new System.Drawing.Size(109, 45);
         this.sorryButton.TabIndex = 6;
         this.sorryButton.Text = "Gomenasai";
         this.sorryButton.UseVisualStyleBackColor = true;
         this.sorryButton.Click += new System.EventHandler(this.sorryButton_Click);
         // 
         // translationOutput
         // 
         this.translationOutput.AutoSize = true;
         this.translationOutput.Location = new System.Drawing.Point(167, 34);
         this.translationOutput.Name = "translationOutput";
         this.translationOutput.Size = new System.Drawing.Size(0, 20);
         this.translationOutput.TabIndex = 7;
         // 
         // Translator
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(391, 201);
         this.Controls.Add(this.translationOutput);
         this.Controls.Add(this.sorryButton);
         this.Controls.Add(this.alcoholButton);
         this.Controls.Add(this.fishButton);
         this.Controls.Add(this.yesButton);
         this.Controls.Add(this.catButton);
         this.Controls.Add(this.morningButton);
         this.Controls.Add(this.translationLabel);
         this.Name = "Translator";
         this.Text = "Japanese Translator";
         this.Load += new System.EventHandler(this.Translator_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label translationLabel;
      private System.Windows.Forms.Button morningButton;
      private System.Windows.Forms.Button catButton;
      private System.Windows.Forms.Button yesButton;
      private System.Windows.Forms.Button fishButton;
      private System.Windows.Forms.Button alcoholButton;
      private System.Windows.Forms.Button sorryButton;
      private System.Windows.Forms.Label translationOutput;
   }
}

