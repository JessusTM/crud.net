using crud.net.Entities.Domain;

namespace crud.net.Entities.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetGenres();
    }
}