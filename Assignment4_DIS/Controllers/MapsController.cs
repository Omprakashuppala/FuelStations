using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4_DIS.Models;

namespace Assignment4_DIS.Controllers
{
    public class MapsController : Controller
    {   
        public IActionResult Maps()
        {
            return View();
        }

       
    }
}
