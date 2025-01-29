using System.ComponentModel.DataAnnotations;

namespace moment2_dt191g.Models;

public class TripModel {
    // Properties

    [Required]
    public required string Country { get; set; } // Landet man besökt
    
    [Required]
    public required string City { get; set; } // Staden man besökte
    
    [Required]
    public DateTime StartDate { get; set; } // När resan startade
    
    [Required]
    public DateTime EndDate { get; set; } // När resan slutade
    
    [Required]
    public required int Rating { get; set; } // Betyg 1-5
}