using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalSystem.Models;

namespace MedicalSystem
{
    public static class TestDataBasePleaseDelete
    {
        public static List<DoctorViewModel> Doctors { get; set; } =  new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name = "Patryk",
                Prescriptions = new List<PrescriptionViewModel>
                {
                   new PrescriptionViewModel
                   {
                       Name = "Recepta 1",
                       Medicines = new List<MedicineViewModel>
                       {
                           new MedicineViewModel
                           {
                               Name = "Magnez"
                           },
                           new MedicineViewModel
                           {
                               Name = "Aspiryna"
                           }
                       }
                   }
                }
            },
             new DoctorViewModel
            {
                Name = "Zbigniew",
                Prescriptions = new List<PrescriptionViewModel>
                {
                   new PrescriptionViewModel
                   {
                       Name = "Recepta 1",
                       Medicines = new List<MedicineViewModel>
                       {
                           new MedicineViewModel
                           {
                               Name = "Prezerwatywa"
                           },
                           new MedicineViewModel
                           {
                               Name = "Tabletki antykoncepcyjne"
                           }
                       }
                   }
                }
            },
              new DoctorViewModel
            {
                Name = "Mariusz",
                Prescriptions = new List<PrescriptionViewModel>
                {
                   new PrescriptionViewModel
                   {
                       Name = "Recepta 1",
                       Medicines = new List<MedicineViewModel>
                       {
                           new MedicineViewModel
                           {
                               Name = "Lewatywa"
                           },
                           new MedicineViewModel
                           {
                               Name = "Piwo"
                           }
                       }
                   }
                }
            },
        };

    }
}
