using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using CsvHelper;
using System.Linq;
using CsvHelper.Configuration;

namespace self_healthcare.Models;

public class Food
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public string ServingSizeGrams { get; set; }
    public string Calories { get; set; }
    
}
   
