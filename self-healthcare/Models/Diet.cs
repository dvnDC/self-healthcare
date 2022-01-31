using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using self_healthcare.Areas.Identity.Data;

namespace self_healthcare.Models;

public class Diet
{
    
    public int DietID { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public DateTime Inserted { get; set; }
    
    public ICollection<Meal> Meal { get; set; }
}
