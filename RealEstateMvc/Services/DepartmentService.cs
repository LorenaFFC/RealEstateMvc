using RealEstateMvc.Data;
using RealEstateMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateMvc.Services
{
    public class DepartmentService
    {
        private readonly RealEstateMvcContext _context;

        public DepartmentService(RealEstateMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
