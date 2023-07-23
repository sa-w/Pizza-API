using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Pizza {
    
    [Required]
    public int Id { get; set; }
    [StringLength(100)]

    [Required]
    public string? Name {get; set;}

    public bool IsGlutenFree {get; set;}
}