using System.Collections.Generic;
using ngocyen.Roles.Dto;

namespace ngocyen.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
