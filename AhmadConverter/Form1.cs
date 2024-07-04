namespace AhmadConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txbMm_TextChanged(object sender, EventArgs e)
        {
            txbIn.Text = "";
        }
        private void txbIn_TextChanged(object sender, EventArgs e)
        {
            txbMm.Text = "";
        }
    }
}
