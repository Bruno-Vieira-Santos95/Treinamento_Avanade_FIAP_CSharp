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

            res = dolar * 5.63; //cota��o 14/12 �s 11:21

            lblReal.Text = res.ToString();
            
        }
    }
}