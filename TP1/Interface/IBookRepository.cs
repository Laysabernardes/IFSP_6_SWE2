using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

// Laysa Bernardes Campos da Rocha -  CB3024873
// Lucas Lopes Cruz - CB3025284


namespace TP01.Interface
{
    public interface IBookRepository
    {
        ICollection<Book> GetAll();
        void Add(Book book);
    }

}
