using System;

class MainClass {
public static void Main (string[] args) {
string[] relogio = new string[] {
" ____________________________________________",
"|                                            |",
"|    ____________________________________    |_",
"|   |                                    |   |_)",
"|   |   8         4         2         1  |   |",
"|   |                                    |   |",
"|   |                                    |   |",
"|   |                                    |   |",
"|   |                                    |   |",
"|   |                                    |   |",
"|   |                                    |   |",
"|   |   32    16    8     4     2     1  |   |_",
"|   |____________________________________|   |_)",
"|                                            |",
"|____________________________________________|"};

// INCIO DO DA QUESTÃO
string entrada;	
while((entrada = Console.ReadLine()) != null && entrada != ""){
	var entrada_ = entrada.Split(':');
    int num = Convert.ToInt32(entrada_[0]);
    int minuto = Convert.ToInt32(entrada_[1]);
    
    // converter hora para binario
    string valor;
    valor = "";
    int resto = 0;
	while (true){
	resto = num / 2;
	var aux = num-(resto*2);
	valor += Convert.ToString(aux);
	num = num / 2; 
	if (num <= 0){
		break;}
	}
	// organiza horas
	if (valor.Length == 3)
		valor += '0';
	else if (valor.Length == 2)
		valor += "00";
	else if (valor.Length == 1)
		valor += "000";	
	
    char[] hora_final = valor.ToCharArray();
    Array.Reverse(hora_final);
    
    
    var hora_saida = "|   |";
    
    if (hora_final[0] == '1')
        hora_saida += "   o";
    else
        hora_saida += "    ";
        
    if (hora_final[1] == '1')
        hora_saida += "         o";
    else
        hora_saida += "          ";
     
    if (hora_final[2] == '1')
        hora_saida += "         o";
    else
        hora_saida += "          ";
        
    if (hora_final[3] == '1')
        hora_saida += "         o  |   |";
    else
        hora_saida += "            |   |";
    
    
    // converter minutos para binario
    
    valor = "";
    resto = 0;
	while (true){
	resto = minuto / 2;
	var aux = minuto-(resto*2);
	valor += Convert.ToString(aux);
	minuto = minuto / 2; 
	if (minuto <= 0){
		break;}
	}
	// organiza minutos
	if (valor.Length == 5)
		valor += '0';
	else if (valor.Length == 4)
		valor += "00";
	else if (valor.Length == 3)
		valor += "000";	
	else if (valor.Length == 2)
		valor += "0000";
	else if (valor.Length == 1)
		valor += "00000";		
	
    char[] minuto_final = valor.ToCharArray();
    Array.Reverse(minuto_final);
    
    var minuto_saida = "|   |";
    
    // Marca Minutos:
    if (minuto_final[0] == '1')
        minuto_saida+= "   o";
    else
        minuto_saida += "    ";
        
    for (int a=1;a<5;a++){
        if (minuto_final[a] == '1')
            minuto_saida+= "     o";
        else
            minuto_saida += "      ";
    }        
    if (minuto_final[5] == '1')
        minuto_saida += "     o  |   |";
    else
        minuto_saida += "        |   |";
        

	// Saida do problema    
	for (int i = 0;i<relogio.Length;i++){
		if (i == 6){
	    	Console.WriteLine(hora_saida);}
	    else if (i == 9){
	    	Console.WriteLine(minuto_saida);}
	    else
	    	Console.WriteLine(relogio[i]);
		    
		}
	Console.WriteLine();	
	}
  }
}