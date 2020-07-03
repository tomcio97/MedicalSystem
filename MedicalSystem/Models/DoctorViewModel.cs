using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalSystem.Models
{
    public class DoctorViewModel
    {
        public string Name { get; set; }

        public List<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
