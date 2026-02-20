// Identifique as classes e implemente um programa para a seguinte especificação: “O
// supermercado vende diferentes tipos de produtos. Cada produto tem um preço e uma
// quantidade em estoque. Um pedido de um cliente é composto de itens, onde cada item
// especifica o produto que o cliente deseja e a respectiva quantidade. Esse pedido pode ser
// pago em dinheiro, cheque ou cartão.”

using System;
using System.Collections.Generic;

enum TipoPagamento
{
    Dinheiro = 1,
    Cheque,
    Cartao
}

class Produto
{
    public string Nome;
    public double Preco;
    public int Estoque;

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}

class ItemPedido
{
    public Produto Produto;
    public int Quantidade;

    public ItemPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public double ValorItem()
    {
        return Produto.Preco * Quantidade;
    }
}

class Pedido
{
    public List<ItemPedido> Itens = new List<ItemPedido>();
    public TipoPagamento Pagamento;

    public Pedido(TipoPagamento pagamento)
    {
        Pagamento = pagamento;
    }

    public void AdicionarItem(ItemPedido item)
    {
        if (item.Quantidade <= item.Produto.Estoque)
        {
            Itens.Add(item);
            item.Produto.Estoque -= item.Quantidade;
            Console.WriteLine($"{item.Quantidade} x {item.Produto.Nome} adicionado ao pedido.");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente para " + item.Produto.Nome);
        }
    }

    public double Total()
    {
        double total = 0;
        foreach (var item in Itens)
        {
            total += item.ValorItem();
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>()
        {
            new Produto("Arroz", 20.0, 50),
            new Produto("Feijão", 8.0, 30),
            new Produto("Macarrão", 5.0, 40),
            new Produto("Coca", 9.0, 60)
        };

        Console.WriteLine("Produtos disponíveis:");

        foreach (var p in produtos)
        {
            Console.WriteLine($"{produtos.IndexOf(p) + 1} - {p.Nome} (Preço: R${p.Preco}, Estoque: {p.Estoque})");
        }

        Console.WriteLine("Forma de pagamento: 1-Dinheiro  2-Cheque  3-Cartão");
        TipoPagamento pagamento = (TipoPagamento)int.Parse(Console.ReadLine());

        Pedido pedido = new Pedido(pagamento);

        while (true)
        {
            Console.WriteLine("Digite o número do produto que deseja comprar (0 para finalizar):");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 0)
                break;

            if (escolha < 1 || escolha > produtos.Count)
            {
                Console.WriteLine("Produto inválido.");
                continue;
            }

            Produto produtoSelecionado = produtos[escolha - 1];

            Console.WriteLine($"Digite a quantidade de {produtoSelecionado.Nome}:");
            int quantidade = int.Parse(Console.ReadLine());

            ItemPedido item = new ItemPedido(produtoSelecionado, quantidade);
            pedido.AdicionarItem(item);
        }

        Console.WriteLine($"Total do pedido: R${pedido.Total()}");
        Console.WriteLine($"Pagamento escolhido: {pedido.Pagamento}");
        Console.WriteLine("Obrigado por comprar conosco!");
    }
}
