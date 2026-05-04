using System.Collections.Generic;
using ngocyen.Roles.Dto;

namespace ngocyen.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}