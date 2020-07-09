using System.Collections.Generic;
using MedicalSystem.Core.Dtos;

namespace MedicalSystem.Core
{
    public interface IDoctorManager
    {
        bool AddDoctor(DoctorDto doctor);
        bool AddMedicine(int prescriptionId, MedicineDto medicine);
        bool AddPrescription(int doctorId, PrescriptionDto prescription);
        bool DeleteDoctor(DoctorDto doctor);
        bool DeleteMedicine(MedicineDto medicine);
        bool DeletePrescription(PrescriptionDto prescription);
        IEnumerable<DoctorDto> GetAllDoctors(string filterString);
        IEnumerable<MedicineDto> GetAllMedicinesForAPrescription(int prescriptionId, string filterString);
        IEnumerable<PrescriptionDto> GetAllPrescriptionsForADoctor(int doctorId, string filterString);
    }
}