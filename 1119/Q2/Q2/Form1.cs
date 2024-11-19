using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        private decimal total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            Lblmsg.Text = "0";
        }

        private void PIC_banana_Click(object sender, EventArgs e)
        {
            total += 115;
            Lblmsg.Text = total.ToString();
        }

        private void PIC_apple_Click(object sender, EventArgs e)
        {
            total += 80;
            Lblmsg.Text = total.ToString();
        }

        private void PIC_orange_Click(object sender, EventArgs e)
        {
            total += 90;
            Lblmsg.Text = total.ToString();
        }

        private void PIC_guava_Click(object sender, EventArgs e)
        {
            total += 120;
            Lblmsg.Text = total.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
