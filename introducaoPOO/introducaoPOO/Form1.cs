namespace introducaoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto da classe Usuario
            Usuario user = new Usuario(txtNome.Text, txtEmail.Text, txtLogin.Text, txtSenha.Text);

            //Inserir os dados nos atributos
            //user.nome = txtNome.Text;
            //user.email = txtEmail.Text;
            //user.login = txtLogin.Text;
            //user.senha = txtSenha.Text;

            //Executando o método
            user.provaExistencia();
        }
    }
}