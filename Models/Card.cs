

namespace jaiz.Models
{
    public class Card
    {
        public string? Type { get; set; }
        public string? Issuer { get; set; }
        public long Number { get; set; }
        public string? Platform { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int AuthorizationCode { get; set; }
        public string? AuthorizationMessage { get; set; }
    }
}