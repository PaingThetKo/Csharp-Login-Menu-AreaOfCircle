namespace AreaOfCircle
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            doCalculate();
        }

        private void doCalculate()
        {
            double r;
            double a;
            r = double.Parse(txtRadius.Text.ToString());
            a = 3.14 * (r * r);
            txtArea.Text = a.ToString();
        }

        private void txtRadius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doCalculate();
            }
        }
    }
}
