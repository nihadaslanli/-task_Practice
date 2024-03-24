using Homework.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _task_Practice.Entities
{
    internal class Library:IEntitiy
    {
        public int Id { get; set; }
        public int BookLimit { get; set; }
         List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            var existBook = Books.Find(b=>b.Name==book.Name&& !b.IsDelete);
            if (existBook != null)
            {
                throw new AlreadyExistsException($"{book.Name} artiq movcuddur");
            }
            Books.Add(book);   
        }
    }
}
