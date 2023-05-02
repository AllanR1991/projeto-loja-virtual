namespace NucleoPagamento
{
    public class ClassPagamento
    {
        public DateTime Data { get; private set; } = DateTime.Now.Date;

        public float Valor;

        public string Cancelar()
        {
            return @$"
            Operação cancelada 
            {Data}";   
        }
    }
}