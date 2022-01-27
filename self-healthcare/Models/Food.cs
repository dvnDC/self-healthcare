using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;

namespace self_healthcare.Models;

public class Food
{
    public int  Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public int ServingSizeGrams { get; set; }
    public int Calories { get; set; }
    
}
   
