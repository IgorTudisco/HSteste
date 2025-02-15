using Abp.Authorization;
using HSteste.Authorization.Roles;
using HSteste.Authorization.Users;

namespace HSteste.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
