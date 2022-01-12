namespace mediaGasolina
{
    public partial class frmGasolina : Form
    {
        public frmGasolina()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double kminicial, kmfinal, gasolina, res;

            kminicial = Convert.ToDouble(txtKminicial.Text);
            kmfinal = Convert.ToDouble(txtKmfinal.Text);
            gasolina = Convert.ToDouble(txtGasolina.Text);

            res = (kmfinal - kminicial) / (gasolina);

            lblRes.Text = "A quantidade de gasolina gasta por km é: " + res.ToString() + " km por litro.";

            
        }
    }
}