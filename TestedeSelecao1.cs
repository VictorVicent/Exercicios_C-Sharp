using System; 

class URI {

    static void Main(string[] args) { 

    string[] input = Console.ReadLine().Split(' ');
    double A = double.Parse(input[0]);
    double B = double.Parse(input[1]);
    double C = double.Parse(input[2]);
    double D = double.Parse(input[3]);
        
    if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && (A % 2) == 0){
        Console.WriteLine("Valores aceitos");
    } else{
        Console.WriteLine("Valores nao aceitos");
    }

    }

}