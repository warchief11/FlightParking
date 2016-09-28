using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FlightParking.Users.Dto;

namespace FlightParking.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultOutput<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}