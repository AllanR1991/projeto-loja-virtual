using System.Globalization;

namespace NucleoPagamento.classes
{
    public class ClassDebito : ClassCartao
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
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        private float Saldo = 975;


        public override void Pagar()
        {
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

            if (Saldo >= Valor)
            {
                Console.WriteLine($"\nO valor a pagar é de {(Valor).ToString("C", new CultureInfo("pt-br"))} sem desconto");
                BarraCarregamento("\nSalvando dados", 5, 500);
                ExibeMensagem("\n");
                ExibeMensagemPulandoLinha("\n_____________________________________________________________");
                ExibeMensagemPulandoLinha($"{SalvarCartao()}");
                ExibeMensagemPulandoLinha("\n_____________________________________________________________");
            }
            else
            {
                ExibeMensagem($"\nNão é possivel realizar o pagamento com cartão de débito ");
                Console.ForegroundColor = ConsoleColor.Red;
                ExibeMensagem("saldo insuficiente.");
                Console.ResetColor();
            }

        }



    }
}