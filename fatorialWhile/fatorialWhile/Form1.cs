namespace fatorialWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            
            int num, res = 1;
            int cont=1;

            num = int.Parse(txtFatorial.Text);

            while(num <= 1)
            {
                res = res * num(num - 1); //preciso arrumar a lógica e deixar aparecendo o resultado final
                num = res - num;
                MessageBox.Show($"O fatorial é {num.ToString()}");
                cont--;
            }
        }
    }
}