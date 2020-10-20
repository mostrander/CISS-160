namespace TieredPlayerSalaryViaIF___Megan_Ostrander
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
         this.mvp_checkBox = new System.Windows.Forms.CheckBox();
         this.star_checkBox = new System.Windows.Forms.CheckBox();
         this.playerBox = new System.Windows.Forms.TextBox();
         this.hitBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.clearButton = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.playerTierBox = new System.Windows.Forms.TextBox();
         this.playerSalaryBox = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.leaderSalaryBox = new System.Windows.Forms.TextBox();
         this.leaderTierBox = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.leaderNameBox = new System.Windows.Forms.TextBox();
         this.leaderHitBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(26, 518);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(137, 42);
         this.calculateButton.TabIndex = 0;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.UseVisualStyleBackColor = true;
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // mvp_checkBox
         // 
         this.mvp_checkBox.AutoSize = true;
         this.mvp_checkBox.Location = new System.Drawing.Point(66, 130);
         this.mvp_checkBox.Name = "mvp_checkBox";
         this.mvp_checkBox.Size = new System.Drawing.Size(69, 24);
         this.mvp_checkBox.TabIndex = 1;
         this.mvp_checkBox.Text = "MVP";
         this.mvp_checkBox.UseVisualStyleBackColor = true;
         // 
         // star_checkBox
         // 
         this.star_checkBox.AutoSize = true;
         this.star_checkBox.Location = new System.Drawing.Point(202, 130);
         this.star_checkBox.Name = "star_checkBox";
         this.star_checkBox.Size = new System.Drawing.Size(86, 24);
         this.star_checkBox.TabIndex = 2;
         this.star_checkBox.Text = "All Star";
         this.star_checkBox.UseVisualStyleBackColor = true;
         // 
         // playerBox
         // 
         this.playerBox.Location = new System.Drawing.Point(165, 32);
         this.playerBox.Name = "playerBox";
         this.playerBox.Size = new System.Drawing.Size(158, 26);
         this.playerBox.TabIndex = 3;
         // 
         // hitBox
         // 
         this.hitBox.Location = new System.Drawing.Point(165, 76);
         this.hitBox.Name = "hitBox";
         this.hitBox.Size = new System.Drawing.Size(158, 26);
         this.hitBox.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(32, 36);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(117, 20);
         this.label1.TabIndex = 5;
         this.label1.Text = "Player\'s Name: ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(26, 80);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(123, 20);
         this.label2.TabIndex = 6;
         this.label2.Text = "Number of Hits: ";
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(193, 518);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(133, 42);
         this.clearButton.TabIndex = 7;
         this.clearButton.Text = "Clear";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(48, 190);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(101, 20);
         this.label3.TabIndex = 8;
         this.label3.Text = "Player\'s Tier: ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(30, 230);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(119, 20);
         this.label4.TabIndex = 9;
         this.label4.Text = "Player\'s Salary: ";
         // 
         // playerTierBox
         // 
         this.playerTierBox.Location = new System.Drawing.Point(165, 185);
         this.playerTierBox.Name = "playerTierBox";
         this.playerTierBox.ReadOnly = true;
         this.playerTierBox.Size = new System.Drawing.Size(158, 26);
         this.playerTierBox.TabIndex = 10;
         // 
         // playerSalaryBox
         // 
         this.playerSalaryBox.Location = new System.Drawing.Point(165, 225);
         this.playerSalaryBox.Name = "playerSalaryBox";
         this.playerSalaryBox.ReadOnly = true;
         this.playerSalaryBox.Size = new System.Drawing.Size(158, 26);
         this.playerSalaryBox.TabIndex = 11;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(110, 289);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(131, 29);
         this.label5.TabIndex = 12;
         this.label5.Text = "Top Player";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(32, 341);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(117, 20);
         this.label6.TabIndex = 13;
         this.label6.Text = "Player\'s Name: ";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(26, 461);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(123, 20);
         this.label7.TabIndex = 14;
         this.label7.Text = "Number of Hits: ";
         // 
         // leaderSalaryBox
         // 
         this.leaderSalaryBox.Location = new System.Drawing.Point(165, 416);
         this.leaderSalaryBox.Name = "leaderSalaryBox";
         this.leaderSalaryBox.ReadOnly = true;
         this.leaderSalaryBox.Size = new System.Drawing.Size(158, 26);
         this.leaderSalaryBox.TabIndex = 18;
         // 
         // leaderTierBox
         // 
         this.leaderTierBox.Location = new System.Drawing.Point(165, 376);
         this.leaderTierBox.Name = "leaderTierBox";
         this.leaderTierBox.ReadOnly = true;
         this.leaderTierBox.Size = new System.Drawing.Size(158, 26);
         this.leaderTierBox.TabIndex = 17;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(30, 421);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(119, 20);
         this.label8.TabIndex = 16;
         this.label8.Text = "Player\'s Salary: ";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(48, 381);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(101, 20);
         this.label9.TabIndex = 15;
         this.label9.Text = "Player\'s Tier: ";
         // 
         // leaderNameBox
         // 
         this.leaderNameBox.Location = new System.Drawing.Point(165, 338);
         this.leaderNameBox.Name = "leaderNameBox";
         this.leaderNameBox.Size = new System.Drawing.Size(158, 26);
         this.leaderNameBox.TabIndex = 19;
         // 
         // leaderHitBox
         // 
         this.leaderHitBox.Location = new System.Drawing.Point(165, 455);
         this.leaderHitBox.Name = "leaderHitBox";
         this.leaderHitBox.Size = new System.Drawing.Size(158, 26);
         this.leaderHitBox.TabIndex = 20;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(358, 590);
         this.Controls.Add(this.leaderHitBox);
         this.Controls.Add(this.leaderNameBox);
         this.Controls.Add(this.leaderSalaryBox);
         this.Controls.Add(this.leaderTierBox);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.playerSalaryBox);
         this.Controls.Add(this.playerTierBox);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.clearButton);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.hitBox);
         this.Controls.Add(this.playerBox);
         this.Controls.Add(this.star_checkBox);
         this.Controls.Add(this.mvp_checkBox);
         this.Controls.Add(this.calculateButton);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button calculateButton;
      private System.Windows.Forms.CheckBox mvp_checkBox;
      private System.Windows.Forms.CheckBox star_checkBox;
      private System.Windows.Forms.TextBox playerBox;
      private System.Windows.Forms.TextBox hitBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox playerTierBox;
      private System.Windows.Forms.TextBox playerSalaryBox;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox leaderSalaryBox;
      private System.Windows.Forms.TextBox leaderTierBox;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox leaderNameBox;
      private System.Windows.Forms.TextBox leaderHitBox;
   }
}

