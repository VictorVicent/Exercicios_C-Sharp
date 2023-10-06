using System;

class Program
{
    static void Main(string[] args)
    {

        int X = Convert.ToInt32(Console.ReadLine());
        int Y = Convert.ToInt32(Console.ReadLine());

        int somaImpares = 0;


        if (X > Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        for (int i = X + 1; i < Y; i++)
        {
            if (i % 2 != 0)
            {
                somaImpares += i;
            }
        }

        Console.WriteLine(somaImpares);
    }
}