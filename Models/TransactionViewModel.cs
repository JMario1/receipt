

namespace jaiz.Models
{
    public class TransactionViewModel
    {
        public string? Type { get; set; }
        public Merchant? Merchant { get; set; }
        public long STAN { get; set; }
        public DateTime Time { get; set; }
        public double Amount { get; set; }
        public string? Currency { get; set; }
        public Card? Card { get; set; }
        public bool Status { get; set; }
        public int ResponseCode { get; set; }
        public string? ResponseMessage { get; set; }
        public string? AID { get; set; }
        public int RRN { get; set; }
        public string? PTAD { get; set; }
        public string? GeneratedFor { get; set; }
        public string? Device { get; set; }
    }
}