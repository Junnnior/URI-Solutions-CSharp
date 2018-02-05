using System;

class Uri {
    static void Main () {
    int i,x;
    
    var vezes = int.Parse(Console.ReadLine());
    for (x=0;x<vezes;x++){
        i = 5;
        var entrada = Console.ReadLine();
        // Separa os valores da entrada e passa pra inteiro
        string[] valor = entrada.Split('x');
        var a = int.Parse(valor[0]);
        var b = int.Parse(valor[1]);
        
        if (a==b)
            while (i<11){
                Console.WriteLine(a+" x "+i+" = "+(a*i));
                i++;
            }    
        else
            while (i<11){
                Console.WriteLine(a+" x "+i+" = "+(a*i)+" && "+b+" x "+i+" = "+(b*i));
                i++;
            }   
    }
  }
}