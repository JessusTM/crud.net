using crud.net.API.Data;
using crud.net.Entities.Domain;
using crud.net.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace crud.net.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> AddBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) throw new KeyNotFoundException($"Book with id {id} not found.");
            
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) throw new KeyNotFoundException($"Book with id {id} not found.");
            return book;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> UpdateBook(int id, Book book)
        {
            var foundBook = await _context.Books.FindAsync(id);
            if (foundBook == null) throw new KeyNotFoundException($"Book with id {id} not found.");
            
            _context.Entry(foundBook).CurrentValues.SetValues(book);
            await _context.SaveChangesAsync();
            return foundBook;
        }
    }
}
