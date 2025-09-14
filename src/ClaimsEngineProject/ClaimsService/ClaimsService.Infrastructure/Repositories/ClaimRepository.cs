using ClaimsService.Domain;
using ClaimsService.Infrastructure.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ClaimsService.Infrastructure.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        public string _connectionString;
        public ClaimRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Default");
        }

        public async Task<int> InsertClaimAsync(Claim claim)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"
                INSERT INTO Claims (ClaimNumber, PolicyId, CustomerId)
                VALUES (@ClaimNumber, @PolicyId, @CustomerId);
                SELECT CAST(SCOPE_IDENTITY() as int);
            ";
                //Execute and get new ClaimId
                var newId = await connection.QuerySingleAsync<int>(sql, claim);
                return newId;
            }

        }
        public async Task<Claim?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            using var conn = new SqlConnection(_connectionString);
            var sql = "SELECT * FROM Claims WHERE ClaimId = @id";
            return await conn.QueryFirstOrDefaultAsync<Claim>(sql, new { id });
        }

    }
}
