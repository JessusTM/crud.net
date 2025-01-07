using crud.net.API.Services;
using crud.net.Entities.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.net.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            try
            {
                var response = await _bookService.GetBooks();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"[BookController] Error retrieving data from the database: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            try
            {
                var response = await _bookService.GetBookById(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"[BookController] Error retrieving data from the database: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            try
            {
                var response = await _bookService.AddBook(book);
                return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"[BookController] Error adding data to the database: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> UpdateBook(int id, Book book)
        {
            try
            {
                var response = await _bookService.UpdateBook(id, book);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"[BookController] Error updating data in the database: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            try
            {
                await _bookService.DeleteBook(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"[BookController] Error deleting data from the database: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }
    }
}
