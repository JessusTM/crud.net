using crud.net.Entities.Domain;

namespace crud.net.Entities.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(int id, Book book);
        Task DeleteBook(int id);
    }
}