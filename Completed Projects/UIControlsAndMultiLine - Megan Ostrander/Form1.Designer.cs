namespace UIControlsAndMultiLine___Megan_Ostrander
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
         this.radioVolt = new System.Windows.Forms.RadioButton();
         this.radioPinto = new System.Windows.Forms.RadioButton();
         this.roofBox = new System.Windows.Forms.CheckBox();
         this.playerBox = new System.Windows.Forms.CheckBox();
         this.gasTankBox = new System.Windows.Forms.CheckBox();
         this.calculateButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.total_box = new System.Windows.Forms.TextBox();
         this.orderedBox = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.orderedLabel = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(872, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "This Form will show the Total Cost of selected Car and selected options. It will " +
    "also display text describing what was chosen.";
         // 
         // radioVolt
         // 
         this.radioVolt.AutoSize = true;
         this.radioVolt.Location = new System.Drawing.Point(70, 31);
         this.radioVolt.Name = "radioVolt";
         this.radioVolt.Size = new System.Drawing.Size(245, 24);
         this.radioVolt.TabIndex = 1;
         this.radioVolt.TabStop = true;
         this.radioVolt.Text = "2014 Chevrolet Volt ($50,000)";
         this.radioVolt.UseVisualStyleBackColor = true;
         // 
         // radioPinto
         // 
         this.radioPinto.AutoSize = true;
         this.radioPinto.Location = new System.Drawing.Point(70, 62);
         this.radioPinto.Name = "radioPinto";
         this.radioPinto.Size = new System.Drawing.Size(210, 24);
         this.radioPinto.TabIndex = 2;
         this.radioPinto.TabStop = true;
         this.radioPinto.Text = "1970 Ford Pinto ($1,000)";
         this.radioPinto.UseVisualStyleBackColor = true;
         // 
         // roofBox
         // 
         this.roofBox.AutoSize = true;
         this.roofBox.Location = new System.Drawing.Point(67, 31);
         this.roofBox.Name = "roofBox";
         this.roofBox.Size = new System.Drawing.Size(166, 24);
         this.roofBox.TabIndex = 3;
         this.roofBox.Text = "Sun Roof ($1,000)";
         this.roofBox.UseVisualStyleBackColor = true;
         // 
         // playerBox
         // 
         this.playerBox.AutoSize = true;
         this.playerBox.Location = new System.Drawing.Point(67, 62);
         this.playerBox.Name = "playerBox";
         this.playerBox.Size = new System.Drawing.Size(167, 24);
         this.playerBox.TabIndex = 4;
         this.playerBox.Text = "DVD Player ($500)";
         this.playerBox.UseVisualStyleBackColor = true;
         // 
         // gasTankBox
         // 
         this.gasTankBox.AutoSize = true;
         this.gasTankBox.Location = new System.Drawing.Point(67, 93);
         this.gasTankBox.Name = "gasTankBox";
         this.gasTankBox.Size = new System.Drawing.Size(259, 24);
         this.gasTankBox.TabIndex = 5;
         this.gasTankBox.Text = "Non-exploding Gas Tank ($100)";
         this.gasTankBox.UseVisualStyleBackColor = true;
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(485, 79);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(114, 31);
         this.calculateButton.TabIndex = 6;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.UseVisualStyleBackColor = true;
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(630, 79);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(102, 31);
         this.clearButton.TabIndex = 7;
         this.clearButton.Text = "Clear All";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(444, 140);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(231, 20);
         this.label2.TabIndex = 8;
         this.label2.Text = "Total Cost of Car and Options $";
         // 
         // total_box
         // 
         this.total_box.Location = new System.Drawing.Point(681, 137);
         this.total_box.Name = "total_box";
         this.total_box.Size = new System.Drawing.Size(150, 26);
         this.total_box.TabIndex = 9;
         // 
         // orderedBox
         // 
         this.orderedBox.Location = new System.Drawing.Point(448, 216);
         this.orderedBox.Multiline = true;
         this.orderedBox.Name = "orderedBox";
         this.orderedBox.ReadOnly = true;
         this.orderedBox.Size = new System.Drawing.Size(383, 124);
         this.orderedBox.TabIndex = 10;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.gasTankBox);
         this.groupBox1.Controls.Add(this.playerBox);
         this.groupBox1.Controls.Add(this.roofBox);
         this.groupBox1.Location = new System.Drawing.Point(26, 201);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(375, 139);
         this.groupBox1.TabIndex = 11;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Choose One or More Optional Features";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.radioPinto);
         this.groupBox2.Controls.Add(this.radioVolt);
         this.groupBox2.Location = new System.Drawing.Point(26, 62);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(375, 103);
         this.groupBox2.TabIndex = 12;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Choose One Car to Buy";
         // 
         // orderedLabel
         // 
         this.orderedLabel.AutoSize = true;
         this.orderedLabel.Location = new System.Drawing.Point(445, 196);
         this.orderedLabel.Name = "orderedLabel";
         this.orderedLabel.Size = new System.Drawing.Size(142, 20);
         this.orderedLabel.TabIndex = 13;
         this.orderedLabel.Text = "What You Ordered";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(890, 366);
         this.Controls.Add(this.orderedLabel);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.orderedBox);
         this.Controls.Add(this.total_box);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.clearButton);
         this.Controls.Add(this.calculateButton);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.RadioButton radioVolt;
      private System.Windows.Forms.RadioButton radioPinto;
      private System.Windows.Forms.CheckBox roofBox;
      private System.Windows.Forms.CheckBox playerBox;
      private System.Windows.Forms.CheckBox gasTankBox;
      private System.Windows.Forms.Button calculateButton;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox total_box;
      private System.Windows.Forms.TextBox orderedBox;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label orderedLabel;
   }
}

