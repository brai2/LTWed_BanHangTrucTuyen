using System;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class Review
    {
        public int Id { get; set; }

        // Liên kết với sản phẩm
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        // Liên kết với người dùng
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }

        // Trạng thái duyệt của đánh giá (true: được phép hiển thị, false: bị ẩn)
        public bool IsApproved { get; set; }
    }
}


