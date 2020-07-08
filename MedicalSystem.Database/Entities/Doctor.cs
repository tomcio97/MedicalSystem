using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MedicalSystem.Database.Entities.Base;

namespace MedicalSystem.Database.Entities
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkYears { get; set; }
        public string IsAbleToMakePrescriptions { get; set; }

        [NotMapped]
        public virtual List<Prescription> Prescriptions { get; set; }
    }
}
