using System;

namespace UserService.Application.DTOs
{
    public class GetUserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}