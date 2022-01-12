namespace transaçãoBancaria
{
    public partial class Form1 : Form
    {
        double saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransacao_Click(object sender, EventArgs e)
        {
            double valor=0;

            //valor = double.Parse(txtValor.Text);

            if (!(cmbOpcao.SelectedIndex == 2))
            {
                if (double.TryParse(txtValor.Text, out valor) == false)
                {
                    MessageBox.Show("Digite um valor válido");
                    txtValor.Clear();
                    txtValor.Focus();
                    return;
                }
            }
            

            switch (cmbOpcao.SelectedIndex)
            {
                case 0:
                    saldo += valor; //saldo=saldo+valor
                    MessageBox.Show("Depósito Efetuado");
                    break;
                case 1:
                    saldo -= valor; //saldo=saldo+valor
                    MessageBox.Show("Saque Efetuado");
                    break;
                case 2:
                    MessageBox.Show($"Seu saldo é de R${saldo.ToString("0.00")}");
                    break;
                default:
                    MessageBox.Show("Opção Inválida!");
                    break;
            }


            

        }
    }
}