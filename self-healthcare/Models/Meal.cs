using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;

namespace self_healthcare.Models;

public class Meal
{
    public int  MealID { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public int ServingSizeGrams { get; set; }
    [Required]
    public int Calories { get; set; }
    
    public Diet Diet { get; set; }
    }
    