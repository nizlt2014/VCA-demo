using UserService.Domain.Entities;

public interface IUserService
{
    Task<int> InsertUserAsync(User user);
    Task<User?> GetByIdAsync(int userId);
}