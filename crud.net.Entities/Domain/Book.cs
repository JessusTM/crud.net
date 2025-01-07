using System.ComponentModel.DataAnnotations;

namespace crud.net.Entities.Domain
{
    public class Book
    {
        [Range(0, int.MaxValue, ErrorMessage = "ID es obligatorio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "ISBN es obligatorio.")]
        public string ISBN { get; set; } = string.Empty;

        [Required(ErrorMessage = "Título es obligatorio.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Autor es obligatorio.")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descripción es obligatorio.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Language es obligatorio.")]
        public string Language { get; set; } = string.Empty;

        [Required(ErrorMessage = "Año de publicación es obligatorio.")]
        public int PublicationYear { get; set; }

        [Required(ErrorMessage = "Páginas es obligatorio.")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "Stock es obligatorio")]
        public int Stock { get; set; }

        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Author> Authors { get; set; } = new List<Author>();
    }
}
