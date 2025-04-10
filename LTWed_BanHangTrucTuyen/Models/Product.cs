using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc")]
        [StringLength(100, ErrorMessage = "Tên không quá 100 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá là bắt buộc")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá không hợp lệ")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [StringLength(500, ErrorMessage = "Mô tả không quá 500 ký tự")]
        public string Description { get; set; }

        [Display(Name = "Ảnh sản phẩm")]
        public string ImageUrl { get; set; }

        // Quan hệ với Category
        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Các trường mở rộng (tùy chọn)
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public bool InStock { get; set; } = true;
    }
}


