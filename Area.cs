using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');
        double A = double.Parse(input[0]);
        double B = double.Parse(input[1]);
        double C = double.Parse(input[2]);

        double triangleArea = 0.5 * A * C;
        double circleArea = 3.14159 * C * C;
        double trapeziumArea = 0.5 * (A + B) * C;
        double squareArea = B * B;
        double rectangleArea = A * B;

        Console.WriteLine("TRIANGULO: " + triangleArea.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circleArea.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapeziumArea.ToString("F3"));
        Console.WriteLine("QUADRADO: " + squareArea.ToString("F3"));
        Console.WriteLine("RETANGULO: " + rectangleArea.ToString("F3"));

    }

}