using Abp.Authorization;
using SMS.ALL.Authorization.Roles;
using SMS.ALL.Authorization.Users;

namespace SMS.ALL.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
