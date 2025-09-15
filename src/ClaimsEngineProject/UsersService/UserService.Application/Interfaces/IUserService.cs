using UserService.Domain.Entities;
using System.Threading.Tasks;
using UserService.Application.DTOs;
namespace UserService.Application.Interfaces
{
    public interface IUserService
    {
        public Task<int> InsertUserAsync(CreateUserDto user);
        public Task<GetUserDto?> GetByIdAsync(int userId);
    }
}