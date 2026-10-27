using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public bool IsAvaible { get; set; } = true;

        private readonly List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book == null) 
            Console.WriteLine(nameof(book));
            books.Add(book);
        }

        public void BorrowBook(int id)
        {
            var book = FindBook(id);
            if (book == null)
                Console.WriteLine($"\nКнига \"{book.Title}\" не найдена в библиотеке.");
            if (book.IsAvaible == false)
                Console.WriteLine($"\nКнига \"{book.Title}\" не доступна.");
            else
                Console.WriteLine($"\nВам выдана книга \"{book.Title}\"");
                book.IsAvaible = false;
        }

        public void ReturnBook(int id)
        {
            var book = FindBook(id);
            if (book == null)
                Console.WriteLine($"\nКнига \"{book.Title}\" не найдена в библиотеке.");
            if (book.IsAvaible == true)
                Console.WriteLine($"\nКнига \"{book.Title}\" уже доступна.");
            else
                Console.WriteLine($"\nВы вернули книгу \"{book.Title}\"");
                book.IsAvaible = true;
        }

        public Book FindBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}
