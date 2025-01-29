namespace moment2_dt191g.Models;

public class TripModel {
    // Properties
    public required string Country { get; set; } // Landet man besökt
    public required string City { get; set; } // Staden man besökte
    public DateTime StartDate { get; set; } // När resan startade
    public DateTime EndDate { get; set; } // När resan slutade
    public required int Rating { get; set; } // Betyg 1-5
}