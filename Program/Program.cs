using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "";
            int quartos = 0;
            double produto = 0;
            
            // Vetores
            string [] vetdados = Console.ReadLine().Split(' ');
            string sobrenome = vetdados[0];
            int idade = int.Parse(vetdados[1]);
            double altura = double.Parse(vetdados[2]);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            Console.ReadLine();
            Console.WriteLine("Entre com o preço de um produto: ");
            Console.ReadLine();
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Produto: " + produto);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);

        }
    }
}
