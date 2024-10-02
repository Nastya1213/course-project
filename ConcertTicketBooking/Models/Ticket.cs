namespace ConcertTicketBooking.Models{
public class Ticket
{
    public int Id { get; set; }
    public int ConcertId { get; set; }
    public string PriceCategory { get; set; }
    public int AvailableSeats { get; set; }
    public string UniqueIdentifier { get; set; }
}
}