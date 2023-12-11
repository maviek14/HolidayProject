using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class Booking
{
    public int BookingId { get; set; }
    public Property Property { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double CostPerNight { get; set; }
    public IdentityUser? User { get; set; }
    public string Email { get; set; }
    public string BillingAddress { get; set; }
}
