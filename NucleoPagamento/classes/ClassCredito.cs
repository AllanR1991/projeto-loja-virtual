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

        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            ExibeMensagem(texto);
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                ExibeMensagem(".");
                Thread.Sleep(tempo);
            }
        }


        /*Atributo*/
        public float Limite { get; private set; } = 6000;
        /*Acessando Metodo da classe abstrata*/
        public override void Pagar()
        {

            int parcelas;
            int minParcelas = 1;
            int maxParcelas = 12;



            Bandeira = PerguntaString("\nDigite a bandeira do seu cartão : ");
            do
            {
                NumeroCartao = PerguntaString("\nDigite o número do cartão : ");
                if (NumeroCartao.Length < 13 || NumeroCartao.Length > 16)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ExibeMensagemPulandoLinha("\nNúmero do cartão inválido");
                    Console.ResetColor();
                }
            } while (NumeroCartao.Length < 13 || NumeroCartao.Length > 16);
            Titular = PerguntaString("\nDigite o nome do titular da conta : ");
            do
            {
                Cvv = PerguntaString("\nDigite o codigo CVV do cartão : ");
                if (Cvv.Length < 3 || Cvv.Length > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ExibeMensagemPulandoLinha("\nNúmero do Cvv inválido");
                    Console.ResetColor();
                }
            } while (Cvv.Length < 3 || Cvv.Length > 3);
            if (Valor > Limite)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                ExibeMensagemPulandoLinha("\nO Srº(ª) não possui limite suficiente no cartão para compras.\n");
                Console.ResetColor();
                Valor = 0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ExibeMensagem(@$"

*****************************************
*                                       *
*          Juros do Cartão              *
*                                       *
* - Pagamento em até 6X no cartão com   *    
*   juros de 5%.                        *   
*                                       *
* - Pagamento em 7X ate 12X no cartão   *
*   com juros de 8%                     *
*                                       *
*****************************************

");
                Console.ResetColor();

                do
                {

                    int.TryParse(PerguntaString(@$"
Em quantas vezes deseja pagar o valor de {Valor.ToString("C", new CultureInfo("pt-br"))} :
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
                    if (Limite > (Valor * 1.05))
                    {
                        ExibeMensagemPulandoLinha(@$"
O valor de {(Valor).ToString("C", new CultureInfo("pt-br"))} parcelado em {parcelas} {vezes}, da um total a pagar de {(Valor * 1.05).ToString("C", new CultureInfo("pt-br"))}, sendo cada parcela no valor de {((Valor * 1.05) / parcelas).ToString("C", new CultureInfo("pt-br"))}.
");
                        BarraCarregamento("\nSalvando dados", 5, 500);
                        ExibeMensagem("\n");
                        ExibeMensagemPulandoLinha("\n_____________________________________________________________");
                        ExibeMensagemPulandoLinha($"{SalvarCartao()}");
                        ExibeMensagemPulandoLinha("\n_____________________________________________________________");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ExibeMensagemPulandoLinha("\nO Srº(ª) não possui limite suficiente no cartão para compras.\n");
                        Console.ResetColor();
                        Valor = 0;
                    }
                }
                else
                {
                    if (Limite > (Valor * 1.08))
                    {
                        ExibeMensagemPulandoLinha(@$"
O valor de {(Valor).ToString("C", new CultureInfo("pt-br"))} parcelado em {parcelas} {vezes}, da um total a pagar de {(Valor * 1.08).ToString("C", new CultureInfo("pt-br"))}. Sendo cada parcela no valor de {((Valor * 1.08) / parcelas).ToString("C", new CultureInfo("pt-br"))}.
");
                        BarraCarregamento("\nSalvando dados", 5, 500);
                        ExibeMensagem("\n");
                        ExibeMensagemPulandoLinha("\n_____________________________________________________________");
                        ExibeMensagemPulandoLinha($"{SalvarCartao()}");
                        ExibeMensagemPulandoLinha("\n_____________________________________________________________");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ExibeMensagemPulandoLinha("\nO Srº(ª) não possui limite suficiente no cartão para compras.\n");
                        Console.ResetColor();
                        Valor = 0;
                    }

                }
            }
        }
    }
}