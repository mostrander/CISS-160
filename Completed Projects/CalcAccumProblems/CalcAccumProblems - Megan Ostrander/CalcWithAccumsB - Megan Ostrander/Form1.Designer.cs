namespace CalcWithAccumsB___Megan_Ostrander
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
         this.totalCost_Box = new System.Windows.Forms.TextBox();
         this.taxCalculated_Box = new System.Windows.Forms.TextBox();
         this.userCost_Input = new System.Windows.Forms.TextBox();
         this.clearButton = new System.Windows.Forms.Button();
         this.calculateCost_Button = new System.Windows.Forms.Button();
         this.totalCostLabel = new System.Windows.Forms.Label();
         this.salesTaxLabel = new System.Windows.Forms.Label();
         this.salesEnterLabel = new System.Windows.Forms.Label();
         this.totalSalesBox = new System.Windows.Forms.TextBox();
         this.total_ItemsBox = new System.Windows.Forms.TextBox();
         this.grandTotalBox = new System.Windows.Forms.TextBox();
         this.total_TaxBox = new System.Windows.Forms.TextBox();
         this.costPerItemBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // totalCost_Box
         // 
         this.totalCost_Box.BackColor = System.Drawing.Color.Aqua;
         this.totalCost_Box.Location = new System.Drawing.Point(27, 349);
         this.totalCost_Box.Multiline = true;
         this.totalCost_Box.Name = "totalCost_Box";
         this.totalCost_Box.ReadOnly = true;
         this.totalCost_Box.Size = new System.Drawing.Size(147, 59);
         this.totalCost_Box.TabIndex = 15;
         // 
         // taxCalculated_Box
         // 
         this.taxCalculated_Box.BackColor = System.Drawing.Color.Yellow;
         this.taxCalculated_Box.Location = new System.Drawing.Point(27, 208);
         this.taxCalculated_Box.Multiline = true;
         this.taxCalculated_Box.Name = "taxCalculated_Box";
         this.taxCalculated_Box.ReadOnly = true;
         this.taxCalculated_Box.Size = new System.Drawing.Size(147, 59);
         this.taxCalculated_Box.TabIndex = 14;
         // 
         // userCost_Input
         // 
         this.userCost_Input.ForeColor = System.Drawing.SystemColors.WindowText;
         this.userCost_Input.Location = new System.Drawing.Point(27, 105);
         this.userCost_Input.Name = "userCost_Input";
         this.userCost_Input.Size = new System.Drawing.Size(147, 26);
         this.userCost_Input.TabIndex = 13;
         this.userCost_Input.Text = "0";
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(221, 102);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(117, 34);
         this.clearButton.TabIndex = 12;
         this.clearButton.Text = "Clear";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // calculateCost_Button
         // 
         this.calculateCost_Button.Location = new System.Drawing.Point(221, 45);
         this.calculateCost_Button.Name = "calculateCost_Button";
         this.calculateCost_Button.Size = new System.Drawing.Size(117, 36);
         this.calculateCost_Button.TabIndex = 11;
         this.calculateCost_Button.Text = "Calculate";
         this.calculateCost_Button.UseVisualStyleBackColor = true;
         this.calculateCost_Button.Click += new System.EventHandler(this.calculateCost_Button_Click);
         // 
         // totalCostLabel
         // 
         this.totalCostLabel.Location = new System.Drawing.Point(23, 284);
         this.totalCostLabel.Name = "totalCostLabel";
         this.totalCostLabel.Size = new System.Drawing.Size(166, 49);
         this.totalCostLabel.TabIndex = 10;
         this.totalCostLabel.Text = "The Total Amount You Have to Pay is: ";
         this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // salesTaxLabel
         // 
         this.salesTaxLabel.Location = new System.Drawing.Point(23, 152);
         this.salesTaxLabel.Name = "salesTaxLabel";
         this.salesTaxLabel.Size = new System.Drawing.Size(166, 46);
         this.salesTaxLabel.TabIndex = 9;
         this.salesTaxLabel.Text = "Your Tax Amount is (@ 6.75%): ";
         this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // salesEnterLabel
         // 
         this.salesEnterLabel.Location = new System.Drawing.Point(23, 38);
         this.salesEnterLabel.Name = "salesEnterLabel";
         this.salesEnterLabel.Size = new System.Drawing.Size(153, 49);
         this.salesEnterLabel.TabIndex = 8;
         this.salesEnterLabel.Text = "Please Enter Sales Amount: ";
         this.salesEnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // totalSalesBox
         // 
         this.totalSalesBox.BackColor = System.Drawing.Color.Khaki;
         this.totalSalesBox.Location = new System.Drawing.Point(221, 187);
         this.totalSalesBox.Multiline = true;
         this.totalSalesBox.Name = "totalSalesBox";
         this.totalSalesBox.ReadOnly = true;
         this.totalSalesBox.Size = new System.Drawing.Size(133, 41);
         this.totalSalesBox.TabIndex = 16;
         // 
         // total_ItemsBox
         // 
         this.total_ItemsBox.BackColor = System.Drawing.Color.Khaki;
         this.total_ItemsBox.Location = new System.Drawing.Point(382, 226);
         this.total_ItemsBox.Multiline = true;
         this.total_ItemsBox.Name = "total_ItemsBox";
         this.total_ItemsBox.ReadOnly = true;
         this.total_ItemsBox.Size = new System.Drawing.Size(133, 41);
         this.total_ItemsBox.TabIndex = 17;
         // 
         // grandTotalBox
         // 
         this.grandTotalBox.BackColor = System.Drawing.Color.Khaki;
         this.grandTotalBox.Location = new System.Drawing.Point(221, 367);
         this.grandTotalBox.Multiline = true;
         this.grandTotalBox.Name = "grandTotalBox";
         this.grandTotalBox.ReadOnly = true;
         this.grandTotalBox.Size = new System.Drawing.Size(133, 41);
         this.grandTotalBox.TabIndex = 18;
         // 
         // total_TaxBox
         // 
         this.total_TaxBox.BackColor = System.Drawing.Color.Khaki;
         this.total_TaxBox.Location = new System.Drawing.Point(221, 269);
         this.total_TaxBox.Multiline = true;
         this.total_TaxBox.Name = "total_TaxBox";
         this.total_TaxBox.ReadOnly = true;
         this.total_TaxBox.Size = new System.Drawing.Size(133, 41);
         this.total_TaxBox.TabIndex = 19;
         // 
         // costPerItemBox
         // 
         this.costPerItemBox.BackColor = System.Drawing.Color.Khaki;
         this.costPerItemBox.Location = new System.Drawing.Point(382, 327);
         this.costPerItemBox.Multiline = true;
         this.costPerItemBox.Name = "costPerItemBox";
         this.costPerItemBox.ReadOnly = true;
         this.costPerItemBox.Size = new System.Drawing.Size(133, 41);
         this.costPerItemBox.TabIndex = 20;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(217, 164);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(137, 20);
         this.label1.TabIndex = 21;
         this.label1.Text = "Grand Total Sales";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(221, 244);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(122, 20);
         this.label2.TabIndex = 22;
         this.label2.Text = "Grand Total Tax";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(230, 324);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(113, 40);
         this.label3.TabIndex = 23;
         this.label3.Text = "Grand Total \r\nAmount to Pay";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(385, 203);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(124, 20);
         this.label4.TabIndex = 24;
         this.label4.Text = "Total Items Sold";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(383, 287);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(137, 40);
         this.label5.TabIndex = 25;
         this.label5.Text = "Average Cost Per \r\nItem (Before Tax)";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(535, 436);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.costPerItemBox);
         this.Controls.Add(this.total_TaxBox);
         this.Controls.Add(this.grandTotalBox);
         this.Controls.Add(this.total_ItemsBox);
         this.Controls.Add(this.totalSalesBox);
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

      private System.Windows.Forms.TextBox totalCost_Box;
      private System.Windows.Forms.TextBox taxCalculated_Box;
      private System.Windows.Forms.TextBox userCost_Input;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.Button calculateCost_Button;
      private System.Windows.Forms.Label totalCostLabel;
      private System.Windows.Forms.Label salesTaxLabel;
      private System.Windows.Forms.Label salesEnterLabel;
      private System.Windows.Forms.TextBox totalSalesBox;
      private System.Windows.Forms.TextBox total_ItemsBox;
      private System.Windows.Forms.TextBox grandTotalBox;
      private System.Windows.Forms.TextBox total_TaxBox;
      private System.Windows.Forms.TextBox costPerItemBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
   }
}

