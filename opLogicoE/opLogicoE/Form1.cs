namespace opLogicoE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtUsuario.Text.ToUpper();
            senha = txtSenha.Text.ToLower();

            if (login == "ADMINISTRADOR" && senha == "123")
            {
                MessageBox.Show("Bem-Vindo Administrador");
            }
            else
            {
                MessageBox.Show("Nome de Usuário ou Senha Inválidos");
            }
        }
    }
}