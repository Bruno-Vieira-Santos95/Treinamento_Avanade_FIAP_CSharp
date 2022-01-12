namespace opLogicoNAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string tipoUser;

            tipoUser = txtTipo.Text;

            if (tipoUser != "ADMINISTRADOR") //(!(tipoUser == "ADMINISTRADOR"))
            {
                MessageBox.Show("Sem poderes administrativos!");
            }
        }
    }
}