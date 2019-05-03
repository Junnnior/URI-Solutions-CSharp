using System;
using System.Collections.Generic;
class URI_1234 {
    public static void Main (string[] args) {
    string numeros = "0123456789";
    string entrada;
    
    while((entrada = Console.ReadLine()) != null && entrada != ""){
        int i = 1;
        int j = 0;
        string lista_final = "";
        
        while (j < entrada.Length){
            bool tem_num = true;
            foreach (var num in numeros){
                if (entrada[j] == num){
                    lista_final += num;
                    tem_num = false;
                    break;
                }
            }
        
            if (tem_num == true){
                if (entrada[j] == ' '){
                    lista_final += ' ';
                
                } else if (i % 2 != 0){
                    var letra_Maiuscula = char.ToUpper(entrada[j]);
                    lista_final+= letra_Maiuscula;
                    i ++;
                
                } else if (i % 2 == 0){
                    var letra_Minuscula = char.ToLower(entrada[j]);
                    lista_final+=letra_Minuscula;
                    i ++;
                }
            }
        
            j ++;
        }
    
        Console.WriteLine(lista_final);
    }
  }
}
