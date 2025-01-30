using System.ComponentModel.DataAnnotations;

namespace moment2_dt191g.Models;

public class TripModel {
    // Properties

    [Required(ErrorMessage = "Land måste anges.")]
    [StringLength(56, MinimumLength = 2, ErrorMessage = "Landet måste vara mellan 2 och 56 tecken.")]
    [Display(Name = "Land:")]
    public required string Country { get; set; } // Landet man besökt
    
    [Required(ErrorMessage = "Stad måste anges.")]
    [StringLength(85, MinimumLength = 2, ErrorMessage = "Stadens namn måste vara mellan 2 och 85 tecken.")]
    [Display(Name = "Stad:")]
    public required string City { get; set; } // Staden man besökte
    
    [Required(ErrorMessage = "Startdatum för resan måste anges")]
    [DataType(DataType.Date)]
    [Display(Name = "Startdatum:")]
    public DateTime? StartDate { get; set; } = DateTime.Now; // När resan startade
    
    [Required(ErrorMessage = "Slutdatum för resan måste anges")]
    [DataType(DataType.Date)]
    [Display(Name = "Slutdatum:")]
    public DateTime? EndDate { get; set; } = DateTime.Now; // När resan slutade
    
    [Required(ErrorMessage = "Betyg måste anges.")]
    [Range(1, 5, ErrorMessage = "Betyg måste vara mellan 1 och 5.")]
    [Display(Name = "Betyg:")]
    public int? Rating { get; set; } = 1; // Betyg 1-5
}


