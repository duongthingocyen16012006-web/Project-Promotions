using Microsoft.AspNetCore.Mvc;//Thư viện để dùng Controller
                               // Route
                               // HttpGet
                               // IActionResult
using ngocyen.Controllers;
using Abp.Web.Models;
using ngocyen.Promotions;
using System.Threading.Tasks;
namespace ngocyen.Web.Controllers 
{
    [Route("Promotion")]
    public class PromotionController :  ngocyenControllerBase //Controller Promotion kế thừa base controller của hệ thống.
    {
        private readonly PromotionAppService _promotionAppService;

        public PromotionController(PromotionAppService promotionAppService)
        {
            _promotionAppService = promotionAppService;
        }
        [DontWrapResult]
        [HttpGet("")] // chạy khi gọi GET /Promotion
        public async Task<IActionResult> Index()
        {
            var promotions = await _promotionAppService.GetAllAsync();
            return View(promotions);
        }
        [HttpGet("test")]
        public string Test()
        {
            return "Promotion OK";
        }
    }
}