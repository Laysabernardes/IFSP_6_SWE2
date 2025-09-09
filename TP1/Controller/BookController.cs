using Microsoft.AspNetCore.Http;
using TP01.Interface;
using TP01.Models;
using TP01.Repository;

// Laysa Bernardes Campos da Rocha -  CB3024873
// Lucas Lopes Cruz - CB3025284
namespace TP01.Controller
{
    public class BookController
    {
        private readonly IBookRepository _repo = new BookRepositoryCsv();

        public BookController() => EnsureInitialData();

        private void EnsureInitialData()
        {
            if (_repo.GetAll().Count == 0)
            {
                var authors = new[]
                {
                    new Author("Stephen King", "stephenking@example.com", 'm'),
                    new Author("Suzanne Collins", "suzannecollins@example.com", 'f')
                };
                _repo.Add(new Book("Jogos Vorazes em Chamas", authors, 50.04, 180));
            }
        }

        public void ShowTests()
        {
            var authors = new[]
            {
                new Author("Stephen King", "stephenking@example.com", 'm'),
                new Author("Neil Gaiman", "neilgaiman@example.com", 'm')
            };

            var book = new Book("Depois", authors, 50.04, 100);

            Console.WriteLine($"Nome do livro: {book.Name}");
            Console.WriteLine($"Autores: {book.GetAuthorNames()}");
            Console.WriteLine($"Preço: {book.Price}");
            Console.WriteLine($"Quantidade: {book.Qty}");

            book.SetPrice(24.99);
            book.SetQty(50);

            Console.WriteLine($"Novo preço: {book.Price}");
            Console.WriteLine($"Nova quantidade: {book.Qty}");
            Console.WriteLine(book);
        }

        public Task GetNameBook(HttpContext ctx) =>
            ctx.Response.WriteAsync(_repo.GetAll().First().Name);

        public Task GetBook(HttpContext ctx) =>
            ctx.Response.WriteAsync(_repo.GetAll().First().ToString());

        public Task GetAuthorsBook(HttpContext ctx) =>
            ctx.Response.WriteAsync(_repo.GetAll().First().GetAuthorNames());

        public Task GetHtmlBook(HttpContext ctx)
        {
            var book = _repo.GetAll().First();
            var authors = string.Join("", book.Authors.Select(a => $"<li>{a.Name}</li>"));
            return ctx.Response.WriteAsync($@"
                <h1>{book.Name}</h1>
                <strong>Autores:</strong>
                <ol>{authors}</ol>");
        }
    }
}
