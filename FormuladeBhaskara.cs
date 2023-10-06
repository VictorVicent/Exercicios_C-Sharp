using System; 

class URI {

    static void Main(string[] args) { 

    string[] input = Console.ReadLine().Split(' ');
    double A = double.Parse(input[0]);
    double B = double.Parse(input[1]);
    double C = double.Parse(input[2]);
    double delta = (Math.Pow(B,2)) - (4 * A * C);
    string R1 = String.Format("R1 = {0:N5}", ((-B) + (Math.Sqrt(delta))) / (2*A));
    string R2 = String.Format("R2 = {0:N5}", ((-B) - (Math.Sqrt(delta))) / (2*A));
    
    if (A != 0 && delta > 0){
        Console.WriteLine(R1);
        Console.WriteLine(R2);
    }else{
        Console.WriteLine("Impossivel calcular");
    }

    }

}