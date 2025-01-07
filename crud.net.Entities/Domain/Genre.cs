namespace crud.net.Entities.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<Book> Books { get; set; }
    }
}