namespace NucleoPagamento
{
    public class ClassPagamento
    {
        public DateTime Data { get; set; }

        public float Valor;

        public string Cancelar()
        {

            Data = DateTime.Now;
            return @$"
            Operação cancelada 
            {Data}";   
        }
        

    }
}