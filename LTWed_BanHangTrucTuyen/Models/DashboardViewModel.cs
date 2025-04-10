namespace LTWed_BanHangTrucTuyen.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }
        public int TotalUsers { get; set; }
        public int TotalOrders { get; set; }
        public List<Order> RecentOrders { get; set; }
    }
}
