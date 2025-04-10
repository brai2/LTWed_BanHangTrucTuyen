using LTWed_BanHangTrucTuyen.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LTWed_BanHangTrucTuyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepo;

        public OrdersController(IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }

        // GET: /Admin/Orders
        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepo.GetAllAsync();
            return View(orders);
        }

        // GET: /Admin/Orders/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var order = await _orderRepo.GetOrderWithDetailsAsync(id);
            if (order == null) return NotFound();

            return View(order);
        }

        // POST: /Admin/Orders/UpdateStatus
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int orderId, string status)
        {
            var order = await _orderRepo.GetByIdAsync(orderId);
            if (order == null) return NotFound();

            order.Status = status;
            await _orderRepo.UpdateAsync(order);

            TempData["Success"] = "Cập nhật trạng thái thành công!";
            return RedirectToAction(nameof(Index));
        }
    }
}
