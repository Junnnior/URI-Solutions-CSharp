using System;
class MainClass {
    static void Main () {
    int preco, i;
    preco = 7;
    var consumo = int.Parse(Console.ReadLine());
    
    if (consumo<11)
        Console.WriteLine(preco);
    
    else if (consumo > 10 && consumo <= 30){
        for (i = 10; i<consumo;i++)
            preco += 1;        
    
        Console.WriteLine(preco);
    }
    else if (consumo > 30 && consumo <=100){
        for (i = 20; i<consumo;i++)
            preco += 2;        
    
        Console.WriteLine(preco);
        
    }
    else{
        for (i =0; i<consumo-68;i++)
            preco += 5;        
    
        Console.WriteLine(preco);
    }
  }
}