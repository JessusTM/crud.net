using crud.net.API.Repositories;
using crud.net.Entities.Domain;

namespace crud.net.API.Services
{
    public class GenreService
    {
        private readonly GenreRepository _genreRepository;

        public GenreService(GenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<List<Genre>> GetGenres()
        {
            return await _genreRepository.GetGenres();
        }
    }
}
