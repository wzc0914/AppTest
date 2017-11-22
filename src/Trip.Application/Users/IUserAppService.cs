using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Trip.Roles.Dto;
using Trip.Users.Dto;

namespace Trip.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}