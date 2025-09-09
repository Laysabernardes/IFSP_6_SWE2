using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;

// Laysa Bernardes e Lucas Lopes

namespace TP1.Interfaces
{
    public interface IBookRepository
    {
        ICollection<Book> GetAllBooks();
        void AddBook(Book book);
    }
}
