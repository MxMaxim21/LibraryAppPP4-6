using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    /// <summary>Библиотека: хранит книги, выдаёт и принимает их обратно.</summary>
    public class Library
    {
        private readonly List<Book> books = new List<Book>();

        /// <summary>Добавляет книгу в библиотеку.</summary>
        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            books.Add(book);
        }

        /// <summary>Выдаёт книгу читателю, если она есть и доступна.</summary>
        public void BorrowBook(int id)
        {
            var book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine($"\nКнига с ID {id} не найдена в библиотеке.");
                return;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine($"\nКнига \"{book.Title}\" уже выдана и недоступна.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine($"\nВам успешно выдана книга \"{book.Title}\".");
        }

        /// <summary>Принимает книгу обратно, если она была выдана.</summary>
        public void ReturnBook(int id)
        {
            var book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine($"\nКнига с ID {id} не найдена в библиотеке.");
                return;
            }

            if (book.IsAvailable)
            {
                Console.WriteLine($"\nКнига \"{book.Title}\" уже в библиотеке (её никто не брал).");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine($"\nВы успешно вернули книгу \"{book.Title}\".");
        }

        /// <summary>Ищет книгу по идентификатору.</summary>
        public Book FindBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}