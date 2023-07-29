
namespace SomaEMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de números a serem informados que sejam entre 3 e 10:");
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            // Validar quantidade de números informada
            if (quantidadeNumeros < 3 || quantidadeNumeros > 10)
            {
                Console.WriteLine("Quantidade inválida, digite um número entre 3 e 10.");
            }

            // Criar array para armazenar os números informados
            decimal[] numeros = new decimal[quantidadeNumeros];

            // Ler números informados pelo usuário
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write($"Informe o {i+1}º número: ");
                numeros[i] = decimal.Parse(Console.ReadLine());
            }

            // Calcular a soma dos valores
            decimal soma = CalcularSoma(numeros);

            // Calcular a média dos valores
            decimal media = CalcularMedia(numeros);

            // Imprimir resultado
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.ReadKey();
        }

        static decimal CalcularSoma(decimal[] numeros)
        {
            decimal soma = 0;

            foreach (decimal numero in numeros)
            {
                soma += numero;
            }

            return soma;
        }

        static decimal CalcularMedia(decimal[] numeros)
        {
            decimal soma = CalcularSoma(numeros);

            decimal media = soma / numeros.Length;

            return media;
        }
    }
}

