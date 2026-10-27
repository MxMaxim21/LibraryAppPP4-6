using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Library = new Book();
            Library.AddBook(new Book { Id = 1, Title = "Идиот", Author = "Достоевский", IsAvaible = true });
            Library.AddBook(new Book { Id = 2, Title = "Ромео и Джульетта", Author = "Шекспир", IsAvaible = false });
            Library.AddBook(new Book { Id = 3, Title = "Гадкий утенок", Author = "Андерсен", IsAvaible = true });

            Library.BorrowBook(1);
            Library.BorrowBook(2);

            Library.ReturnBook(2);
            Library.BorrowBook(1);
        }
    }
}
