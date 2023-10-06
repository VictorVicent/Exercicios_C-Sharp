using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            // Verificar se o número é par
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}