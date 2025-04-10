namespace LTWed_BanHangTrucTuyen.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // Liên kết với User
        public ICollection<CartItem> CartItems { get; set; }
    }
}
