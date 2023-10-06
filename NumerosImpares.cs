using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura do valor inteiro X
        int X = Convert.ToInt32(Console.ReadLine());

        // Loop para encontrar e imprimir os números ímpares
        for (int i = 1; i <= X; i++)
        {
            // Verificar se o número é ímpar
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}