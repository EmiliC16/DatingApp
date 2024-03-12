using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
      public class UsersController : BaseApiController
    {
      private readonly IUserRepository _userRepository;
      private readonly IMapper _mapper;
      public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper=mapper;
            _userRepository = userRepository;
        }

       
     [HttpGet]
     public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
        var users = await _userRepository.GetMembersAsync();
       
         return Ok(users);
        }

     [HttpGet("{UserName}")]
     public async Task<ActionResult<MemberDto>> GetUser(string UserName)
        {
            return  await _userRepository.GetMembersAsync(UserName);
        }
    }
}
