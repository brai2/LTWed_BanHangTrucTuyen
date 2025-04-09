using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    // Định nghĩa trạng thái đơn hàng
    public enum OrderStatus
    {
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        // Liên kết với khách hàng (user)
        public string CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }

        public OrderStatus Status { get; set; }

        [Required]
        public string ShippingAddress { get; set; }

        // Phương thức thanh toán: COD, chuyển khoản, ...
        public string PaymentMethod { get; set; }

        public decimal TotalAmount { get; set; }

        // Danh sách sản phẩm trong đơn hàng
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}


