namespace TP2.Models
{
    public class Container
    {
        public int Id { get; set; }
        public string NumeroContainer { get; set; }
        public string Tipo { get; set; }
        public int Tamanho { get; set; }

        public int BLId { get; set; }
        public BL BL { get; set; }
    }

}
