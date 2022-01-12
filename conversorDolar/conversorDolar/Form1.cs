namespace conversorDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            double dolar, res;

            dolar = Convert.ToDouble(txtDolar.Text);

            res = dolar * 5.63; //cotação 14/12 às 11:21

            lblReal.Text = res.ToString();
            
        }
    }
}