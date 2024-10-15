namespace tutorial_2_8
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
            Pic_9 = new PictureBox();
            pic_A = new PictureBox();
            pic_red_jocker = new PictureBox();
            pic_K = new PictureBox();
            pic_blacck_jocker = new PictureBox();
            Label = new Label();
            label2 = new Label();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic_9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_red_jocker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_K).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_blacck_jocker).BeginInit();
            SuspendLayout();
            // 
            // Pic_9
            // 
            Pic_9.Image = Properties.Resources._9_Diamonds;
            Pic_9.Location = new Point(12, 108);
            Pic_9.Name = "Pic_9";
            Pic_9.Size = new Size(142, 202);
            Pic_9.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_9.TabIndex = 0;
            Pic_9.TabStop = false;
            Pic_9.Click += pictureBox1_Click;
            // 
            // pic_A
            // 
            pic_A.Image = Properties.Resources.Ace_Spades;
            pic_A.Location = new Point(160, 108);
            pic_A.Name = "pic_A";
            pic_A.Size = new Size(142, 202);
            pic_A.SizeMode = PictureBoxSizeMode.Zoom;
            pic_A.TabIndex = 1;
            pic_A.TabStop = false;
            pic_A.Click += pic_A_Click;
            // 
            // pic_red_jocker
            // 
            pic_red_jocker.Image = Properties.Resources.Joker_Red;
            pic_red_jocker.Location = new Point(308, 108);
            pic_red_jocker.Name = "pic_red_jocker";
            pic_red_jocker.Size = new Size(142, 202);
            pic_red_jocker.SizeMode = PictureBoxSizeMode.Zoom;
            pic_red_jocker.TabIndex = 2;
            pic_red_jocker.TabStop = false;
            pic_red_jocker.Click += pic_red_jocker_Click;
            // 
            // pic_K
            // 
            pic_K.Image = Properties.Resources.King_Clubs;
            pic_K.Location = new Point(456, 108);
            pic_K.Name = "pic_K";
            pic_K.Size = new Size(142, 202);
            pic_K.SizeMode = PictureBoxSizeMode.Zoom;
            pic_K.TabIndex = 3;
            pic_K.TabStop = false;
            pic_K.Click += pic_K_Click;
            // 
            // pic_blacck_jocker
            // 
            pic_blacck_jocker.Image = Properties.Resources.Joker_Black;
            pic_blacck_jocker.Location = new Point(604, 108);
            pic_blacck_jocker.Name = "pic_blacck_jocker";
            pic_blacck_jocker.Size = new Size(142, 202);
            pic_blacck_jocker.SizeMode = PictureBoxSizeMode.Zoom;
            pic_blacck_jocker.TabIndex = 4;
            pic_blacck_jocker.TabStop = false;
            pic_blacck_jocker.Click += pic_blacck_jocker_Click;
            // 
            // Label
            // 
            Label.BorderStyle = BorderStyle.Fixed3D;
            Label.Location = new Point(274, 329);
            Label.Name = "Label";
            Label.Size = new Size(209, 49);
            Label.TabIndex = 5;
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(255, 25);
            label2.Name = "label2";
            label2.Size = new Size(241, 56);
            label2.TabIndex = 6;
            label2.Text = "點選一張";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // exit
            // 
            exit.Location = new Point(343, 400);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 7;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 450);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(Label);
            Controls.Add(pic_blacck_jocker);
            Controls.Add(pic_K);
            Controls.Add(pic_red_jocker);
            Controls.Add(pic_A);
            Controls.Add(Pic_9);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Pic_9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_red_jocker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_K).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_blacck_jocker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pic_9;
        private PictureBox pic_A;
        private PictureBox pic_red_jocker;
        private PictureBox pic_K;
        private PictureBox pic_blacck_jocker;
        private Label Label;
        private Label label2;
        private Button exit;
    }
}
