using System.Collections.Generic;
using ngocyen.Roles.Dto;

namespace ngocyen.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
