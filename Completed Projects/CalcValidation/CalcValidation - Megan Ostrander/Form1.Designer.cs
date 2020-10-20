namespace CalcValidation___Megan_Ostrander
{
   partial class Form1
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.calculateButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.beginningOdometer_Box = new System.Windows.Forms.TextBox();
         this.endingOdometer_Box = new System.Windows.Forms.TextBox();
         this.gallonsFilled_Box = new System.Windows.Forms.TextBox();
         this.gasPrice_Box = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.milesTraveled = new System.Windows.Forms.Label();
         this.milesPerGallon = new System.Windows.Forms.Label();
         this.gasCost = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(32, 93);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(212, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Stop #1 Odometer Reading: ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(32, 147);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(212, 20);
         this.label2.TabIndex = 1;
         this.label2.Text = "Stop #2 Odometer Reading: ";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(32, 190);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(227, 20);
         this.label3.TabIndex = 2;
         this.label3.Text = "Gallons Needed to Refill Tank: ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(32, 231);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(102, 20);
         this.label4.TabIndex = 3;
         this.label4.Text = "Cost of Gas: ";
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(116, 469);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(170, 39);
         this.calculateButton.TabIndex = 4;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.UseVisualStyleBackColor = true;
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(143, 514);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(116, 39);
         this.clearButton.TabIndex = 5;
         this.clearButton.Text = "Clear";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // beginningOdometer_Box
         // 
         this.beginningOdometer_Box.Location = new System.Drawing.Point(265, 90);
         this.beginningOdometer_Box.Name = "beginningOdometer_Box";
         this.beginningOdometer_Box.Size = new System.Drawing.Size(127, 26);
         this.beginningOdometer_Box.TabIndex = 6;
         // 
         // endingOdometer_Box
         // 
         this.endingOdometer_Box.Location = new System.Drawing.Point(265, 141);
         this.endingOdometer_Box.Name = "endingOdometer_Box";
         this.endingOdometer_Box.Size = new System.Drawing.Size(127, 26);
         this.endingOdometer_Box.TabIndex = 7;
         // 
         // gallonsFilled_Box
         // 
         this.gallonsFilled_Box.Location = new System.Drawing.Point(265, 184);
         this.gallonsFilled_Box.Name = "gallonsFilled_Box";
         this.gallonsFilled_Box.Size = new System.Drawing.Size(127, 26);
         this.gallonsFilled_Box.TabIndex = 8;
         // 
         // gasPrice_Box
         // 
         this.gasPrice_Box.Location = new System.Drawing.Point(265, 225);
         this.gasPrice_Box.Name = "gasPrice_Box";
         this.gasPrice_Box.Size = new System.Drawing.Size(127, 26);
         this.gasPrice_Box.TabIndex = 9;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(32, 328);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(156, 20);
         this.label5.TabIndex = 10;
         this.label5.Text = "Total Miles Traveled: ";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(32, 379);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(131, 20);
         this.label6.TabIndex = 11;
         this.label6.Text = "Miles Per Gallon: ";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(32, 422);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(142, 20);
         this.label7.TabIndex = 12;
         this.label7.Text = "Total Cost of Refill:";
         // 
         // milesTraveled
         // 
         this.milesTraveled.AutoSize = true;
         this.milesTraveled.Location = new System.Drawing.Point(261, 328);
         this.milesTraveled.Name = "milesTraveled";
         this.milesTraveled.Size = new System.Drawing.Size(0, 20);
         this.milesTraveled.TabIndex = 13;
         // 
         // milesPerGallon
         // 
         this.milesPerGallon.AutoSize = true;
         this.milesPerGallon.Location = new System.Drawing.Point(261, 379);
         this.milesPerGallon.Name = "milesPerGallon";
         this.milesPerGallon.Size = new System.Drawing.Size(0, 20);
         this.milesPerGallon.TabIndex = 14;
         // 
         // gasCost
         // 
         this.gasCost.AutoSize = true;
         this.gasCost.Location = new System.Drawing.Point(261, 422);
         this.gasCost.Name = "gasCost";
         this.gasCost.Size = new System.Drawing.Size(0, 20);
         this.gasCost.TabIndex = 15;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(414, 573);
         this.Controls.Add(this.gasCost);
         this.Controls.Add(this.milesPerGallon);
         this.Controls.Add(this.milesTraveled);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.gasPrice_Box);
         this.Controls.Add(this.gallonsFilled_Box);
         this.Controls.Add(this.endingOdometer_Box);
         this.Controls.Add(this.beginningOdometer_Box);
         this.Controls.Add(this.clearButton);
         this.Controls.Add(this.calculateButton);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button calculateButton;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.TextBox beginningOdometer_Box;
      private System.Windows.Forms.TextBox endingOdometer_Box;
      private System.Windows.Forms.TextBox gallonsFilled_Box;
      private System.Windows.Forms.TextBox gasPrice_Box;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label milesTraveled;
      private System.Windows.Forms.Label milesPerGallon;
      private System.Windows.Forms.Label gasCost;
   }
}

