// Faça um programa de agenda telefônica, com as classes Agenda e Contato.

using System;
using System.Collections.Generic;

class Contato
{
    public string Nome;
    public string Telefone;

    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }
}

class Agenda
{
    private List<Contato> contatos = new List<Contato>();

    public void AdicionarContato(Contato c)
    {
        contatos.Add(c);
        Console.WriteLine($"Contato {c.Nome} adicionado com sucesso!");
    }

    public void ListarContatos()
    {
        if (contatos.Count == 0)
        {
            Console.WriteLine("Nenhum contato na agenda.");
            return;
        }

        Console.WriteLine("Contatos na agenda:");
        foreach (var c in contatos)
        {
            Console.WriteLine($"Nome: {c.Nome}, Telefone: {c.Telefone}");
        }
    }

    public void BuscarContato(string nome)
    {
        bool encontrado = false;
        foreach (var c in contatos)
        {
            if (c.Nome.ToLower().Contains(nome.ToLower()))
            {
                Console.WriteLine($"Nome: {c.Nome}, Telefone: {c.Telefone}");
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    public void RemoverContato(string nome)
    {
        Contato contatoARemover = null;
        foreach (var c in contatos)
        {
            if (c.Nome.ToLower() == nome.ToLower())
            {
                contatoARemover = c;
                break;
            }
        }

        if (contatoARemover != null)
        {
            contatos.Remove(contatoARemover);
            Console.WriteLine($"Contato {contatoARemover.Nome} removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        while (true)
        {
            Console.WriteLine("Agenda Telefônica");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Listar contatos");
            Console.WriteLine("3 - Buscar contato");
            Console.WriteLine("4 - Remover contato");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do contato: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o telefone do contato: ");
                    string telefone = Console.ReadLine();
                    agenda.AdicionarContato(new Contato(nome, telefone));
                    break;

                case "2":
                    agenda.ListarContatos();
                    break;

                case "3":
                    Console.Write("Digite o nome para buscar: ");
                    string nomeBusca = Console.ReadLine();
                    agenda.BuscarContato(nomeBusca);
                    break;

                case "4":
                    Console.Write("Digite o nome do contato para remover: ");
                    string nomeRemover = Console.ReadLine();
                    agenda.RemoverContato(nomeRemover);
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
