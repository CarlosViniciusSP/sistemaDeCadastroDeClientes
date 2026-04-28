using System;
using System.Collections.Generic;

class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static int idAtual = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Sistema de Clientes ===");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Adicionar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Remover");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": Listar(); break;
                case "2": Adicionar(); break;
                case "3": Editar(); break;
                case "4": Remover(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }
    }

    static void Listar()
    {
        Console.WriteLine("\n--- Clientes ---");
        foreach (var c in clientes)
        {
            Console.WriteLine($"ID: {c.Id} | Nome: {c.Nome} | Email: {c.Email}");
        }
    }

    static void Adicionar()
    {
        Console.Write("Nome: ");
        var nome = Console.ReadLine();

        Console.Write("Email: ");
        var email = Console.ReadLine();

        clientes.Add(new Cliente
        {
            Id = idAtual++,
            Nome = nome,
            Email = email
        });

        Console.WriteLine("Cliente adicionado!");
    }

    static void Editar()
    {
        Console.Write("ID do cliente: ");
        int id = int.Parse(Console.ReadLine());

        var cliente = clientes.Find(c => c.Id == id);

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado!");
            return;
        }

        Console.Write("Novo nome: ");
        cliente.Nome = Console.ReadLine();

        Console.Write("Novo email: ");
        cliente.Email = Console.ReadLine();

        Console.WriteLine("Cliente atualizado!");
    }

    static void Remover()
    {
        Console.Write("ID do cliente: ");
        int id = int.Parse(Console.ReadLine());

        var cliente = clientes.Find(c => c.Id == id);

        if (cliente != null)
        {
            clientes.Remove(cliente);
            Console.WriteLine("Cliente removido!");
        }
        else
        {
            Console.WriteLine("Cliente não encontrado!");
        }
    }
}