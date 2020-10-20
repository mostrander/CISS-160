namespace MultiAndAccum___Megan_Ostrander
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
         this.calculateButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.number1_Box = new System.Windows.Forms.TextBox();
         this.number2_Box = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.runningTotal_Label = new System.Windows.Forms.Label();
         this.result_Label = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(161, 234);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(136, 33);
         this.calculateButton.TabIndex = 0;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.UseVisualStyleBackColor = true;
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(370, 234);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(129, 33);
         this.clearButton.TabIndex = 1;
         this.clearButton.Text = "Clear All";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // number1_Box
         // 
         this.number1_Box.Location = new System.Drawing.Point(46, 159);
         this.number1_Box.Name = "number1_Box";
         this.number1_Box.Size = new System.Drawing.Size(110, 26);
         this.number1_Box.TabIndex = 2;
         // 
         // number2_Box
         // 
         this.number2_Box.Location = new System.Drawing.Point(185, 159);
         this.number2_Box.Name = "number2_Box";
         this.number2_Box.Size = new System.Drawing.Size(110, 26);
         this.number2_Box.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(12, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(659, 44);
         this.label1.TabIndex = 6;
         this.label1.Text = "This Form will multiply the numbers entered into each of the two Text Boxes and d" +
    "isplay the Result in the Label below. It will also accumulate the Results.";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(467, 106);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(126, 50);
         this.label2.TabIndex = 7;
         this.label2.Text = "Running Total of Results So Far";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(61, 134);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(78, 20);
         this.label3.TabIndex = 8;
         this.label3.Text = "Number 1";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(200, 134);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(78, 20);
         this.label4.TabIndex = 9;
         this.label4.Text = "Number 2";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(352, 134);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(55, 20);
         this.label5.TabIndex = 10;
         this.label5.Text = "Result";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(160, 162);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(20, 20);
         this.label6.TabIndex = 11;
         this.label6.Text = "X";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(298, 162);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(18, 20);
         this.label7.TabIndex = 12;
         this.label7.Text = "=";
         // 
         // runningTotal_Label
         // 
         this.runningTotal_Label.BackColor = System.Drawing.Color.LightBlue;
         this.runningTotal_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.runningTotal_Label.Location = new System.Drawing.Point(467, 159);
         this.runningTotal_Label.Name = "runningTotal_Label";
         this.runningTotal_Label.Size = new System.Drawing.Size(126, 30);
         this.runningTotal_Label.TabIndex = 13;
         this.runningTotal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // result_Label
         // 
         this.result_Label.BackColor = System.Drawing.SystemColors.Control;
         this.result_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.result_Label.Location = new System.Drawing.Point(322, 159);
         this.result_Label.Name = "result_Label";
         this.result_Label.Size = new System.Drawing.Size(113, 30);
         this.result_Label.TabIndex = 14;
         this.result_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(677, 297);
         this.Controls.Add(this.result_Label);
         this.Controls.Add(this.runningTotal_Label);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.number2_Box);
         this.Controls.Add(this.number1_Box);
         this.Controls.Add(this.clearButton);
         this.Controls.Add(this.calculateButton);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button calculateButton;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.TextBox number1_Box;
      private System.Windows.Forms.TextBox number2_Box;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label runningTotal_Label;
      private System.Windows.Forms.Label result_Label;
   }
}

