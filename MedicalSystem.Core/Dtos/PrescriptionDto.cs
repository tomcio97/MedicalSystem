using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystem.Core.Dtos
{
   public class PrescriptionDto
    {
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DoctorDto Doctor { get; set; }

        public List<MedicineDto> Medicines { get; set; }
    }
}
