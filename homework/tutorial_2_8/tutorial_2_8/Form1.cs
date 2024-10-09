namespace tutorial_2_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Label.Text = "Nine Of Diamonds";
        }

        private void pic_A_Click(object sender, EventArgs e)
        {
            Label.Text = "Ace Of Spade";
        }

        private void pic_red_jocker_Click(object sender, EventArgs e)
        {
            Label.Text = "Red Joker";
        }

        private void pic_K_Click(object sender, EventArgs e)
        {
            Label.Text = "K Of Club";
        }

        private void pic_blacck_jocker_Click(object sender, EventArgs e)
        {
            Label.Text = "Black Joker";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
