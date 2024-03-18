using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Interfaces
{
    public interface IUserRepository
    {
       void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
       Task<AppUser> GetUserByUserNameAsync(string UserName);
       Task<IEnumerable<MemberDto>>GetMembersAsync();
       Task<MemberDto> GetMembersAsync(string UserName);
       
    }
}