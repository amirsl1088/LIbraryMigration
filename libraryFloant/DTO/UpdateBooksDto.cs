namespace LibraryNewApi.Controllers
{
    public partial class BooksController
    {
        public class UpdateBooksDto
        {
            public string Name { get; set; }
            public int GenreId { get; set; }
            public int WriterId { get; set; }
            public int Stock { get; set; }
        }

    }
}

