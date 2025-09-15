using Microsoft.Data.SqlClient;
using Dapper;
using UserService.Domain.Entities;
using UserService.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;

namespace UserService.Infrastructure.Repositories;

public class UserRepository(IConfiguration configuration) : IUserRepository
{
    private readonly string _connectionString = configuration.GetConnectionString("Default");

    public async Task<int> InsertUserAsync(User user)
    {
        using var connection = new SqlConnection(_connectionString);
        string sql = @"
            INSERT INTO Users (Username, Email)
            VALUES (@Username, @Email);
            SELECT CAST(SCOPE_IDENTITY() as int);
        ";
        return await connection.QuerySingleAsync<int>(sql, user);
    }

    public async Task<User?> GetByIdAsync(int userId)
    {
        using var connection = new SqlConnection(_connectionString);
        string sql = "SELECT UserId, Username, Email FROM Users WHERE UserId = @UserId";
        return await connection.QuerySingleOrDefaultAsync<User>(sql, new { UserId = userId });
    }
}