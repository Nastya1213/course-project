namespace ConcertTicketBooking.Models{
public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ConcertId { get; set; }
    public int TicketCount { get; set; }
    public string OrderStatus { get; set; } // например, "Ожидает", "Завершен", "Отменен"
}}
