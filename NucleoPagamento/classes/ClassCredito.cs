using System.Globalization;

namespace NucleoPagamento.classes
{
    public class ClassCredito : ClassCartao
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

        /*Atributo*/
        private float Limite = 6000;

        public float valor = 200;
        /*Acessando Metodo da classe abstrata*/
        public override void Pagar()
        {

            int parcelas;
            int minParcelas = 1;
            int maxParcelas = 12;


            if (valor > Limite)
            {
                ExibeMensagemPulandoLinha("O Srº(ª) não possui mais limite para compras.");
            }
            else
            {
                ExibeMensagem(@$"

*****************************************
*                                       *
*          Juros do Cartão              *
*                                       *
* - Pagamento em até 6X no cartao com   *    
*   juros de 5%.                        *   
*                                       *
* - Pagamento em 7X ate 12X no cartao   *
*    com juros de 8%                    *
*                                       *
*****************************************

");

                do
                {
                    /* parcelas = PerguntaInt(@$"
                    Em quantas vezes deseja pagar o valor de {valor} : 
                    "); */
                    int.TryParse(PerguntaString(@$"
Em quantas vezes deseja pagar o valor de {valor} :
"), out parcelas);

                    if (parcelas < minParcelas || parcelas > maxParcelas)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ExibeMensagemPulandoLinha("\nA quantidade de parcelas digitadas é invalida, favor ditigar um número entre 1 e 12.");
                        Console.ResetColor();
                    }
                } while (parcelas < minParcelas || parcelas > maxParcelas);

                string vezes = "vezes";
                if (parcelas == 1)
                {
                    vezes = "vez";
                }

                if (parcelas <= 6)
                {

                    ExibeMensagemPulandoLinha(@$"
O valor de {(valor).ToString("C", new CultureInfo("pt-br"))} parcelado em {parcelas} {vezes}, da um total a pagar de {(valor * 1.05).ToString("C", new CultureInfo("pt-br"))}.
");
                }
                else
                {
                    ExibeMensagemPulandoLinha(@$"
O valor de {(valor).ToString("C", new CultureInfo("pt-br"))} parcelado em {parcelas} {vezes}, da um total a pagar de {(valor * 1.08).ToString("C", new CultureInfo("pt-br"))}.
");
                }

            }

        }

    }
}