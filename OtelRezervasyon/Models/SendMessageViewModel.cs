namespace OtelRezervasyon.Models
{
    public class SendMessageViewModel
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
