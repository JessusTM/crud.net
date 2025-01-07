using System.Net.Http.Json;
using crud.net.Entities.Domain;
using static System.Reflection.Metadata.BlobBuilder;

namespace crud.net.Client.Services
{
    public class BookService
    {
        private List<Book> books;
        private readonly HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            books = new List<Book>();
        }

        public async Task<List<Book>> GetBooks()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<Book>>("api/book");
                return response ?? new List<Book>();
            }
            catch (Exception)
            {
                return new List<Book>();
            }
        }
    }
}
