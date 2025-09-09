using System.Linq;

// Laysa Bernardes Campos da Rocha -  CB3024873
// Lucas Lopes Cruz - CB3025284

namespace TP01.Models
{
    public class Book
    {
        public string Name { get; private set; }
        public Author[] Authors { get; private set; }
        public double Price { get; private set; }
        public int Qty { get; private set; }

        public Book(string name, Author[] authors, double price, int qty = 0)
        {
            Name = name;
            Authors = authors;
            Price = price;
            Qty = qty;
        }

        public void SetPrice(double price) => Price = price;
        public void SetQty(int qty) => Qty = qty;

        public string GetAuthorNames() =>
            string.Join(", ", Authors.Select(a => a.Name));

        public override string ToString()
        {
            var authors = string.Join(", ", Authors.Select(a => a.ToString()));
            return $"Book[name={Name}; authors={{{authors}}}; price={Price:0.00}; qty={Qty}]";
        }
    }
}
