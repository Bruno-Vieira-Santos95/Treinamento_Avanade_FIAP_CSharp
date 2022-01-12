namespace sobrecarga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculadoraSalarioDolar csd = new CalculadoraSalarioDolar();

            double cotacao = 0;

            try
            {
                 csd.valorHora = double.Parse(txtVHora.Text);
                 csd.qtdeHoras = double.Parse(txtTotalHoras.Text);
                 csd.cotacao = double.Parse(txtDolar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                MessageBox.Show($"Total a receber: R$ {csd.calcularSalario():f2}");
            
        }
    }
}