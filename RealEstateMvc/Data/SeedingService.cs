using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstateMvc.Models;

namespace RealEstateMvc.Data
{
    // REGISTRAR O SERVICO NA INJ DE DEPENDENCIA DA APP - Startup.cs
    public class SeedingService
    {
        private RealEstateMvcContext _context;

        public SeedingService(RealEstateMvcContext context)
        {
            _context = context;
        }

        // Vai Popular a base
        public int Seed() 
        { 
            if(_context.Department.Any() || 
                _context.Consultant.Any() ||
                _context.Rent.Any())
            {
                return 0; // O Banc Ja foi populado
            }
            return 1;
        
        }


    }
}

