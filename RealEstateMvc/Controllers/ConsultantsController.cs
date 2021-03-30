using Microsoft.AspNetCore.Mvc;
using RealEstateMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateMvc.Controllers
{
    public class ConsultantsController : Controller
    {
        private readonly ConsultantService _consultantService;

        public ConsultantsController(ConsultantService consultantService)
        {
            _consultantService = consultantService;
        }

        public IActionResult Index()
        {
            var list = _consultantService.FindAll();
            return View(list);
        }
    }
}
