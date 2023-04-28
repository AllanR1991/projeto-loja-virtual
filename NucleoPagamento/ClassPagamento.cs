namespace NucleoPagamento
{
    public class ClassPagamento
    {
       
       private var date = DateTime.Now;

       public float valor;


        static void Cancelar(string resposta)
       {
         Console.WriteLine($"Deseja Cancelar a operação? sim/não");
          resposta = Console.ReadLine();

         if (resposta == "sim")
         {
            Console.WriteLine($"Cancelando");
            
         }
          
       }


    }
}