using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateMvc.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime Date { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Rent> Rents { get; set; } = new List<Rent>();

        public Consultant()
        {
        }

        public Consultant(int id, string name, string email, double baseSalary, DateTime date, Department departments)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            Date = date;
            Department = departments;
        }

        public void AddRent(Rent rent)
        {
            Rents.Add(rent);
        }

        public void RemoveRent(Rent rent)
        {
            Rents.Remove(rent);
        }

        public double TotalRent(DateTime Initial, DateTime Final)
        {
            return Rents.Where(rent => rent.Date >= Initial && rent.Date <= Final).Sum(rent => rent.Amount);
        }
    }
}
