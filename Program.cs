using System;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            library.AddBook(new Book { Id = 1, Title = "Идиот", Author = "Достоевский" });
            library.AddBook(new Book { Id = 2, Title = "Ромео и Джульетта", Author = "Шекспир", IsAvailable = false });
            library.AddBook(new Book { Id = 3, Title = "Гадкий утенок", Author = "Андерсен" });

            library.BorrowBook(1);
            library.ReturnBook(2);

            var found = library.FindBook(3);
            Console.WriteLine($"\nНайдена книга: {found?.Title}");

            library.BorrowBook(4);   
            library.BorrowBook(1);   
            library.ReturnBook(3);   

            try
            {
                library.AddBook(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"\nОшибка добавления: {ex.ParamName} не может быть null.");
            }

            Console.ReadKey();
        }
    }
}