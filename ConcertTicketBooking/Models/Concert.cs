using System;
namespace ConcertTicketBooking.Models{
public class Concert
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
}}
