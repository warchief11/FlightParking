using Abp.Authorization;
using FlightParking.Authorization.Roles;
using FlightParking.MultiTenancy;
using FlightParking.Users;

namespace FlightParking.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
