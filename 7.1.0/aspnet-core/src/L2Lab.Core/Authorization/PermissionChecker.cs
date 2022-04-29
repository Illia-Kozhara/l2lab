using Abp.Authorization;
using L2Lab.Authorization.Roles;
using L2Lab.Authorization.Users;

namespace L2Lab.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
