using HerancaProduto;

Produto p = new Produto();
p.Codigo = 1;
p.Nome = "Ervilha Enlatada";
p.Preco = 10.00;
p.Mostrar();

Produto p2 = new Produto(10,"Milho Enlatado",5.99);
p2.Mostrar();

ProdutoPerecivel pp = new ProdutoPerecivel();
pp.Codigo = 2;
pp.Nome = "Leite";
pp.Preco = 12.99;
pp.DtValidade = "10/12/2025";
pp.DtFabricacao = "01/01/2025";
pp.Lote = 43214;
pp.Mostrar();

ProdutoPerecivel pp2 = new ProdutoPerecivel(20,"Queijo",15.80,"12/12/2026","02/08/2024",53214);
pp2.Mostrar();
