using RealEstateMvc.Data;
using RealEstateMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateMvc.Services
{
    public class ConsultantService
    {
        private readonly RealEstateMvcContext _context;

        public ConsultantService(RealEstateMvcContext context)
        {
            _context = context;
        }

        public List<Consultant> FindAll()
        {
            return _context.Consultant.ToList();
        }
    }
}
