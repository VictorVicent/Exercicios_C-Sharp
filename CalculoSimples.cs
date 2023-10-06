using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        string[] peca1 = Console.ReadLine().Split(' ');
        int codigoPeca1 = int.Parse(peca1[0]);
        int quantidadePeca1 = int.Parse(peca1[1]);
        double valorUnitarioPeca1 = double.Parse(peca1[2]);

        string[] peca2 = Console.ReadLine().Split(' ');
        int codigoPeca2 = int.Parse(peca2[0]);
        int quantidadePeca2 = int.Parse(peca2[1]);
        double valorUnitarioPeca2 = double.Parse(peca2[2]);

        double totalPagar = (quantidadePeca1 * valorUnitarioPeca1) + (quantidadePeca2 * valorUnitarioPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2"));
    }
}