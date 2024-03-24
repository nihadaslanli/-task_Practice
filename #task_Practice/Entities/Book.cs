using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _task_Practice.Entities
{
    internal class Book : IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDelete { get; internal set; }

        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
        public override string ToString()
        {
            return $"Id:{Id}Name:{Name}, AuthorName:{AuthorName},PageCount:{PageCount}";
        }
    }
}
