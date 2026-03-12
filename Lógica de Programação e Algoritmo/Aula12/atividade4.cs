using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Dicionário: código -> (nome, preço)
            Dictionary<int, (string nome, double preco)> produtos =
                new Dictionary<int, (string, double)>()
            {
                {1, ("Cachorro Quente", 4.00)},
                {2, ("Aborgue", 4.50)},
                {3, ("Batata", 5.00)},
                {4, ("Sorvete", 2.00)},
                {5, ("Refrigerante", 1.50)}
            };

            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            var produto = produtos[codigo];

            double total = produto.preco * quantidade;

            Console.WriteLine($"Produto: {produto.nome}");
            Console.WriteLine($"Total: R$ {total:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: digite apenas números.");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Erro: código de produto não existe.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: " + e.Message);
        }
    }
}