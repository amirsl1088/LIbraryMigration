using libraryFloant.DTO;
using libraryFloant.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static LibraryNewApi.Controllers.UserController;

namespace libraryFloant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BookService _service;
        public UserController(BookService service)
        {
            _service = service;
        }
        public int AddUser([FromBody] AddUserDto dto)
        {
            return _service.AddUser(dto);
        }
        [HttpPut("update")]
        public void UpdateUser([FromQuery] int id, [FromBody] UpdateUsersDto dto)
        {
            Service.UpdateUser(id, dto);
        }
        [HttpDelete("delete/{id}")]
        public void DeleteUser([FromRoute] int id)
        {
            Service.DeleteUser(id);
        }
        [HttpGet("get-users")]
        public List<GetUserDto> GetUsers([FromQuery] string username = null)
        {
            return Service.GetUsers(username);
        }
        [HttpGet("get-users-books/{userid}")]
        public List<GetUsersBookDto> getUsersBooks([FromRoute] int userid)
        {
            return Service.GetUsersBooks(userid);
        }
    }
}
