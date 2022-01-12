namespace tipoTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double x, y, z;

            x = double.Parse(txtLadoX.Text);
            y = double.Parse(txtLadoY.Text);
            z = double.Parse(txtLadoZ.Text);

            if (x + y > z && x + z > y && z + y > x)
            {
                //MessageBox.Show("Os 3 formam um tri�ngulo!");
                if (x == y && x == z)
                {
                    MessageBox.Show("Forma um Tri�ngulo Equil�tero! ");
                } else if (x == y || x == z || y == z)
                {
                    MessageBox.Show("Forma um Tri�ngulo Is�sceles!");
                }
                else
                {
                    MessageBox.Show("Forma um Tri�ngulo Escaleno!");
                }
            } else
            {
                MessageBox.Show("N�o formam Tri�ngulo!");
            }
        }
    }
}