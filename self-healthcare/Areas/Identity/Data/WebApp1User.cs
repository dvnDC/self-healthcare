using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using self_healthcare.Models;

namespace self_healthcare.Areas.Identity.Data;

// Add profile data for application users by adding properties to the WebApp1User class
public class WebApp1User : IdentityUser
{
    
    public ICollection<Diet> Diets { get; set; }
}

