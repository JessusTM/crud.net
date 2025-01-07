using crud.net.API.Data;
using crud.net.Entities.Domain;
using crud.net.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace crud.net.API.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<List<Genre>> GetGenres()
        {
            return await _context.Genres.ToListAsync();
        }
    }
}
