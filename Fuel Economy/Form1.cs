namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            miles = double.Parse(textBoxMiles.Text);
            gallons = double.Parse(textBoxGallons.Text);
            mpg = miles / gallons;

            labelMPG.Text = mpg.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}