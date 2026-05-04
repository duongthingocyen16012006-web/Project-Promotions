using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ngocyen.Controllers;

namespace ngocyen.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ngocyenControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
