using System.ComponentModel.DataAnnotations;

namespace crud.net.Entities
{
    public class Book
    {
        [Range(0, int.MaxValue, ErrorMessage = "ID es obligatorio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "ISBN es obligatorio.")]
        public required string ISBN { get; set; }

        [Required(ErrorMessage = "Título es obligatorio.")]
        public required string Title { get; set; }
        [Required(ErrorMessage = "Autor es obligatorio.")]
        public required string Author { get; set; }
        [Required(ErrorMessage = "Descripción es obligatorio.")]
        public required string Description { get; set; }
        [Required(ErrorMessage = "Language es obligatorio.")]
        public required string Language { get; set; }
        [Required(ErrorMessage = "Año de publicación es obligatorio.")]
        public required int PublicationYear { get; set; }
        [Required(ErrorMessage = "Páginas es obligatorio.")]
        public required int Pages { get; set; }

        public byte[]? Image { get; set; }
        public byte[]? File { get; set; }
        public string? FileName { get; set; }

        [Required(ErrorMessage = "Stock es obligatorio")]
        public int Stock { get; set; }

        public required List<Genre> Genres { get; set; }
        public required List<Author> Authors { get; set; }
    }
}
