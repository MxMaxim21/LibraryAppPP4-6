namespace LibraryApp
{
    /// <summary>Книга в библиотеке.</summary>
    public class Book
    {
        /// <summary>Идентификатор книги.</summary>
        public int Id { get; set; }

        /// <summary>Название книги.</summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>Автор книги.</summary>
        public string Author { get; set; } = string.Empty;

        /// <summary>Признак того, что книга доступна для выдачи.</summary>
        public bool IsAvailable { get; set; } = true;
    }
}