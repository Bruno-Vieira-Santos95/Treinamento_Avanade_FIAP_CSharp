namespace livraria_heranca
{
    public partial class Form1 : Form
    {
        Livro liv = new Livro();
        CD cd = new CD();
        DVD dvd = new DVD();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            liv.descricao = txtDesc.Text;
            liv.autor = txtAutor.Text;
            liv.edicao = txtEdicao.Text;
            liv.editora = txtEditora.Text;
            liv.estoqueDisponivel = int.Parse(txtEstoque.Text);
            liv.genero = txtGênero.Text;
            liv.precoCusto = double.Parse(txtPreco.Text);
            MessageBox.Show("Livro cadastrado com sucesso!");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtCompraVenda.Text);
            liv.comprar(qtde);
            MessageBox.Show("Compra de livro confirmada.");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtCompraVenda.Text);
            liv.vender(qtde);
            MessageBox.Show("Venda de livro confirmada.");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            liv.listarProduto();
        }

        private void btnCadCD_Click(object sender, EventArgs e)
        {
            cd.descricao = txtDesc.Text;
            cd.artista = txtArtista.Text;
            cd.gravadora = txtGravadora.Text;
            cd.paisOrigem = txtOrigem.Text;
            cd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            cd.genero = txtGênero.Text;
            cd.precoCusto = double.Parse(txtPreco.Text);
            MessageBox.Show("CD cadastrado com sucesso!");
        }

        private void btnCadDVD_Click(object sender, EventArgs e)
        {
            dvd.descricao = txtDesc.Text;
            dvd.diretor = txtDiretor.Text;
            dvd.duracao = txtDuracao.Text;
            dvd.censura = txtCensura.Text;
            dvd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            dvd.genero = txtGênero.Text;
            dvd.precoCusto = double.Parse(txtPreco.Text);
            MessageBox.Show("DVD cadastrado com sucesso!");
        }

        private void btnComprarCD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtCompraVenda.Text);
            cd.comprar(qtde);
            MessageBox.Show("Compra de CD confirmada.");
        }

        private void btnVenderCD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtCompraVenda.Text);
            cd.vender(qtde);
            MessageBox.Show("Compra de CD confirmada.");
        }

        private void btnListarCD_Click(object sender, EventArgs e)
        {
            cd.listarProduto();
        }

        private void btnComprarDVD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtCompraVenda.Text);
            dvd.comprar(qtde);
            MessageBox.Show("Compra de DVD confirmada.");
        }

        private void btnVenderDVD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtCompraVenda.Text);
            dvd.vender(qtde);
            MessageBox.Show("Compra de DVD confirmada.");
        }

        private void btnListarDVD_Click(object sender, EventArgs e)
        {
            dvd.listarProduto();
        }
    }
}