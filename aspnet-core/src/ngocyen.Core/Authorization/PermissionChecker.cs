using Abp.Authorization;
using ngocyen.Authorization.Roles;
using ngocyen.Authorization.Users;

namespace ngocyen.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
