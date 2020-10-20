namespace SalesTaxCalc___Megan_Ostrander
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
         this.salesEnterLabel = new System.Windows.Forms.Label();
         this.salesTaxLabel = new System.Windows.Forms.Label();
         this.totalCostLabel = new System.Windows.Forms.Label();
         this.calculateCost_Button = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.userCost_Input = new System.Windows.Forms.TextBox();
         this.taxCalculated_Box = new System.Windows.Forms.TextBox();
         this.totalCost_Box = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // salesEnterLabel
         // 
         this.salesEnterLabel.Location = new System.Drawing.Point(37, 30);
         this.salesEnterLabel.Name = "salesEnterLabel";
         this.salesEnterLabel.Size = new System.Drawing.Size(153, 49);
         this.salesEnterLabel.TabIndex = 0;
         this.salesEnterLabel.Text = "Please Enter Sales Amount: ";
         this.salesEnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // salesTaxLabel
         // 
         this.salesTaxLabel.Location = new System.Drawing.Point(37, 144);
         this.salesTaxLabel.Name = "salesTaxLabel";
         this.salesTaxLabel.Size = new System.Drawing.Size(166, 46);
         this.salesTaxLabel.TabIndex = 1;
         this.salesTaxLabel.Text = "Your Tax Amount is (@ 6.75%): ";
         this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // totalCostLabel
         // 
         this.totalCostLabel.Location = new System.Drawing.Point(37, 276);
         this.totalCostLabel.Name = "totalCostLabel";
         this.totalCostLabel.Size = new System.Drawing.Size(166, 49);
         this.totalCostLabel.TabIndex = 2;
         this.totalCostLabel.Text = "The Total Amount You Have to Pay is: ";
         this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // calculateCost_Button
         // 
         this.calculateCost_Button.Location = new System.Drawing.Point(224, 87);
         this.calculateCost_Button.Name = "calculateCost_Button";
         this.calculateCost_Button.Size = new System.Drawing.Size(117, 36);
         this.calculateCost_Button.TabIndex = 3;
         this.calculateCost_Button.Text = "Calculate";
         this.calculateCost_Button.UseVisualStyleBackColor = true;
         this.calculateCost_Button.Click += new System.EventHandler(this.calculateCost_Button_Click);
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(224, 144);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(117, 34);
         this.clearButton.TabIndex = 4;
         this.clearButton.Text = "Clear";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // userCost_Input
         // 
         this.userCost_Input.ForeColor = System.Drawing.SystemColors.WindowText;
         this.userCost_Input.Location = new System.Drawing.Point(41, 97);
         this.userCost_Input.Name = "userCost_Input";
         this.userCost_Input.Size = new System.Drawing.Size(147, 26);
         this.userCost_Input.TabIndex = 5;
         this.userCost_Input.Text = "0";
         // 
         // taxCalculated_Box
         // 
         this.taxCalculated_Box.BackColor = System.Drawing.Color.Yellow;
         this.taxCalculated_Box.Location = new System.Drawing.Point(41, 200);
         this.taxCalculated_Box.Multiline = true;
         this.taxCalculated_Box.Name = "taxCalculated_Box";
         this.taxCalculated_Box.ReadOnly = true;
         this.taxCalculated_Box.Size = new System.Drawing.Size(147, 59);
         this.taxCalculated_Box.TabIndex = 6;
         // 
         // totalCost_Box
         // 
         this.totalCost_Box.BackColor = System.Drawing.Color.Aqua;
         this.totalCost_Box.Location = new System.Drawing.Point(41, 341);
         this.totalCost_Box.Multiline = true;
         this.totalCost_Box.Name = "totalCost_Box";
         this.totalCost_Box.ReadOnly = true;
         this.totalCost_Box.Size = new System.Drawing.Size(147, 59);
         this.totalCost_Box.TabIndex = 7;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(366, 448);
         this.Controls.Add(this.totalCost_Box);
         this.Controls.Add(this.taxCalculated_Box);
         this.Controls.Add(this.userCost_Input);
         this.Controls.Add(this.clearButton);
         this.Controls.Add(this.calculateCost_Button);
         this.Controls.Add(this.totalCostLabel);
         this.Controls.Add(this.salesTaxLabel);
         this.Controls.Add(this.salesEnterLabel);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label salesEnterLabel;
      private System.Windows.Forms.Label salesTaxLabel;
      private System.Windows.Forms.Label totalCostLabel;
      private System.Windows.Forms.Button calculateCost_Button;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.TextBox userCost_Input;
      private System.Windows.Forms.TextBox taxCalculated_Box;
      private System.Windows.Forms.TextBox totalCost_Box;
   }
}

