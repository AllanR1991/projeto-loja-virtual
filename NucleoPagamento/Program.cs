﻿using NucleoPagamento.classes;
using NucleoPagamento;
using System.Globalization;

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







/*************************************************************************************************************************/




ClassCredito credito = new ClassCredito();
ClassBoleto boleto = new ClassBoleto();
ClassDebito debito = new ClassDebito();

float limiteAtual = credito.Limite;
string opcao;

ExibeMensagemPulandoLinha(@"
**************************
*                        *
*      Loja Virtual      *
*       Pagamento        *
*                        *
**************************
");

/* BarraCarregamento("Processando", 5, 1000); */

/* float valorCompra = PerguntaFloat("Informe o valor da compra : "); */


/* BarraCarregamento("Aguarde", 10, 1000); */


do
{
    opcao = PerguntaString(@"

***************************
*                         *
*    Escolha uma Opção    *
*      para Pagamento     *
*                         *
***************************
*                         *
* 1) Pagamento em Boleto. *
*                         *
* 2) Pagamento em Cartão  *
*    de Credito.          *
*                         *
* 3) Pagamento em Cartão  *
*    de Débito.           *
*                         *
* 4) Cancelar Operação.   *
*                         *
* 5) Sair do Sistema      *
*                         *
***************************
");

    float testandoValor;
    switch (opcao)
    {
        case "1":
            do
            {
                float.TryParse(PerguntaString("Informe o valor da compra : "), out testandoValor);
                if (testandoValor > 0)
                {
                    boleto.Valor = testandoValor;
                    boleto.Registrar();
                }
            } while (testandoValor <= 0);
            ExibeMensagem($"{testandoValor}");
            break;
        case "2":
            do
            {
                float.TryParse(PerguntaString("Informe o valor da compra : "), out testandoValor);
                if (testandoValor > 0)
                {
                    credito.Valor = testandoValor;
                    credito.Pagar();
                }
            } while (testandoValor <= 0);

            break;
        case "3":
            do
            {
                float.TryParse(PerguntaString("Informe o valor da compra : "), out testandoValor);
                if (testandoValor > 0)
                {
                    debito.Valor = testandoValor;
                    debito.Pagar();
                }
            } while (testandoValor <= 0);
            break;
        case "4":
            if (boleto.Valor != 0)
            {
                ExibeMensagem($"O Boleto no valor de {(boleto.Valor * 0.88f).ToString("C", new CultureInfo("pt-br"))}, foi cancelado com sucesso. ");
                ExibeMensagem($"\n{boleto.Cancelar()}");
                boleto.Valor = 0;
            }
            else if (credito.Valor != 0)
            {
                ExibeMensagem($"A compra no cartao de credito do Srº(ª) foi cancelada com sucesso, favor aguardar o estorno junto a operadora do cartão.");
                ExibeMensagem($"\n{boleto.Cancelar()}");
            }
            else if (debito.Valor != 0)
            {
                ExibeMensagemPulandoLinha($"Realizado estorno na conta conforme os seguintes dados em nosso sistema : ");
                ExibeMensagemPulandoLinha($"{debito.SalvarCartao()}");
                ExibeMensagem($"\n{debito.Cancelar()}");
            }
            break;
        case "5":
            ExibeMensagemPulandoLinha("Obrigado por utilizar nosso sistema, até logo.");
            /* BarraCarregamento("Deslogando da conta", 5, 1000);
            BarraCarregamento("Fechando o sistema", 5, 1000); */
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            ExibeMensagemPulandoLinha("Nenhuma opção foi escolhida, favor escolher uma das seguintes opções");
            Console.ResetColor();
            break;
    }

} while (/* opcao !="1" && opcao !="2" && opcao !="3" && */ opcao != "5");


/* do
{
    opcao = PerguntaString(@"

***************************
*                         *
*    Escolha uma Opção    *
*      para Pagamento     *
*                         *
***************************
*                         *
* 1) Cancelar Operação.   *
*                         *
* 2) Sair do Sistema      *
*                         *
***************************
");

    
    switch (opcao)
    {
        case "1":
            //if(boleto.Valor = )
            credito.Cancelar();
            break;
        case "2":
            ExibeMensagemPulandoLinha("Obrigado por utilizar nosso sistema, até logo.");
            //BarraCarregamento("Deslogando da conta", 5, 1000);
            //BarraCarregamento("Fechando o sistema", 5, 1000);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            ExibeMensagemPulandoLinha("Nenhuma opção foi escolhida, favor escolher uma das seguintes opções");
            Console.ResetColor();
            break;
    }

} while (opcao !="1" && opcao !="2" && opcao !="5") ; */