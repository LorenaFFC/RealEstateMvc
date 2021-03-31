﻿using Microsoft.AspNetCore.Mvc;
using RealEstateMvc.Models;
using RealEstateMvc.Models.ViewModels;
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
        private readonly DepartmentService _departmentService;

        public ConsultantsController(ConsultantService consultantService, DepartmentService departmentService)
        {
            _consultantService = consultantService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _consultantService.FindAll();
            return View(list);
        }
        
        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new ConsultantFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Consultant consultant)
        {
            _consultantService.Insert(consultant);
            return RedirectToAction(nameof(Index));
        }
    }
}
