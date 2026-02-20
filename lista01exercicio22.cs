// Faça uma programa para representar a árvore genealógica de uma família. Para tal, crie
// uma classe Pessoa que permita indicar, além de nome e idade, o pai e a mãe. Tenha em
// mente que pai e mãe também são do tipo Pessoa.

using System;
using System.Collections.Generic;

class Pessoa
{
    public string Nome;
    public int Idade;
    public Pessoa Pai;
    public Pessoa Mae;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void MostrarArvore(int nivel = 0)
    {
        string indent = new string(' ', nivel * 4); // recuo
        Console.WriteLine($"{indent}- {Nome} ({Idade} anos)");

        if (Pai != null)
        {
            Console.WriteLine($"{indent}  Pai:");
            Pai.MostrarArvore(nivel + 1);
        }
        if (Mae != null)
        {
            Console.WriteLine($"{indent}  Mãe:");
            Mae.MostrarArvore(nivel + 1);
        }
    }
}

class Programa
{
    static List<Pessoa> pessoas = new List<Pessoa>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Árvore Genealógica");
            Console.WriteLine("1 - Cadastrar pessoa");
            Console.WriteLine("2 - Listar pessoas");
            Console.WriteLine("3 - Mostrar árvore de uma pessoa");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarPessoa();
                    break;
                case "2":
                    ListarPessoas();
                    break;
                case "3":
                    MostrarArvorePessoa();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CadastrarPessoa()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

        // Associar pai
        if (pessoas.Count > 0)
        {
            Console.Write("Tem pai cadastrado? (s/n): ");
            string temPai = Console.ReadLine().ToLower();
            if (temPai == "s")
            {
                ListarPessoas();
                Console.Write("Escolha o índice do pai: ");
                int paiIndex = int.Parse(Console.ReadLine());
                if (paiIndex >= 0 && paiIndex < pessoas.Count)
                    pessoa.Pai = pessoas[paiIndex];
            }

            // Associar mãe
            Console.Write("Tem mãe cadastrada? (s/n): ");
            string temMae = Console.ReadLine().ToLower();
            if (temMae == "s")
            {
                ListarPessoas();
                Console.Write("Escolha o índice da mãe: ");
                int maeIndex = int.Parse(Console.ReadLine());
                if (maeIndex >= 0 && maeIndex < pessoas.Count)
                    pessoa.Mae = pessoas[maeIndex];
            }
        }

        pessoas.Add(pessoa);
        Console.WriteLine($"Pessoa '{pessoa.Nome}' cadastrada!");
    }

    static void ListarPessoas()
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            return;
        }

        Console.WriteLine("Pessoas cadastradas:");
        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine($"{i} - {pessoas[i].Nome} ({pessoas[i].Idade} anos)");
        }
    }

    static void MostrarArvorePessoa()
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            return;
        }

        ListarPessoas();
        Console.Write("Escolha o índice da pessoa: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < pessoas.Count)
        {
            Console.WriteLine("\nÁrvore genealógica:");
            pessoas[index].MostrarArvore();
        }
        else
        {
            Console.WriteLine("Pessoa inválida!");
        }
    }
}
