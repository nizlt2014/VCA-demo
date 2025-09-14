using UserService.Domain.Entities;

namespace  UserService.Infrastructure.Interfaces;
public interface IUserRepository
{
    Task<int> InsertUserAsync(User user);
    Task<User?> GetByIdAsync(int userId);
}