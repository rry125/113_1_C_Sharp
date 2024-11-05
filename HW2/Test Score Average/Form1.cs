using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double text_a, text_b, text_c;
            double text_A, text_B, text_C;
            double total;

            try
            {
                text_a = double.Parse(Class_a.Text);
                text_b = double.Parse(Class_b.Text);
                text_c = double.Parse(Class_c.Text);

                text_A = text_a * 15;
                text_B = text_b * 12;
                text_C = text_c * 9;

                total = text_A + text_B + text_C;
                ClassA.Text = text_A.ToString("c2");
                ClassB.Text = text_B.ToString("c2");
                ClassC.Text = text_C.ToString("c2");
                TotalMsg.Text = total.ToString("c2");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            {
            
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClassA.Text = "";
            ClassB.Text = "";
            ClassC.Text = "";
            Class_a.Text = "";
            Class_b.Text = "";
            Class_c.Text = "";
            TotalMsg.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}