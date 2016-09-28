using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using FlightParking.Authorization.Roles;
using FlightParking.Editions;
using FlightParking.Users;

namespace FlightParking.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}