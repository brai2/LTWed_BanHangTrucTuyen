using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục là bắt buộc")]
        [StringLength(50, ErrorMessage = "Tên không quá 50 ký tự")]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        // Quan hệ 1-n với Product
        public ICollection<Product> Products { get; set; }
    }
}


