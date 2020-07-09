using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystem.Core.Dtos
{
   public class DoctorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkYears { get; set; }
        public string IsAbleToMakePrescriptions { get; set; }
        public List<PrescriptionDto> Prescriptions { get; set; }
    }
}
