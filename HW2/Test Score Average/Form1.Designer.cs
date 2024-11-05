namespace Test_Score_Average
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Class_a = new System.Windows.Forms.TextBox();
            this.Class_b = new System.Windows.Forms.TextBox();
            this.Class_c = new System.Windows.Forms.TextBox();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassA = new System.Windows.Forms.Label();
            this.ClassB = new System.Windows.Forms.Label();
            this.ClassC = new System.Windows.Forms.Label();
            this.testScoreGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(80, 200);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 48);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate Revenue";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(249, 200);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 48);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(417, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 47);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Class_a
            // 
            this.Class_a.Location = new System.Drawing.Point(118, 70);
            this.Class_a.Name = "Class_a";
            this.Class_a.Size = new System.Drawing.Size(100, 22);
            this.Class_a.TabIndex = 0;
            // 
            // Class_b
            // 
            this.Class_b.Location = new System.Drawing.Point(118, 96);
            this.Class_b.Name = "Class_b";
            this.Class_b.Size = new System.Drawing.Size(100, 22);
            this.Class_b.TabIndex = 1;
            // 
            // Class_c
            // 
            this.Class_c.Location = new System.Drawing.Point(118, 124);
            this.Class_c.Name = "Class_c";
            this.Class_c.Size = new System.Drawing.Size(100, 22);
            this.Class_c.TabIndex = 2;
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.AutoSize = true;
            this.test1promptLabel.Location = new System.Drawing.Point(47, 74);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(43, 12);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "Class  A";
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.AutoSize = true;
            this.test2promptLabel.Location = new System.Drawing.Point(47, 100);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(44, 12);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "Classs B";
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.AutoSize = true;
            this.test3promptLabel.Location = new System.Drawing.Point(47, 127);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(43, 12);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "Class  C";
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.label6);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.Class_c);
            this.testScoreGroupBox.Controls.Add(this.Class_b);
            this.testScoreGroupBox.Controls.Add(this.Class_a);
            this.testScoreGroupBox.Location = new System.Drawing.Point(12, 11);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Size = new System.Drawing.Size(260, 159);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "Tickets Sold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enter the number of tickets sold for each class seats";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassC);
            this.groupBox1.Controls.Add(this.ClassB);
            this.groupBox1.Controls.Add(this.ClassA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TotalMsg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(295, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revenue Generated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // TotalMsg
            // 
            this.TotalMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMsg.Location = new System.Drawing.Point(109, 114);
            this.TotalMsg.Name = "TotalMsg";
            this.TotalMsg.Size = new System.Drawing.Size(100, 21);
            this.TotalMsg.TabIndex = 6;
            this.TotalMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class A";
            // 
            // ClassA
            // 
            this.ClassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassA.Location = new System.Drawing.Point(109, 30);
            this.ClassA.Name = "ClassA";
            this.ClassA.Size = new System.Drawing.Size(100, 21);
            this.ClassA.TabIndex = 8;
            this.ClassA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassB
            // 
            this.ClassB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassB.Location = new System.Drawing.Point(109, 56);
            this.ClassB.Name = "ClassB";
            this.ClassB.Size = new System.Drawing.Size(100, 21);
            this.ClassB.TabIndex = 9;
            this.ClassB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassC
            // 
            this.ClassC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassC.Location = new System.Drawing.Point(109, 83);
            this.ClassC.Name = "ClassC";
            this.ClassC.Size = new System.Drawing.Size(100, 21);
            this.ClassC.TabIndex = 10;
            this.ClassC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox Class_a;
        private System.Windows.Forms.TextBox Class_b;
        private System.Windows.Forms.TextBox Class_c;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ClassB;
        private System.Windows.Forms.Label ClassA;
        private System.Windows.Forms.Label ClassC;
    }
}

