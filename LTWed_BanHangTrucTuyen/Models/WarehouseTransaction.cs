using System;
using System.ComponentModel.DataAnnotations;

namespace LTWed_BanHangTrucTuyen.Models
{
    public enum TransactionType
    {
        Import,
        Export,
        ManualAdjustment
    }

    public class WarehouseTransaction
    {
        public int Id { get; set; }

        // Liên kết với sản phẩm
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public TransactionType TransactionType { get; set; }

        // Số lượng thay đổi (có thể âm hoặc dương)
        public int QuantityChanged { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Notes { get; set; }
    }
}


