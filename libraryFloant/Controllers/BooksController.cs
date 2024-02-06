using libraryFloant.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static LibraryNewApi.Controllers.BooksController;

namespace libraryFloant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _service;
        public BooksController(BookService service)
        {
            _service = service;
        }

        [HttpPost("add")]
        public int AddBook([FromBody] AddBookDto dto)
        {
            return _service.AddBook(dto);
        }
        [HttpPut("update/{id}")]
        public void UpdateBooks([FromRoute] int id, UpdateBooksDto dto)
        {
            _service.UpdateBook(id, dto);
        }
        [HttpDelete("delete-book/{id}")]
        public void DeleteBook([FromRoute] int id)
        {
            _service.DeleteBook(id);
        }
        [HttpGet("get-books")]
        public List<GetBookDto> GetBooks([FromQuery] string bookname = null)
        {
            return _service.GetBooks(bookname);
        }
        [HttpPatch("rent-books")]
        public void RentBook([FromQuery] int userid, [FromQuery] int bookid)
        {
            _service.RentBook(userid, bookid);
        }
    }
}
