namespace Tutorial3_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            km_box = new TextBox();
            oil_box = new TextBox();
            lblshow = new Label();
            sum = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 47);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 103);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 175);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // km_box
            // 
            km_box.Location = new Point(145, 44);
            km_box.Name = "km_box";
            km_box.Size = new Size(100, 23);
            km_box.TabIndex = 3;
            // 
            // oil_box
            // 
            oil_box.Location = new Point(145, 100);
            oil_box.Name = "oil_box";
            oil_box.Size = new Size(100, 23);
            oil_box.TabIndex = 4;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(145, 174);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(100, 23);
            lblshow.TabIndex = 5;
            // 
            // sum
            // 
            sum.Location = new Point(54, 248);
            sum.Name = "sum";
            sum.Size = new Size(75, 23);
            sum.TabIndex = 6;
            sum.Text = "計算";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // exit
            // 
            exit.Location = new Point(179, 248);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 7;
            exit.Text = "離開";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 325);
            Controls.Add(exit);
            Controls.Add(sum);
            Controls.Add(lblshow);
            Controls.Add(oil_box);
            Controls.Add(km_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox km_box;
        private TextBox oil_box;
        private Label lblshow;
        private Button sum;
        private Button exit;
    }
}
