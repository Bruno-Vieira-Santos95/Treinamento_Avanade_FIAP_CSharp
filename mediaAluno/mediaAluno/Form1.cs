namespace mediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;

            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                MessageBox.Show("Voc� est� aprovado!", "M�dia - Aluno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (media >= 4)
            {
                MessageBox.Show("Em prova final!", "M�dia - Aluno",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Reprovado!", "M�dia - Aluno",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}