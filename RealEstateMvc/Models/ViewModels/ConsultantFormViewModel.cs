using System.Collections.Generic;


namespace RealEstateMvc.Models.ViewModels
{
    public class ConsultantFormViewModel
    {
        public Consultant Consultant { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
