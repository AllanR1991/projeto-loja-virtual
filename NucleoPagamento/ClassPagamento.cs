namespace NucleoPagamento
{
    public class ClassPagamento
    {
        public DateTime Data { get; set; }

        public float valor;

        public string Cancelar()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Data = DateTime.Now;
            return @$"
            Operação cancelada 
            {Data}";
        }

    }
}