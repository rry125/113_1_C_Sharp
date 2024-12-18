namespace Tutorial3_1
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
            week = new Label();
            date = new Label();
            month = new Label();
            years = new Label();
            week_box = new TextBox();
            month_box = new TextBox();
            date_box = new TextBox();
            years_box = new TextBox();
            LBLshow = new Label();
            BTN_CLEAR = new Button();
            BTN_DATE = new Button();
            BTN_EXIT = new Button();
            SuspendLayout();
            // 
            // week
            // 
            week.AutoSize = true;
            week.Location = new Point(56, 40);
            week.Name = "week";
            week.Size = new Size(31, 15);
            week.TabIndex = 0;
            week.Text = "星期";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(56, 80);
            date.Name = "date";
            date.Size = new Size(31, 15);
            date.TabIndex = 1;
            date.Text = "日期";
            // 
            // month
            // 
            month.AutoSize = true;
            month.Location = new Point(56, 121);
            month.Name = "month";
            month.Size = new Size(31, 15);
            month.TabIndex = 2;
            month.Text = "月份";
            month.Click += label3_Click;
            // 
            // years
            // 
            years.AutoSize = true;
            years.Location = new Point(56, 163);
            years.Name = "years";
            years.Size = new Size(31, 15);
            years.TabIndex = 3;
            years.Text = "年份";
            // 
            // week_box
            // 
            week_box.Location = new Point(129, 37);
            week_box.Name = "week_box";
            week_box.Size = new Size(100, 23);
            week_box.TabIndex = 4;
            // 
            // month_box
            // 
            month_box.Location = new Point(129, 118);
            month_box.Name = "month_box";
            month_box.Size = new Size(100, 23);
            month_box.TabIndex = 5;
            // 
            // date_box
            // 
            date_box.Location = new Point(129, 72);
            date_box.Name = "date_box";
            date_box.Size = new Size(100, 23);
            date_box.TabIndex = 6;
            // 
            // years_box
            // 
            years_box.Location = new Point(129, 160);
            years_box.Name = "years_box";
            years_box.Size = new Size(100, 23);
            years_box.TabIndex = 7;
            // 
            // LBLshow
            // 
            LBLshow.BorderStyle = BorderStyle.Fixed3D;
            LBLshow.Location = new Point(37, 206);
            LBLshow.Name = "LBLshow";
            LBLshow.Size = new Size(210, 22);
            LBLshow.TabIndex = 8;
            // 
            // BTN_CLEAR
            // 
            BTN_CLEAR.Location = new Point(109, 246);
            BTN_CLEAR.Name = "BTN_CLEAR";
            BTN_CLEAR.Size = new Size(64, 23);
            BTN_CLEAR.TabIndex = 10;
            BTN_CLEAR.Text = "清空";
            BTN_CLEAR.UseVisualStyleBackColor = true;
            BTN_CLEAR.Click += BTN_CLEAR_Click;
            // 
            // BTN_DATE
            // 
            BTN_DATE.Location = new Point(12, 246);
            BTN_DATE.Name = "BTN_DATE";
            BTN_DATE.Size = new Size(64, 23);
            BTN_DATE.TabIndex = 11;
            BTN_DATE.Text = "顯示日期";
            BTN_DATE.UseVisualStyleBackColor = true;
            BTN_DATE.Click += BTN_DATE_Click;
            // 
            // BTN_EXIT
            // 
            BTN_EXIT.Location = new Point(200, 246);
            BTN_EXIT.Name = "BTN_EXIT";
            BTN_EXIT.Size = new Size(64, 23);
            BTN_EXIT.TabIndex = 12;
            BTN_EXIT.Text = "離開";
            BTN_EXIT.UseVisualStyleBackColor = true;
            BTN_EXIT.Click += BTN_EXIT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 295);
            Controls.Add(BTN_EXIT);
            Controls.Add(BTN_DATE);
            Controls.Add(BTN_CLEAR);
            Controls.Add(LBLshow);
            Controls.Add(years_box);
            Controls.Add(date_box);
            Controls.Add(month_box);
            Controls.Add(week_box);
            Controls.Add(years);
            Controls.Add(month);
            Controls.Add(date);
            Controls.Add(week);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label week;
        private Label date;
        private Label month;
        private Label years;
        private TextBox week_box;
        private TextBox month_box;
        private TextBox date_box;
        private TextBox years_box;
        private Label LBLshow;
        private Button BTN_CLEAR;
        private Button BTN_DATE;
        private Button BTN_EXIT;
    }
}
