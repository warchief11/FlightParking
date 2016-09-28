using System.Threading.Tasks;
using Abp.Application.Services;
using FlightParking.Roles.Dto;

namespace FlightParking.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
