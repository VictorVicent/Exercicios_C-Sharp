using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração das variáveis
        int a, b, prod;

        // Leitura dos valores inteiros
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());

        // Cálculo do produto
        prod = a * b;

        // Exibição do resultado com formatação
        Console.WriteLine("PROD = " + prod);
    }
}
