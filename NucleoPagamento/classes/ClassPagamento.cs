namespace NucleoPagamento
{
    public class ClassPagamento
    {
        public DateTime Data { get; set; }

        public float valor;

        public string Cancelar()
        {

            Data = DateTime.Now;
            return @$"
            Operação cancelada 
            {Data}";   
        }
        

    }
}