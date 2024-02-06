namespace libraryFloant.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public string Name { get; set; }
        public Writer Writer { get; set; }
        public int WriterId { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
