using LibraryApi22.DTO;
using LibraryApi22.Models;
using static LibraryNewApi.Controllers.UserController;

namespace LibraryApi22.Services
{
    public class UserService
    {
        public  List<User> Users = new();
        public int AddUser(AddUserDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                CreateAt = dto.CreateAt
            };
            Users.Add(user);
            return user.Id;
        }
        public void UpdateUser(int id,UpdateUsersDto dto)
        {
            var user = Users.Where(_ => _.Id == id).First();
            Users.Remove(user);

            user.Name = dto.Name;
            user.Email = dto.Email;
            user.CreateAt = dto.CreateAt;
            Users.Add(user);
        }
        public void DeleteUser(int id)
        {
            var user = Users.First(_ => _.Id == id);
            Users.Remove(user);
        }
        public List<GetUserDto>GetUsers(string username=null)
        {
            var users = Users
               .Select(_ => new GetUserDto
               {
                   Id = _.Id,
                   Name = _.Name,
                   Email = _.Email,
                   CreatAt = _.CreateAt
               })
               .ToList();
            if (username != null)
            {
                users = users.Where(_ => _.Name == username).ToList();
                return users;
            }
            return users;
        }
        public List<GetUsersBookDto>GetUsersBooks(int userid)
        {
            var user = Users.FirstOrDefault(_ => _.Id == userid);
            if (user == null)
            {
                throw new Exception("user not found");
            }
            var books = user.Books.Select(_ => new GetUsersBookDto
            {
                Name = _.Name
            })
                .ToList();
            return books;
        }
    }
}
