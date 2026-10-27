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
            {
                Console.WriteLine($"\nКнига с ID {id} не найдена в библиотеке.");
                return;
            }

            if (!book.IsAvaible)
            {
                Console.WriteLine($"\nКнига \"{book.Title}\" уже занята и недоступна.");
                return;
            }

            book.IsAvaible = false;
            Console.WriteLine($"\nВам успешно выдана книга \"{book.Title}\".");
        }

        public void ReturnBook(int id)
        {
            var book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine($"\nКнига с ID {id} не найдена в библиотеке.");
                return;
            }

            if (book.IsAvaible)
            {
                Console.WriteLine($"\nКнига \"{book.Title}\" уже находится в библиотеке (её никто не брал).");
                return;
            }

            book.IsAvaible = true;
            Console.WriteLine($"\nВы успешно вернули книгу \"{book.Title}\".");
        }

        public Book FindBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}
