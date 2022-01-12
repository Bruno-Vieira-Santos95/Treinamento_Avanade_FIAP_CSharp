using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livraria_heranca
{
    public class Produto
    {
        public string descricao { get; set; }
        public string genero { get; set;}
        public int estoqueDisponivel { get; set;}
        public double precoCusto { get; set; }

        public Produto(string descricao, string genero, int estoqueDisponivel, double precoCusto)
        {
            this.descricao = descricao;
            this.genero = genero;
            this.estoqueDisponivel = estoqueDisponivel;
            this.precoCusto = precoCusto;
        }

        public Produto()
        {
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
        }

        public void comprar(int qtde)
        {
            this.estoqueDisponivel += qtde;
        }

        public void vender(int qtde)
        {
            if (qtde > this.estoqueDisponivel)
            {
                MessageBox.Show("Quantidade e estoque insuficiente. \nVenda cancelada!");
            }
            else
            {
                this.estoqueDisponivel -= qtde;
            }
        }
    }
}
