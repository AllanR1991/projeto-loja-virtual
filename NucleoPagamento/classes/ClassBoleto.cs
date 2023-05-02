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
         private  string CodigoDeBarra;
         

        public float Valor = 1015f;

        //Criação da função
       
        public void Registrar()
    {
        float ValorDesc = Valor * 0.88f;
        Console.WriteLine ($"O valor da sua compra é {(Valor).ToString("C", new CultureInfo("pt-br"))}, para pagamento via boleto com 12% de desconto você pagará: {(ValorDesc).ToString("C", new CultureInfo("pt-br"))}");  

        Console.WriteLine($" ");
           
        Random Codigo = new Random();
        
        Console.WriteLine($"Código de barras do boleto: ");
        
        CodigoDeBarra = $"{Codigo.Next(10000,50000)}.{Codigo.Next(10000,50000)} {Codigo.Next(10000,50000)}.{Codigo.Next(100000,500000)} {Codigo.Next(10000,50000)}.{Codigo.Next(100000,500000)} 9 {Codigo.Next(10000000,500000000)}{(ValorDesc).ToString("N2", CultureInfo.InvariantCulture).Replace(".","")}";
        Console.WriteLine($"{CodigoDeBarra}");
        
       
    }
    
    
  
    } 
     
    
}