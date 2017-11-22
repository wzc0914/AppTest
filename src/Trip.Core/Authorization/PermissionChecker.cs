using Abp.Authorization;
using Trip.Authorization.Roles;
using Trip.Authorization.Users;

namespace Trip.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
