using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(150)]
        public string FullName { get; set; }

        // Bạn có thể bổ sung thêm các thuộc tính khác như ngày sinh, ảnh đại diện, v.v.
    }
}


