using System;
using System.Collections.Generic;
using System.Linq;
using TP1.Interfaces;
using TP1.Models;

// Laysa Bernardes e Lucas Lopes

namespace TP1.Repositories
{
    public class FakeBookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();

        public FakeBookRepository()
        {
            // Instanciando autores
            var autor1 = new Author("Erich Gamma", "erich@gof.com", 'M');
            var autor2 = new Author("Richard Helm", "richard@gof.com", 'M');

            // Instanciando um livro com mais de um autor
            var book = new Book("Design Patterns", new[] { autor1, autor2 }, 200.00, 3);

            // Adicionando o livro à lista
            _books.Add(book);

            // Demonstração do uso de todos os métodos da classe Book
            Console.WriteLine("Demonstração dos métodos da classe Book:");
            Console.WriteLine("getName(): " + book.getName());

            Console.WriteLine("getAuthors():");
            foreach (var author in book.getAuthors())
            {
                Console.WriteLine("  " + author.ToString());
            }

            Console.WriteLine("getPrice(): " + book.getPrice());
            Console.WriteLine("getQty(): " + book.getQty());

            // Alterando preço e quantidade
            book.setPrice(180.00);
            book.setQty(5);

            Console.WriteLine("Após setPrice(180.00) e setQty(5):");
            Console.WriteLine("getPrice(): " + book.getPrice());
            Console.WriteLine("getQty(): " + book.getQty());

            Console.WriteLine("getAuthorNames(): " + book.getAuthorNames());
            Console.WriteLine("ToString(): " + book.ToString());
            Console.WriteLine("\n");
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public ICollection<Book> GetAllBooks()
        {
            return _books;
        }
    }
}