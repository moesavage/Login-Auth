using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorole.Controllers
{

    public class AdminController : Controller
    {
        [Authorize(Roles = "admin")]
        public IActionResult Display()
        {
            return View();
        }
    }
}