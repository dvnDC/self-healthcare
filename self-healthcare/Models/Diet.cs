using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using self_healthcare.Areas.Identity.Data;

namespace self_healthcare.Models;

public class Diet
{
    
    public int DietID { get; set; }
    // public int Id { get; set; }             // Food ID
    // public string WebApp1UserId { get; set; }
    public string Name { get; set; }
    public int ServingSizeGrams { get; set; }
    public int Calories { get; set; }
    public DateTime Inserted { get; set; }
    
    public Food Food { get; set; }
    public WebApp1User WebApp1User { get; set; }
    
}