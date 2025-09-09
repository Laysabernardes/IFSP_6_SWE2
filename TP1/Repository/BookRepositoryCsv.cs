using Newtonsoft.Json;
using TP01.Interface;
using TP01.Models;

// Laysa Bernardes Campos da Rocha -  CB3024873
// Lucas Lopes Cruz - CB3025284

namespace TP01.Repository
{
    public class BookRepositoryCsv : IBookRepository
    {
        private static readonly string FilePath = "books.csv";
        private List<Book> _books = new();

        public BookRepositoryCsv() => LoadBooksCsv();

        public ICollection<Book> GetAll() => _books;

        public void Add(Book book)
        {
            var authorsJson = JsonConvert.SerializeObject(book.Authors);
            File.AppendAllText(FilePath, $"{book.Name};{authorsJson};{book.Price};{book.Qty}\n");
            _books.Add(book);
        }

        private void LoadBooksCsv()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Dispose();
                return;
            }

            foreach (var line in File.ReadLines(FilePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(';');
                var authors = JsonConvert.DeserializeObject<Author[]>(parts[1]) ?? Array.Empty<Author>();

                _books.Add(new Book(
                    parts[0],
                    authors,
                    Convert.ToDouble(parts[2]),
                    Convert.ToInt32(parts[3])
                ));
            }
        }
    }
}
