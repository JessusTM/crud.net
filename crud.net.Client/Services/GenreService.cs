using System.Net.Http.Json;
using crud.net.Entities.Domain;

namespace crud.net.Client.Services
{
    public class GenreService
    {
        private readonly HttpClient _httpClient;

        public GenreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Genre>> GetGenres()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<Genre>>("api/genre");
                return response ?? new List<Genre>();
            }
            catch (Exception)
            {
                return new List<Genre>();
            }
        }
    }
}
