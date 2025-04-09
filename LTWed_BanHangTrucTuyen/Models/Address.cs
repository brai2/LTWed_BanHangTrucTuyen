using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public class Address
    {
        public int Id { get; set; }

        // Liên kết với người dùng
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        [MaxLength(250)]
        public string StreetAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
    }
}


