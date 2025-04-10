namespace LTWed_BanHangTrucTuyen.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }  // Liên kết với User
        public int Rating { get; set; }     // 1-5 sao
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
