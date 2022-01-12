namespace exemploComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmdEscolha.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Você selecionou a Equipe Ferrari");
                    break;
                case 1:
                    MessageBox.Show("Você selecionou a Equipe Mercedes");
                    break;
                case 2:
                    MessageBox.Show("Você selecionou a Equipe RedBull");
                    break;
                case 3:
                    MessageBox.Show("Você selecionou a Equipe McLaren");
                    break;
                default:
                    MessageBox.Show("Selecione uma equipe");
                    break;
            }
        }
    }
}