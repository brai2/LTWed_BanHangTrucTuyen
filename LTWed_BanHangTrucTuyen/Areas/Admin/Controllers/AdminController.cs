using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LTWed_BanHangTrucTuyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")] // Chỉ Admin được truy cập
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
