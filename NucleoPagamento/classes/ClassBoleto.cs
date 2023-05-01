using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace NucleoPagamento.classes
{
    public class ClassBoleto
    {

        //Criação de Propriedades
         private  string codigoDeBarra;
         

        public float valor = 1015f;

        //Criação da função
       
        public void Registrar()
    {
        float valorDesc = valor * 0.88f;
        Console.WriteLine ($"O valor do seu boleto com 12% de desconto é {(valorDesc).ToString("C", new CultureInfo("pt-br"))}");  

        Console.WriteLine($" ");
           
        Random codigo = new Random();
        int cod = codigo.Next(10000,50000);
        int cod2 = codigo.Next(100000,500000);
        int cod3 = codigo.Next(10000000,500000000);

        Console.WriteLine($"Código de barras do boleto: ");
        
        Console.WriteLine($"{cod}.{cod} {cod}.{cod2} {cod}.{cod2} 9 {cod3}{valorDesc}");
       
    }
    
    
  
    } 
     
    
}