namespace NucleoPagamento
{
    public class ClassPagamento
    {
        public DateTime Data { get; private set; } = DateTime.Now.Date;

        public float Valor;

        public string Cancelar()
        {
<<<<<<< HEAD
=======

>>>>>>> origin/Kamille
            return @$"
            Operação cancelada 
            {Data}";   
        }
        

    }
}