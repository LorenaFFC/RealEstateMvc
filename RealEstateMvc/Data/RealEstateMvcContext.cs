using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstateMvc.Models;

namespace RealEstateMvc.Data
{
    public class RealEstateMvcContext : DbContext
    {
        public RealEstateMvcContext (DbContextOptions<RealEstateMvcContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstateMvc.Models.Department> Department { get; set; }
    }
}
