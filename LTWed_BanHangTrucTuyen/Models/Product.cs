using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Giá khuyến mãi (nếu có)
        public decimal? DiscountPrice { get; set; }

        // Số lượng tồn kho
        public int StockQuantity { get; set; }

        // URL hình ảnh sản phẩm (có thể mở rộng thành danh sách nếu cần)
        public string ImageUrl { get; set; }

        // Trạng thái sản phẩm: hiển thị hay ẩn, còn hàng hay hết hàng
        public bool IsActive { get; set; }
        public bool InStock { get; set; }

        // Liên kết với danh mục
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Danh sách đánh giá của sản phẩm
        public virtual ICollection<Review> Reviews { get; set; }
    }
}


