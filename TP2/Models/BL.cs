namespace TP2.Models
{
    public class BL
    {
        public int Id { get; set; }
        public string NumeroBL { get; set; }
        public string Armador { get; set; }
        public DateTime DataEmissao { get; set; }

        public ICollection<Container> Containers { get; set; }
    }
}
