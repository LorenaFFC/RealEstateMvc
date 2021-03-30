using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Consultant> Consultants { get; set; } = new List<Consultant>();

        public Department()
        {
        }

        public Department(int id, string name, ICollection<Consultant> consultants)
        {
            Id = id;
            Name = name;
        }

        public void addConsultant(Consultant consultant)
        {
            Consultants.Add(consultant);
        }

        public double TotalDepartament(DateTime initial, DateTime final)
        {
            return Consultants.Sum(consultant => consultant.TotalRent(initial, final));
        }
    }
}
