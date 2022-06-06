namespace ComicConApi.Models
{
    public class ComicConTicket
    {
        public long Id { get; set; }
        public string? TypeOfTicket { get; set; }
        public string? DatesValidFor { get; set; }
        public double PriceOfTicket { get; set; }
        public bool IsRefundable { get; set; }

    }
}
