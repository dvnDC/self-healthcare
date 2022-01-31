// #nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using self_healthcare.Models;
using self_healthcare.Areas.Identity.Data;

namespace self_healthcare.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

