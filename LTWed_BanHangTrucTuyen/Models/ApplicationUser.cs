using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        // Quan hệ 1-n với Order (tùy chọn)
        public ICollection<Order> Orders { get; set; }
    }
}


