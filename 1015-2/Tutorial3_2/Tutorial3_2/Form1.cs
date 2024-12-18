namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;


            kms = double.Parse(km_box.Text);
            liters = double.Parse(oil_box.Text);
            average = kms / liters;

            lblshow.Text = average.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
