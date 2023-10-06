using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura do valor inteiro N
        int N = Convert.ToInt32(Console.ReadLine());

        // Variáveis para contar os valores dentro e fora do intervalo
        int dentroIntervalo = 0;
        int foraIntervalo = 0;

        // Loop para ler os valores e verificar se estão dentro ou fora do intervalo
        for (int i = 0; i < N; i++)
        {
            int X = Convert.ToInt32(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                dentroIntervalo++;
            }
            else
            {
                foraIntervalo++;
            }
        }

        // Exibição do resultado
        Console.WriteLine(dentroIntervalo + " in");
        Console.WriteLine(foraIntervalo + " out");
    }
}