using System;

class MainClass {
    public static void Main (string[] args) {
    var qtd = int.Parse(Console.ReadLine());
    var entrada = Console.ReadLine();
    string[] valor = entrada.Split(' ');
    
    int total_0 = 0;
    int total_1 = 0;
    foreach (string num in valor){
        if (num == "0")
            total_0 ++;
    
        else
            total_1 ++;
    }
    if (total_0+total_1 >= qtd)
        if (total_0 > total_1)
            Console.WriteLine("Y");
        else
            Console.WriteLine("N");
    
  }
}