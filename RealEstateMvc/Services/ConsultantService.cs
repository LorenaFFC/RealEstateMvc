using Microsoft.EntityFrameworkCore;
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

        public void Insert(Consultant obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Consultant FindById(int id)
        {  // Dessa forma caarrega apenas o consultor. Para carregar o depto tem que fazer o join
           // return _context.Consultant.FirstOrDefault(obj => obj.Id == id);
            return _context.Consultant.Include(obj => obj.Department).FirstOrDefault(obj => 
            obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Consultant.Find(id);
            _context.Consultant.Remove(obj);
            _context.SaveChanges();

        }
    }
}
