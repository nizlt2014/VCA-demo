using AutoMapper;
using UserService.Application.DTOs;
using UserService.Domain.Entities;
using UserService.Infrastructure.Interfaces;
using System;
using System.Threading.Tasks;

namespace UserService.Application.Services
{

    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<GetUserDto?> GetByIdAsync(int userId)
        {
            await _userRepository.GetByIdAsync(userId);
            var user = await _userRepository.GetByIdAsync(userId);
            if (user != null)
            {
                return _mapper.Map<GetUserDto>(user);
            }
            return null;
        }

        public async Task<int> InsertUserAsync(CreateUserDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }
            var userEntity = _mapper.Map<User>(user);
            var id = await _userRepository.InsertUserAsync(userEntity);
            return id;
        }
    }
}


