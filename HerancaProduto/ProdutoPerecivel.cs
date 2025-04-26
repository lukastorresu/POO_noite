using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{// sublasse / Classe derivada : classe base/superclasse
    public class ProdutoPerecivel : Produto
    {
        public string? DtValidade{get;set;}
        public string? DtFabricacao{get;set;}
        public int Lote{get;set;}
        
        public void Mostrar()
        {
            base.Mostrar();//chamar o método Mostra da classe base
            Console.WriteLine("Data da Validade: " + DtValidade);
            Console.WriteLine("Data da Fabricação: " + DtFabricacao);
            Console.WriteLine("Lote: " + Lote);
        }
        public ProdutoPerecivel(int codigo, string nome, double preco, string dtValidade, string dtFabricacao, int lote) : base(codigo,nome,preco)
        {
            DtValidade = dtValidade;
            DtFabricacao = dtFabricacao;
            Lote = lote;
        }
        public ProdutoPerecivel(){}

    }
}