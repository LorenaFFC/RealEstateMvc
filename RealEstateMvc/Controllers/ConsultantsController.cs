using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateMvc.Controllers
{
    public class ConsultantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
