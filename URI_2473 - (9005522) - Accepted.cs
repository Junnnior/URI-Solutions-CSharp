using System;

class MainClass {
    public static void Main (string[] args) {
    string entra_a = Console.ReadLine();
    string entra_b = Console.ReadLine();
    // Trasformar entradas em Array's
    string[] a = entra_a.Split(' ');
    string[] b = entra_b.Split(' ');
    
    int total = 0;
    foreach (var valor_a in a)
        foreach (var valor_b in b)
            if (valor_a == valor_b)
                total ++;
    
    if (total < 3)
        Console.WriteLine("azar");
    else if (total == 3)
        Console.WriteLine("terno");
    else if (total == 4)
        Console.WriteLine("quadra");
    else if (total == 5)
        Console.WriteLine("quina");
    else if (total == 6)
        Console.WriteLine("sena");    
    }
}