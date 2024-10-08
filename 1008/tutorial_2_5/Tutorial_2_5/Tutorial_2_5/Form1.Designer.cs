namespace Tutorial_2_5
{
    partial class 翻牌
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(翻牌));
            pic_back = new PictureBox();
            pic_on = new PictureBox();
            BTN_back = new Button();
            BTN_on = new Button();
            BTN_out = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_on).BeginInit();
            SuspendLayout();
            // 
            // pic_back
            // 
            pic_back.Image = (Image)resources.GetObject("pic_back.Image");
            pic_back.Location = new Point(27, 84);
            pic_back.Name = "pic_back";
            pic_back.Size = new Size(191, 267);
            pic_back.SizeMode = PictureBoxSizeMode.Zoom;
            pic_back.TabIndex = 0;
            pic_back.TabStop = false;
            pic_back.Visible = false;
            pic_back.Click += pic_back_Click;
            // 
            // pic_on
            // 
            pic_on.Image = Properties.Resources.Ace_Spades;
            pic_on.Location = new Point(258, 84);
            pic_on.Name = "pic_on";
            pic_on.Size = new Size(191, 267);
            pic_on.SizeMode = PictureBoxSizeMode.Zoom;
            pic_on.TabIndex = 1;
            pic_on.TabStop = false;
            pic_on.Visible = false;
            pic_on.Click += pic_on_Click;
            // 
            // BTN_back
            // 
            BTN_back.Location = new Point(58, 374);
            BTN_back.Name = "BTN_back";
            BTN_back.Size = new Size(132, 39);
            BTN_back.TabIndex = 2;
            BTN_back.Text = "背面";
            BTN_back.UseVisualStyleBackColor = true;
            // 
            // BTN_on
            // 
            BTN_on.Location = new Point(291, 374);
            BTN_on.Name = "BTN_on";
            BTN_on.Size = new Size(132, 39);
            BTN_on.TabIndex = 3;
            BTN_on.Text = "正面";
            BTN_on.UseVisualStyleBackColor = true;
            // 
            // BTN_out
            // 
            BTN_out.Location = new Point(171, 433);
            BTN_out.Name = "BTN_out";
            BTN_out.Size = new Size(132, 39);
            BTN_out.TabIndex = 4;
            BTN_out.Text = "離開";
            BTN_out.UseVisualStyleBackColor = true;
            BTN_out.Click += BTN_out_Click;
            // 
            // 翻牌
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 498);
            Controls.Add(BTN_out);
            Controls.Add(BTN_on);
            Controls.Add(BTN_back);
            Controls.Add(pic_on);
            Controls.Add(pic_back);
            Name = "翻牌";
            Text = "翻牌";
            Load += 翻牌_Load;
            ((System.ComponentModel.ISupportInitialize)pic_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_on).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_back;
        private PictureBox pic_on;
        private Button BTN_back;
        private Button BTN_on;
        private Button BTN_out;
    }
}
