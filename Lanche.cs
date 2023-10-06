using System; 

class URI {

    static void Main(string[] args) { 

string[] lanche = Console.ReadLine().Split(' ');
int codigo = int.Parse(lanche[0]);
int quantidade = int.Parse(lanche[1]);
double total;

if (codigo == 1){
    total = quantidade * 4.00;
    string res = String.Format("Total: R$ {0:N2}",total);
    Console.WriteLine(res);
}
else if (codigo == 2){
    total = quantidade * 4.50;
    string res = String.Format("Total: R$ {0:N2}",total);
    Console.WriteLine(res);
}
else if (codigo == 3){
    total = quantidade * 5.00;
    string res = String.Format("Total: R$ {0:N2}",total);
    Console.WriteLine(res);
}
else if (codigo == 4){
    total = quantidade * 2.00;
    string res = String.Format("Total: R$ {0:N2}",total);
    Console.WriteLine(res);
}
else{
    total = quantidade * 1.50;
    string res = String.Format("Total: R$ {0:N2}",total);
    Console.WriteLine(res);
}


    }

}