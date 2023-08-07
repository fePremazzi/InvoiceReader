namespace InvoiceReaderAPI.Model
{
    public class Receipt
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTimeOffset Timestamp { get; } = DateTimeOffset.Now;
        public string UrlImage { get; set; }
        public float Amount { get; set; } = 0;
        public string StoreName { get; set; }
        public string Payer { get; set; }
    }
}
