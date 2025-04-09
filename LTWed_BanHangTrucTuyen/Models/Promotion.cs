using System;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public enum DiscountType
    {
        Percentage,
        FixedAmount
    }

    public class Promotion
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        public DiscountType DiscountType { get; set; }

        [Required]
        public decimal DiscountValue { get; set; }

        // Ngày hết hạn của mã khuyến mãi (nếu có)
        public DateTime? ExpirationDate { get; set; }

        // Số lượt sử dụng tối đa
        public int UsageLimit { get; set; }

        // Điều kiện tối thiểu của đơn hàng (nếu có)
        public decimal? MinimumOrderAmount { get; set; }

        // Số lần mã đã được sử dụng
        public int TimesUsed { get; set; }
    }
}


