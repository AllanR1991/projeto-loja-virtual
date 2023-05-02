using System.Globalization;

namespace NucleoPagamento.classes
{
    public class ClassDebito: ClassCartao
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

//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        private float Saldo = 2356;

       
        public override void Pagar()
        {
            ExibeMensagemPulandoLinha($"O valor total a se pago a vista é de: {Valor}");
        if (Saldo >= Valor )
        {
            Console.WriteLine($"O valor {(Valor).ToString("C", new CultureInfo("pt-br"))} vista é {(Valor).ToString("C", new CultureInfo("pt-br"))} ");
            
        }
        else
        {
            Console.WriteLine($"Pagamento invalido");
            
        }
        
        } 

    

    }
}