using System.ComponentModel.DataAnnotations;

namespace moment2_dt191g.Models;

public class TripModel {
    // Properties

    [Required(ErrorMessage = "Land måste anges.")]
    [StringLength(56, MinimumLength = 2, ErrorMessage = "Landet måste vara mellan 2 och 56 tecken.")]
    public required string Country { get; set; } // Landet man besökt
    
    [Required(ErrorMessage = "Stad måste anges.")]
    [StringLength(85, MinimumLength = 1, ErrorMessage = "Stadens namn måste vara mellan 1 och 85 tecken.")]
    public required string City { get; set; } // Staden man besökte
    
    [Required(ErrorMessage = "Startdatum måste anges.")]
    [DataType(DataType.Date, ErrorMessage = "Startdatum måste vara ett giltigt datum.")]
    public DateTime StartDate { get; set; } // När resan startade
    
    [Required(ErrorMessage = "Slutdatum måste anges.")]
    [DataType(DataType.Date, ErrorMessage = "Slutdatum måste vara ett giltigt datum.")]
    public DateTime EndDate { get; set; } // När resan slutade
    
    [Required(ErrorMessage = "Betyg måste anges.")]
    [Range(1, 5, ErrorMessage = "Betyg måste vara mellan 1 och 5.")]
    public required int Rating { get; set; } // Betyg 1-5
}