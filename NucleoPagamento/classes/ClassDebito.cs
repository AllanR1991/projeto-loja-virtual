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

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        private float Saldo = 975;


        public override void Pagar()
        {
            Bandeira = PerguntaString("Digite a bandeira do seu Cartao : ");
            do
            {
            NumeroCartao = PerguntaString("Digite o Numero do Cartao : ");
            } while (NumeroCartao.Length < 13 || NumeroCartao.Length > 16);
            Titular = PerguntaString("Digite o nome do Titular da conta : ");
            do
            {
            Cvv = PerguntaString("Digite o codigo CVV do cartao : ");
            } while (Cvv.Length < 3 || Cvv.Length > 3);

            if (Saldo >= Valor)
            {
                Console.WriteLine($"O valor a pagar é de {(Valor).ToString("C", new CultureInfo("pt-br"))} sem desconto");
                ExibeMensagemPulandoLinha($"{SalvarCartao()}");
            }
            else
            {
                ExibeMensagem($"Não é possivel realizar o pagamento com cartão de débito");
                Console.ForegroundColor = ConsoleColor.Red;
                ExibeMensagem("saldo insuficiente.");
                Console.ResetColor();
            }

        }



    }
}