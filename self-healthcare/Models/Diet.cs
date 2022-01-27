using System.ComponentModel.DataAnnotations.Schema;
using self_healthcare.Areas.Identity.Data;

namespace self_healthcare.Models;

public class Diet
{
    
    [ForeignKey("FoodForeignKey")]
    public Food Food { get; set; }
    
    
    [ForeignKey("UserForeignKey")]
    public WebApp1User WebApp1User { get; set; }
}