/*----------------------------------------------------------------------
 


-----------------------------------------------------------------------*/

namespace Tutorial_2_5
{
    public partial class ½�P : Form
    {
        public ½�P()
        {
            InitializeComponent();
        }

        private void ½�P_Load(object sender, EventArgs e)
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
