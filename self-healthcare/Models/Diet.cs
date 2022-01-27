using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using self_healthcare.Areas.Identity.Data;

namespace self_healthcare.Models;

public class Diet
{
    
    [Key]
    public int Id { get; set; }
    [ForeignKey("UserForeignKey")]
    public WebApp1User WebApp1User { get; set; }
    
    public string Name { get; set; }
    public int ServingSizeGrams { get; set; }
    public int Calories { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime Inserted { get; set; }
    
}