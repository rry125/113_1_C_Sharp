namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_DATE_Click(object sender, EventArgs e)
        {
            string output;

            output = "����" + years_box.Text + "�~" + month_box.Text + "��" + date_box.Text + "��" + "�P��" + week_box.Text;

            LBLshow.Text = output;
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            week_box.Text = "";
            years_box.Text = "";
            date_box.Text = "";
            month_box.Text = "";
            LBLshow.Text = "";
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
