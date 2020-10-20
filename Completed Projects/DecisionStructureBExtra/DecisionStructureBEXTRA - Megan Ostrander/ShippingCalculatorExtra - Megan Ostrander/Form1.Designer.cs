namespace ShippingCalculator___Megan_Ostrander
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
         this.weightBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.weight_Label = new System.Windows.Forms.Label();
         this.zone_Label = new System.Windows.Forms.Label();
         this.shipping_Label = new System.Windows.Forms.Label();
         this.netPound_Label = new System.Windows.Forms.Label();
         this.cap_Label = new System.Windows.Forms.Label();
         this.calculate_Button = new System.Windows.Forms.Button();
         this.clear_Button = new System.Windows.Forms.Button();
         this.radioButtonNorth = new System.Windows.Forms.RadioButton();
         this.radioButtonWest = new System.Windows.Forms.RadioButton();
         this.radioButtonEast = new System.Windows.Forms.RadioButton();
         this.radioButtonSouth = new System.Windows.Forms.RadioButton();
         this.SuspendLayout();
         // 
         // weightBox
         // 
         this.weightBox.Location = new System.Drawing.Point(160, 66);
         this.weightBox.Name = "weightBox";
         this.weightBox.Size = new System.Drawing.Size(102, 26);
         this.weightBox.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 69);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(125, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Package Weight";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(25, 107);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(112, 20);
         this.label2.TabIndex = 3;
         this.label2.Text = "Shipping Zone";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(41, 234);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(108, 20);
         this.label3.TabIndex = 4;
         this.label3.Text = "Weight Cost : ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(54, 271);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(95, 20);
         this.label4.TabIndex = 5;
         this.label4.Text = "Zone Cost : ";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(29, 340);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(120, 20);
         this.label5.TabIndex = 6;
         this.label5.Text = "Shipping Cost : ";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(25, 306);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(124, 20);
         this.label6.TabIndex = 7;
         this.label6.Text = "Net Per Pound : ";
         // 
         // weight_Label
         // 
         this.weight_Label.AutoSize = true;
         this.weight_Label.Location = new System.Drawing.Point(156, 234);
         this.weight_Label.Name = "weight_Label";
         this.weight_Label.Size = new System.Drawing.Size(18, 20);
         this.weight_Label.TabIndex = 8;
         this.weight_Label.Text = "0";
         // 
         // zone_Label
         // 
         this.zone_Label.AutoSize = true;
         this.zone_Label.Location = new System.Drawing.Point(156, 271);
         this.zone_Label.Name = "zone_Label";
         this.zone_Label.Size = new System.Drawing.Size(18, 20);
         this.zone_Label.TabIndex = 9;
         this.zone_Label.Text = "0";
         // 
         // shipping_Label
         // 
         this.shipping_Label.AutoSize = true;
         this.shipping_Label.Location = new System.Drawing.Point(156, 340);
         this.shipping_Label.Name = "shipping_Label";
         this.shipping_Label.Size = new System.Drawing.Size(18, 20);
         this.shipping_Label.TabIndex = 10;
         this.shipping_Label.Text = "0";
         // 
         // netPound_Label
         // 
         this.netPound_Label.AutoSize = true;
         this.netPound_Label.Location = new System.Drawing.Point(156, 306);
         this.netPound_Label.Name = "netPound_Label";
         this.netPound_Label.Size = new System.Drawing.Size(18, 20);
         this.netPound_Label.TabIndex = 11;
         this.netPound_Label.Text = "0";
         // 
         // cap_Label
         // 
         this.cap_Label.AutoSize = true;
         this.cap_Label.Location = new System.Drawing.Point(230, 340);
         this.cap_Label.Name = "cap_Label";
         this.cap_Label.Size = new System.Drawing.Size(74, 20);
         this.cap_Label.TabIndex = 12;
         this.cap_Label.Text = "CAPPED";
         this.cap_Label.Visible = false;
         // 
         // calculate_Button
         // 
         this.calculate_Button.Location = new System.Drawing.Point(105, 391);
         this.calculate_Button.Name = "calculate_Button";
         this.calculate_Button.Size = new System.Drawing.Size(129, 38);
         this.calculate_Button.TabIndex = 13;
         this.calculate_Button.Text = "Calculate";
         this.calculate_Button.UseVisualStyleBackColor = true;
         this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
         // 
         // clear_Button
         // 
         this.clear_Button.Location = new System.Drawing.Point(105, 442);
         this.clear_Button.Name = "clear_Button";
         this.clear_Button.Size = new System.Drawing.Size(129, 38);
         this.clear_Button.TabIndex = 14;
         this.clear_Button.Text = "Clear";
         this.clear_Button.UseVisualStyleBackColor = true;
         this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
         // 
         // radioButtonNorth
         // 
         this.radioButtonNorth.AutoSize = true;
         this.radioButtonNorth.Location = new System.Drawing.Point(161, 105);
         this.radioButtonNorth.Name = "radioButtonNorth";
         this.radioButtonNorth.Size = new System.Drawing.Size(73, 24);
         this.radioButtonNorth.TabIndex = 15;
         this.radioButtonNorth.TabStop = true;
         this.radioButtonNorth.Text = "North";
         this.radioButtonNorth.UseVisualStyleBackColor = true;
         // 
         // radioButtonWest
         // 
         this.radioButtonWest.AutoSize = true;
         this.radioButtonWest.Location = new System.Drawing.Point(160, 135);
         this.radioButtonWest.Name = "radioButtonWest";
         this.radioButtonWest.Size = new System.Drawing.Size(71, 24);
         this.radioButtonWest.TabIndex = 16;
         this.radioButtonWest.TabStop = true;
         this.radioButtonWest.Text = "West";
         this.radioButtonWest.UseVisualStyleBackColor = true;
         // 
         // radioButtonEast
         // 
         this.radioButtonEast.AutoSize = true;
         this.radioButtonEast.Location = new System.Drawing.Point(240, 105);
         this.radioButtonEast.Name = "radioButtonEast";
         this.radioButtonEast.Size = new System.Drawing.Size(67, 24);
         this.radioButtonEast.TabIndex = 17;
         this.radioButtonEast.TabStop = true;
         this.radioButtonEast.Text = "East";
         this.radioButtonEast.UseVisualStyleBackColor = true;
         // 
         // radioButtonSouth
         // 
         this.radioButtonSouth.AutoSize = true;
         this.radioButtonSouth.Location = new System.Drawing.Point(239, 135);
         this.radioButtonSouth.Name = "radioButtonSouth";
         this.radioButtonSouth.Size = new System.Drawing.Size(77, 24);
         this.radioButtonSouth.TabIndex = 18;
         this.radioButtonSouth.TabStop = true;
         this.radioButtonSouth.Text = "South";
         this.radioButtonSouth.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(344, 523);
         this.Controls.Add(this.radioButtonSouth);
         this.Controls.Add(this.radioButtonEast);
         this.Controls.Add(this.radioButtonWest);
         this.Controls.Add(this.radioButtonNorth);
         this.Controls.Add(this.clear_Button);
         this.Controls.Add(this.calculate_Button);
         this.Controls.Add(this.cap_Label);
         this.Controls.Add(this.netPound_Label);
         this.Controls.Add(this.shipping_Label);
         this.Controls.Add(this.zone_Label);
         this.Controls.Add(this.weight_Label);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.weightBox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox weightBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label weight_Label;
      private System.Windows.Forms.Label zone_Label;
      private System.Windows.Forms.Label shipping_Label;
      private System.Windows.Forms.Label netPound_Label;
      private System.Windows.Forms.Label cap_Label;
      private System.Windows.Forms.Button calculate_Button;
      private System.Windows.Forms.Button clear_Button;
      private System.Windows.Forms.RadioButton radioButtonNorth;
      private System.Windows.Forms.RadioButton radioButtonWest;
      private System.Windows.Forms.RadioButton radioButtonEast;
      private System.Windows.Forms.RadioButton radioButtonSouth;
   }
}

