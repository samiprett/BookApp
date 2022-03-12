using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class EFBookRepository : IBookRepository 
    {
        private Bookstore1Context context { get; set; }
        public EFBookRepository (Bookstore1Context temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;

        public void SaveBook(Books b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Books b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Books b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
