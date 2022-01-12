namespace calculadoraPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora (txtN1.Text, txtN2.Text, btnSomar.Text);
            //calc.n1 = Convert.ToDouble(txtN1.Text);
            //calc.n2 = Convert.ToDouble(txtN2.Text);
            calc.somar();
            //lblResposta.Text = calc.res.ToString();
        }

        //Usuario user = new Usuario(txtNome.Text, txtEmail.Text, txtLogin.Text, txtSenha.Text);

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2 = Convert.ToDouble(txtN2.Text);
            calc.subtrair();
            lblResposta.Text= calc.res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2= Convert.ToDouble(txtN2.Text);
            calc.multiplicar();
            lblResposta.Text = calc.res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = Convert.ToDouble(txtN1.Text);
            calc.n2= Convert.ToDouble(txtN2.Text);
            calc.dividir();
            lblResposta.Text = calc.res.ToString();
        }
    }
}