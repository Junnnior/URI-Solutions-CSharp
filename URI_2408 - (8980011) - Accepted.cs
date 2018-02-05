using System;
class MainClass {
    static void Main() {
        int vice;
    
        var valores_aux = Console.ReadLine();
        string[] valores = valores_aux.Split(' ');
    
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        
        if ((a<b && c<a) || (a>b && c>a))
            vice=a;
    
        else if ((b<a && b>c) || (b>a && b<c))
            vice=b;
    
        else
            vice = c;
    
    Console.WriteLine(vice);
   
  }
}