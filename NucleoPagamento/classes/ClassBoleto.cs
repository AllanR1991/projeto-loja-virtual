using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace NucleoPagamento.classes
{
    public class ClassBoleto : ClassPagamento
    {
        static string PerguntaString(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }

        static char PerguntaChar(string pergunta)
        {
            Console.WriteLine(pergunta);
            return char.Parse(Console.ReadLine());
        }

        static int PerguntaInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }

        static float PerguntaFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            return float.Parse(Console.ReadLine());
        }

        static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }

        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            ExibeMensagem(texto);
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                ExibeMensagem(".");
                Thread.Sleep(tempo);
            }
        }

        //Criação de Propriedades
         private  string CodigoDeBarra;


        //Criação da função

         public string Rnd( int n1,int n2)
         {
            Random Codigo = new Random();
            int valorGerado = Codigo.Next( n1, n2);

            if (valorGerado < 10)
            {
                return( "0000" + valorGerado);
            }
            else if (valorGerado < 100)
            {
                return ("000"+valorGerado);
            }
            else if (valorGerado < 1000)
            {
                return ("00" + valorGerado);

            } else if (valorGerado < 10000)
            {
                return ("0" + valorGerado);
            } 
            return(""+valorGerado);
            
         }
        
       
        public void Registrar()
    {
        float ValorDesc = Valor * 0.88f;
        Console.WriteLine ($"\nO valor da sua compra é {(Valor).ToString("C", new CultureInfo("pt-br"))}, para pagamento via boleto você ganha 12% de desconto você pagará apenas: {(ValorDesc).ToString("C", new CultureInfo("pt-br"))}");  

        Console.WriteLine($" ");
           
        Random Codigo = new Random();
        Codigo.Next( 0, 9);
        
        CodigoDeBarra = $"{Rnd(00001,50000)}.{Rnd(00001,50000)} {Rnd(00001,50000)}.{Rnd(100000,500000)} {Rnd(00001,50000)}.{Rnd(100000,500000)} {Codigo.Next( 0, 9)} {Rnd(10000000,500000000)}{(ValorDesc).ToString("N2", CultureInfo.InvariantCulture).Replace(".","").Replace(",","")}";

        BarraCarregamento("\nGerando boleto", 5, 500);
        ExibeMensagem("\n");

        ExibeMensagemPulandoLinha("\n_____________________________________________________________");
        Console.WriteLine($"\nCódigo de barras do boleto: ");
        Console.WriteLine($"{CodigoDeBarra}");
        ExibeMensagemPulandoLinha("\n_____________________________________________________________");
        
       
    }
    
    
  
    } 
     
    
}