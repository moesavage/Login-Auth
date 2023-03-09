using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorole.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize]
        public IActionResult Display()
        {
            return View();
        }
    }
}