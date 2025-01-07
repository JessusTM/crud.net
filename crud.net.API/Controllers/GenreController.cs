using crud.net.API.Services;
using crud.net.Entities.Domain;
using Microsoft.AspNetCore.Mvc;

namespace crud.net.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly GenreService _genreService;

        public GenreController(GenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genre>>> GetGenres()
        {
            try
            {
                var response = await _genreService.GetGenres();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"[GenreController] Error retrieving data from the database: {ex.Message} | Inner: {ex.InnerException?.Message}");
            }
        }
    }
}
