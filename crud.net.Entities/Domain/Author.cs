namespace crud.net.Entities.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<Book> Books { get; set; }
    }
}