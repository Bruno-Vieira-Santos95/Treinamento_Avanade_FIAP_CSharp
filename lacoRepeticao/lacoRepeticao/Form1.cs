namespace lacoRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int num, res;

            num = int.Parse(txtNum.Text);

            res = num * 1;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 2;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 3;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 4;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 5;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 6;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 7;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 8;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 9;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
            res = num * 10;
            lstTabuada.Items.Add(res.ToString()); //Inserindo um valor a list box
        }

        private void lstTabuada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}