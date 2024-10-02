using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace ConcertTicketBooking.Models{

public class User : IdentityUser
{
    public string Name { get; set; }
    public List<Order> PurchaseHistory { get; set; } = new List<Order>();
}
}
