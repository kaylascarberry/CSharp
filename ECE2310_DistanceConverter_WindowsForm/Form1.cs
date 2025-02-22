namespace ECE2310_DistanceConverter_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double Mi, Km;
            string str_Mi = txtMi.Text;
            Mi = Convert.ToDouble(str_Mi);
            Km = Mi * 1.609;
            txtKm.Text = Km.ToString();
        }

    }
}
