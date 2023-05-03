namespace NucleoPagamento
{
    public class ClassPagamento
    {
        private DateTime Data {get; set;} = DateTime.Now;

        public float Valor;

        public string Cancelar()
        {
            return @$"
            Operação cancelada 
            {Data:d}";   
        }
    }
}