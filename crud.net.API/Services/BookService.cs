using crud.net.Entities.Domain;
using crud.net.Entities.Interfaces;

namespace crud.net.API.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _bookRepository.GetBooks();
        }

        public async Task<Book> GetBookById(int id)
        {
            if (id <= 0) throw new ArgumentException("[BookService] ID must be a positive value.");
            return await _bookRepository.GetBookById(id);
        }

        public async Task<Book> AddBook(Book book)
        {
            if (book.Stock < 0) throw new ArgumentException("[BookService] Stock cannot be negative.");
            return await _bookRepository.AddBook(book);
        }

        public async Task<Book> UpdateBook(int id, Book book)
        {
            if (id <= 0) throw new ArgumentException("[BookService] ID must be a positive value.");
            if (book.Stock < 0) throw new ArgumentException("[BookService] Stock cannot be negative.");
            return await _bookRepository.UpdateBook(id, book);
        }

        public async Task DeleteBook(int id)
        {
            if (id <= 0) throw new ArgumentException("[BookService] ID must be a positive value.");
            await _bookRepository.DeleteBook(id);
        }
    }
}