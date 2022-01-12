namespace mesAno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            byte mes;

            mes = byte.Parse(txtMes.Text);

            switch (mes)
            {
                case 1:
                    MessageBox.Show("Janeiro");
                    break;
                case 2:
                    MessageBox.Show("Fevereiro");
                    break;
                case 3:
                    MessageBox.Show("Março");
                    break;
                case 4:
                    MessageBox.Show("Abril");
                    break;
                case 5:
                    MessageBox.Show("Maio");
                    break;
                case 6:
                    MessageBox.Show("Junho");
                    break;
                case 7:
                    MessageBox.Show("Julho");
                    break;
                case 8:
                    MessageBox.Show("Agosto");
                    break;
                case 9:
                    MessageBox.Show("Setembro");
                    break;
                case 10:
                    MessageBox.Show("Outubro");
                    break;
                case 11:
                    MessageBox.Show("Novembro");
                    break;
                case 12:
                    MessageBox.Show("Dezembro");
                    break;
                default:
                    MessageBox.Show("Número Incorreto!");
                    break;
            }
        }
    }
}