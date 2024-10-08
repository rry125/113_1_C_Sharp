/*----------------------------------------------------------------------
 


-----------------------------------------------------------------------*/

namespace Tutorial_2_5
{
    public partial class Â½µP : Form
    {
        public Â½µP()
        {
            InitializeComponent();
        }

        private void Â½µP_Load(object sender, EventArgs e)
        {

        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            pic_back.Visible = true;
            pic_on.Visible = false;
        }

        private void pic_on_Click(object sender, EventArgs e)
        {
            pic_back.Visible = false;
            pic_on.Visible = true;
        }

        private void BTN_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
