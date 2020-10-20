namespace MathLibCircleInfo___Megan_Ostrander
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
         this.radiusBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.calculate_Button = new System.Windows.Forms.Button();
         this.diameterBox = new System.Windows.Forms.TextBox();
         this.circumferenceBox = new System.Windows.Forms.TextBox();
         this.areaBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // radiusBox
         // 
         this.radiusBox.Location = new System.Drawing.Point(21, 102);
         this.radiusBox.Multiline = true;
         this.radiusBox.Name = "radiusBox";
         this.radiusBox.Size = new System.Drawing.Size(160, 35);
         this.radiusBox.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(30, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(145, 40);
         this.label1.TabIndex = 1;
         this.label1.Text = "Please enter the \r\nradius of the circle: ";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // calculate_Button
         // 
         this.calculate_Button.Location = new System.Drawing.Point(216, 99);
         this.calculate_Button.Name = "calculate_Button";
         this.calculate_Button.Size = new System.Drawing.Size(149, 33);
         this.calculate_Button.TabIndex = 2;
         this.calculate_Button.Text = "Calculate";
         this.calculate_Button.UseVisualStyleBackColor = true;
         this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
         // 
         // diameterBox
         // 
         this.diameterBox.Location = new System.Drawing.Point(216, 164);
         this.diameterBox.Multiline = true;
         this.diameterBox.Name = "diameterBox";
         this.diameterBox.ReadOnly = true;
         this.diameterBox.Size = new System.Drawing.Size(148, 36);
         this.diameterBox.TabIndex = 3;
         // 
         // circumferenceBox
         // 
         this.circumferenceBox.Location = new System.Drawing.Point(216, 222);
         this.circumferenceBox.Multiline = true;
         this.circumferenceBox.Name = "circumferenceBox";
         this.circumferenceBox.ReadOnly = true;
         this.circumferenceBox.Size = new System.Drawing.Size(148, 35);
         this.circumferenceBox.TabIndex = 4;
         // 
         // areaBox
         // 
         this.areaBox.Location = new System.Drawing.Point(216, 282);
         this.areaBox.Multiline = true;
         this.areaBox.Name = "areaBox";
         this.areaBox.ReadOnly = true;
         this.areaBox.Size = new System.Drawing.Size(148, 35);
         this.areaBox.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(105, 169);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(82, 20);
         this.label2.TabIndex = 6;
         this.label2.Text = "Diameter: ";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(67, 226);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(120, 20);
         this.label3.TabIndex = 7;
         this.label3.Text = "Circumference: ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(136, 286);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(51, 20);
         this.label4.TabIndex = 8;
         this.label4.Text = "Area: ";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(389, 353);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.areaBox);
         this.Controls.Add(this.circumferenceBox);
         this.Controls.Add(this.diameterBox);
         this.Controls.Add(this.calculate_Button);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.radiusBox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox radiusBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button calculate_Button;
      private System.Windows.Forms.TextBox diameterBox;
      private System.Windows.Forms.TextBox circumferenceBox;
      private System.Windows.Forms.TextBox areaBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}

