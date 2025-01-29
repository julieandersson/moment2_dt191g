using System.ComponentModel.DataAnnotations;

namespace moment2_dt191g.Models;

public class TripModel {
    // Properties

    [Required]
    [StringLength(56, MinimumLength = 2)]
    public required string Country { get; set; } // Landet man besökt
    
    [Required]
    [StringLength(85, MinimumLength = 1)]
    public required string City { get; set; } // Staden man besökte
    
    [Required]
    [DataType(DataType.Date)]
    public required DateTime StartDate { get; set; } // När resan startade
    
    [Required]
    [DataType(DataType.Date)]
    public required DateTime EndDate { get; set; } // När resan slutade
    
    [Required]
    [Range(1, 5)]
    public required int Rating { get; set; } // Betyg 1-5
}


