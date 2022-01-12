namespace VariaveisNumericas
{
    public partial class Form1 : Form
    {

        double n1, n2, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis



            //Leitura dos valores
            lerValores();

            //Cálculo

            res = n1 + n2;
            

            //saída

            lblRes.Text = res.ToString();
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {



            //Leitura dos valores
            lerValores();

            //Cálculo

           
            res = n1 - n2;
           

            //saída

            
            lblRes2.Text = res.ToString();
           
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            lerValores();

            //Cálculo


            res = n1 * n2;


            //saída


            lblRes3.Text = res.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            lerValores();

            //Cálculo


            res = n1 / n2;


            //saída


            lblRes4.Text = res.ToString();
        }

        private void lerValores()
        {
            n1 = Convert.ToDouble(txtNum1.Text);
            n2 = Convert.ToDouble(txtNum2.Text);
        }
    }
}