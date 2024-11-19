namespace Q2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PIC_banana = new System.Windows.Forms.PictureBox();
            this.PIC_apple = new System.Windows.Forms.PictureBox();
            this.PIC_orange = new System.Windows.Forms.PictureBox();
            this.PIC_guava = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_banana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_guava)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC_banana
            // 
            this.PIC_banana.Image = ((System.Drawing.Image)(resources.GetObject("PIC_banana.Image")));
            this.PIC_banana.Location = new System.Drawing.Point(26, 43);
            this.PIC_banana.Name = "PIC_banana";
            this.PIC_banana.Size = new System.Drawing.Size(126, 111);
            this.PIC_banana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_banana.TabIndex = 0;
            this.PIC_banana.TabStop = false;
            this.PIC_banana.Click += new System.EventHandler(this.PIC_banana_Click);
            // 
            // PIC_apple
            // 
            this.PIC_apple.Image = ((System.Drawing.Image)(resources.GetObject("PIC_apple.Image")));
            this.PIC_apple.Location = new System.Drawing.Point(158, 43);
            this.PIC_apple.Name = "PIC_apple";
            this.PIC_apple.Size = new System.Drawing.Size(126, 111);
            this.PIC_apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_apple.TabIndex = 1;
            this.PIC_apple.TabStop = false;
            this.PIC_apple.Click += new System.EventHandler(this.PIC_apple_Click);
            // 
            // PIC_orange
            // 
            this.PIC_orange.Image = ((System.Drawing.Image)(resources.GetObject("PIC_orange.Image")));
            this.PIC_orange.Location = new System.Drawing.Point(26, 160);
            this.PIC_orange.Name = "PIC_orange";
            this.PIC_orange.Size = new System.Drawing.Size(126, 111);
            this.PIC_orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_orange.TabIndex = 2;
            this.PIC_orange.TabStop = false;
            this.PIC_orange.Click += new System.EventHandler(this.PIC_orange_Click);
            // 
            // PIC_guava
            // 
            this.PIC_guava.Image = ((System.Drawing.Image)(resources.GetObject("PIC_guava.Image")));
            this.PIC_guava.Location = new System.Drawing.Point(158, 160);
            this.PIC_guava.Name = "PIC_guava";
            this.PIC_guava.Size = new System.Drawing.Size(126, 111);
            this.PIC_guava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_guava.TabIndex = 3;
            this.PIC_guava.TabStop = false;
            this.PIC_guava.Click += new System.EventHandler(this.PIC_guava_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(311, 205);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 30);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(311, 241);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 30);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Calories";
            // 
            // Lblmsg
            // 
            this.Lblmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblmsg.Location = new System.Drawing.Point(311, 64);
            this.Lblmsg.Name = "Lblmsg";
            this.Lblmsg.Size = new System.Drawing.Size(100, 23);
            this.Lblmsg.TabIndex = 7;
            this.Lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.Lblmsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.PIC_guava);
            this.Controls.Add(this.PIC_orange);
            this.Controls.Add(this.PIC_apple);
            this.Controls.Add(this.PIC_banana);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_banana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_guava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_banana;
        private System.Windows.Forms.PictureBox PIC_apple;
        private System.Windows.Forms.PictureBox PIC_orange;
        private System.Windows.Forms.PictureBox PIC_guava;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblmsg;
    }
}

