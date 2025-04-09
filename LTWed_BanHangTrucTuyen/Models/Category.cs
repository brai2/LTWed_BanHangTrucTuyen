using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        // Quan hệ 1-n với sản phẩm
        public virtual ICollection<Product> Products { get; set; }
    }
}


