namespace NucleoPagamento
{
    public class ClassPagamento
    {
        private static DateTime Now;

        public float valor;

        public void Cancelar(string resposta)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Deseja Cancelar a operação? sim/não");
            Console.ResetColor();
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Operação cancelada");
            }

        

            
        }


    }
}