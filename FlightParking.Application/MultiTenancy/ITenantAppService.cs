using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FlightParking.MultiTenancy.Dto;

namespace FlightParking.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
