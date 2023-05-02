using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace NucleoPagamento.classes
{
    public class ClassBoleto : ClassPagamento
    {

        //Criação de Propriedades
         private  string CodigoDeBarra;

        //Criação da função
       
        public void Registrar()
    {
        float ValorDesc = Valor * 0.88f;
        Console.WriteLine ($"O valor do seu boleto com 12% de desconto é {(ValorDesc).ToString("C", new CultureInfo("pt-br"))}");  

        Console.WriteLine($" ");
           
        Random Codigo = new Random();
        int Cod = Codigo.Next(10000,50000);
        int Cod2 = Codigo.Next(100000,500000);
        int Cod3 = Codigo.Next(10000000,500000000);

        Console.WriteLine($"Código de barras do boleto: ");
        
        CodigoDeBarra = $"{Cod}.{Cod} {Cod}.{Cod2} {Cod}.{Cod2} 9 {Cod3}{(ValorDesc).ToString().Replace(",","")}";
        Console.WriteLine($"{CodigoDeBarra}");
        
       
    }
    
    
  
    } 
     
    
}