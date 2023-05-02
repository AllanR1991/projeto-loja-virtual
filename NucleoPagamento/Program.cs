<<<<<<< HEAD
<<<<<<< HEAD
﻿
=======
﻿﻿﻿using NucleoPagamento.classes;
using NucleoPagamento;


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
string opcao;

ExibeMensagemPulandoLinha(@"
**************************
*                        *
*      Loja Virutal      *
*       Pamagento        *
*                        *
**************************
");

/* BarraCarregamento("Processando", 5, 1000); */
 
credito.Valor = boleto.Valor = PerguntaFloat("Informe o valor da compra : ");
=======
using NucleoPagamento;
using NucleoPagamento.classes;

ClassDebito c1 = new ClassDebito();
c1.Valor = 3876;
>>>>>>> Evelyn

/* BarraCarregamento("Aguarde", 10, 1000); */

<<<<<<< HEAD
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

    
    switch (opcao)
    {
        case "1":
            boleto.Registrar();
            break;
        case "2":
            credito.Pagar();
            break;
        case "3":
            //Debito.Pagar();
            break;
        case "4":
            //ExibeMensagemPulandoLinha(Pagamento.Cancelar());
            break;
        case "5":
            ExibeMensagemPulandoLinha("Obrigado por utilizar nosso sistema, até logo.");
            /* BarraCarregamento("Deslogando da conta", 5, 1000);
            BarraCarregamento("Fechando o sistema", 5, 1000); */
            break;
        default:
            ExibeMensagemPulandoLinha("Nenhuma opção foi escolhida, favor escolher uma das seguintes opções");
            break;
    }

} while (opcao !="5");

>>>>>>> origin/Allan
=======
c1.Pagar();
>>>>>>> Evelyn
