using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        // Liên kết với đơn hàng
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        // Liên kết với sản phẩm
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        // Mức chiết khấu áp dụng cho sản phẩm (nếu có)
        public decimal Discount { get; set; }
    }
}


